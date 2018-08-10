using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NewsFeedApis.Models
{
    public class News
    {
        public int Id { get; set; }

        [Required]
        [StringLength(maximumLength: 1000, MinimumLength = 5)]
        public string Message { get; set; }

        public string ImageUrl { get; set; }
        public int UserInfoId { get; set; }
        public virtual UserInfo UserInfo { get; set; }
        public DateTime DateCreated { get; set; }
    }


}
