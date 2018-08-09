using NewsFeedApis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsFeedApis.Data
{
    public static class DbInitializer
    {
        public static void Initialize(NewsFeedContext context)
        {
            //context.Database.EnsureDeleted();
            context.Database.EnsureCreated();


            //Look for any students.
            if (context.News.Any())
                {
                    return;   // DB has been seeded
                }

            var students = new News[]
            {
                new News { Message = "Manbir Singh Rakhra1", DateCreated =  DateTime.Now, UserInfo = new UserInfo { UserEmail ="administrator1@gmail.com", UserName = "GoogleAdministrator1" } },
                new News { Message = "Manbir Singh Rakhra2", DateCreated =  DateTime.Now, UserInfo = new UserInfo { UserEmail ="administrator2@gmail.com", UserName = "GoogleAdministrator2" } },
                new News { Message = "Manbir Singh Rakhra3", DateCreated =  DateTime.Now, UserInfo = new UserInfo { UserEmail ="administrator3@gmail.com", UserName = "GoogleAdministrator3" } }
            };
            foreach (News s in students)
            {
                context.News.Add(s);
            }
            context.SaveChanges();

        }
    }
}
