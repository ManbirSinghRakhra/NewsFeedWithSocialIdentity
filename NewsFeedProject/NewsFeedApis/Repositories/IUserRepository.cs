using NewsFeedApis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsFeedApis.Repositories
{
    public interface IUserRepository
    {
        bool UserExists(string userName);
        UserInfo GetUserByUserEmail(string userEmail);
    }
}
