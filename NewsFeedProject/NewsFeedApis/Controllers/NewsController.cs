using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NewsFeedApis.Models;
using NewsFeedApis.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using NewsFeedApis.Models.DomainModels;
using System;

namespace NewsFeedApis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class NewsController : ControllerBase
    {
        private readonly INewsFeedRepository newsFeedRepository;

        public NewsController(INewsFeedRepository newsFeedRepository)
        {
            this.newsFeedRepository = newsFeedRepository;
        }

        // GET: api/News
        [HttpGet]
        [AllowAnonymous]
        public ActionResult<IEnumerable<NewsFeedDTO>> GetNews()
        {
            var  GetAllNewsArticles = newsFeedRepository.GetAllNewsArticles();
            var newsFeedDto = GetAllNewsArticles.Select(c => new NewsFeedDTO
            {
                Message = c.Message,
                UserEmail = c.UserInfo.UserEmail,
                UserName = c.UserInfo.UserName,
                DateCreated = c.DateCreated
            });
            return Ok(newsFeedDto);

        }

        // POST: api/News
        [HttpPost]
        [ProducesResponseType(400)]
        public async Task<IActionResult> PostNews(NewsFeedDTO newsDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            UserInfo userInfo = new UserInfo();
            if (newsFeedRepository.UserExists(newsDto.UserEmail))
            {
                userInfo = newsFeedRepository.GetUserByUserEmail(newsDto.UserEmail);
            }
            else
            {
                userInfo.UserEmail = newsDto.UserEmail;
                userInfo.UserName = newsDto.UserName;
            }


            var news = new News
            {
                Message= newsDto.Message,
                DateCreated = DateTime.Now,
                UserInfo = userInfo
            };

            await newsFeedRepository.SaveNewsAsync(news);
            return CreatedAtAction("GetNews", new { id = news.Id }, news);
        }
    }
}