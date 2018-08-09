using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NewsFeedApis.Models;

namespace NewsFeedApis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class NewsController : ControllerBase
    {
        private readonly NewsFeedContext _context;

        public NewsController(NewsFeedContext context)
        {
            _context = context;
        }

        // GET: api/News
        [HttpGet]
        public IEnumerable<News> GetNews()
        {
            return _context.News.Include(c=>c.UserInfo);
        }

        // GET: api/News/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetNews([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var news = await _context.News.FindAsync(id);

            if (news == null)
            {
                return NotFound();
            }

            return Ok(news);
        }

        // PUT: api/News/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutNews([FromRoute] int id, [FromBody] News news)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != news.Id)
            {
                return BadRequest();
            }

            _context.Entry(news).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NewsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/News
        [HttpPost]
        public async Task<IActionResult> PostNews([FromBody] News news)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.News.Add(news);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetNews", new { id = news.Id }, news);
        }

        // DELETE: api/News/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNews([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var news = await _context.News.FindAsync(id);
            if (news == null)
            {
                return NotFound();
            }

            _context.News.Remove(news);
            await _context.SaveChangesAsync();

            return Ok(news);
        }

        private bool NewsExists(int id)
        {
            return _context.News.Any(e => e.Id == id);
        }
    }
}