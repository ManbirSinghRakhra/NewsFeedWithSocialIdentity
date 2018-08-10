using Microsoft.EntityFrameworkCore;
using NewsFeedApis.Models;
using NewsFeedApis.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace NewsFeedApis.Repositoryies.RepositoriesImpl
{
    public class NewsFeedRepository : INewsFeedRepository
    {
        private readonly NewsFeedContext context;

        public NewsFeedRepository(NewsFeedContext context)
        {
            this.context = context;
        }
        public List<News> GetAllNewsArticles()
        {
            return context.News.Include(c => c.UserInfo).ToList();
        }

        public async Task<int> SaveNewsAsync(News news)
        {
            int rowsAffected = 0;
            context.News.Add(news);

            rowsAffected = await context.SaveChangesAsync();
            return rowsAffected;
        }

        public UserInfo GetUserByUserEmail(string userEmail)
        {
            return context.UserInfos.SingleOrDefault(c => c.UserEmail == userEmail);
        }
        public bool UserExists(string userEmail)
        {
            return context.UserInfos.Any(c => c.UserEmail == userEmail);
        }
    }
}
