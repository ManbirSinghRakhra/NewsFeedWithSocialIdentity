using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NewsFeedApis.Models;
using NewsFeedApis.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NewsFeedApis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class NewsController : ControllerBase
    {
        private readonly INewsRepository newsRepository;

        public NewsController(INewsRepository newsRepository)
        {
            this.newsRepository = newsRepository;
        }

        // GET: api/News
        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<List<News>>> GetNewsAsync()
        {
            return await newsRepository.GetAllNewsArticles();

        }

        // POST: api/News
        [HttpPost]
        [ProducesResponseType(400)]
        public async Task<IActionResult> PostNews([FromBody] News news)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await newsRepository.SaveNewAsync(news);
            return CreatedAtAction("GetNews", new { id = news.Id }, news);
        }

        // GET: api/News/5
        //[HttpGet("{id}")]
        //public async Task<IActionResult> GetNewsAsync([FromRoute] int id)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    var news = await _context.News.FindAsync(id);

        //    if (news == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(news);
        //}

        // PUT: api/News/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutNews([FromRoute] int id, [FromBody] News news)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != news.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(news).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!NewsExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}


        // DELETE: api/News/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteNews([FromRoute] int id)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    var news = await _context.News.FindAsync(id);
        //    if (news == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.News.Remove(news);
        //    await _context.SaveChangesAsync();

        //    return Ok(news);
        //}

        //private bool NewsExists(int id)
        //{
        //    return _context.News.Any(e => e.Id == id);
        //}
    }
}