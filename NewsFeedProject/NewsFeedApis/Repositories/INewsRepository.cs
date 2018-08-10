using NewsFeedApis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsFeedApis.Repositories
{
    public interface INewsRepository
    {
        List<News> GetAllNewsArticles();
        Task<int> SaveNewsAsync(News news);
    }
}
