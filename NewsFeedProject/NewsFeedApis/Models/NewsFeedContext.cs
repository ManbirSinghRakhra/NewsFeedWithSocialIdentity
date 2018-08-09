using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsFeedApis.Models
{
    public class NewsFeedContext: DbContext
    {
        public NewsFeedContext(DbContextOptions<NewsFeedContext> options): base(options)
        {

        }


        public DbSet<News> News { get; set; }
        public DbSet<UserInfo> UserInfos { get; set; }
    }
}
