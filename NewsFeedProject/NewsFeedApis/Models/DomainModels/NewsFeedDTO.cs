using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsFeedApis.Models.DomainModels
{
    public class NewsFeedDTO
    {
        public string Message { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
