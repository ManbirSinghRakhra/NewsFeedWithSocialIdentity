﻿using NewsFeedApis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsFeedApis.Repositories
{
    public interface INewsFeedRepository: IUserRepository, INewsRepository
    {

    }
}
