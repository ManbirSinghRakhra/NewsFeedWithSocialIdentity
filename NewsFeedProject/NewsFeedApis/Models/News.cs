using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsFeedApis.Models
{
    public class News
    {
        public int Id { get; set; }
        public string UserInfoId { get; set; }
        public string Message { get; set; }
        public string ImageUrl { get; set; }
        public UserInfo UserInfo { get; set; }
    }


}
