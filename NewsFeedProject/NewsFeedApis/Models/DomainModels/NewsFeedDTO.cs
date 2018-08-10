using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NewsFeedApis.Models.DomainModels
{
    public class NewsFeedDTO
    {
        [Required]
        [StringLength(maximumLength:1000, MinimumLength = 5)]
        public string Message { get; set; }

        [Required]
        [StringLength(maximumLength: 100)]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string UserEmail { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
