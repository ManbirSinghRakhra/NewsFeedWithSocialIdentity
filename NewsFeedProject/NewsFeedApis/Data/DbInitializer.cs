using NewsFeedApis.Models;
using System;
using System.Linq;

namespace NewsFeedApis.Data
{
    public static class DbInitializer
    {
        public static void Initialize(NewsFeedContext context)
        {
            // context.Database.EnsureDeleted();
            context.Database.EnsureCreated();


            //Look for any News.
            if (context.News.Any())
            {
                return;   // DB has been seeded
            }

            var user1 = new UserInfo { UserEmail = "manbir.s.rakhra@gmail.com", UserName = "Manbir Singh Rakhra" };

            var students = new News[]
            {
                new News { Message = "I hope you will have nice experience. All the best :)", DateCreated =  DateTime.Now, UserInfo = user1 },
                new News { Message = "Identity server with External Google Identity System using OIDC.", DateCreated =  DateTime.Now, UserInfo = user1 },
                new News { Message = "Login before posting news items and mark your identity in the News Feed world.", DateCreated =  DateTime.Now, UserInfo = user1 },
                new News { Message = "These posts are in datecreated order.!!", DateCreated =  DateTime.Now, UserInfo = user1 },
                new News { Message = "This is message from system administrator. Click my name below and send me an email.", DateCreated =  DateTime.Now, UserInfo = user1 },
                new News { Message = "Welcome to the Judges!!", DateCreated =  DateTime.Now, UserInfo = user1 },
            };
            foreach (News s in students)
            {
                context.News.Add(s);
            }
            context.SaveChanges();

        }
    }
}
