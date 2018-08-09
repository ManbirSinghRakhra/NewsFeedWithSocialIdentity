using Microsoft.EntityFrameworkCore;
using NewsFeedApis.Models;
using NewsFeedApis.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace NewsFeedApis.Repositoryies.RepositoriesImpl
{
    public class NewsRepository : INewsRepository
    {
        private readonly NewsFeedContext context;

        public NewsRepository(NewsFeedContext context)
        {
            this.context = context;
        }
        public async Task<List<News>> GetAllNewsArticles()
        {
            return await context.News.Include(c => c.UserInfo).ToListAsync();
        }

        public async Task<int> SaveNewAsync(News news)
        {
            int rowsAffected = 0;


            context.News.Add(news);

            rowsAffected = await context.SaveChangesAsync();
            return rowsAffected;
        }
    }
}
