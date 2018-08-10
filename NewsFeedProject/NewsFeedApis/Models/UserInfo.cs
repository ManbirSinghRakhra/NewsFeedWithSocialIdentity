using System.ComponentModel.DataAnnotations;

namespace NewsFeedApis.Models
{
    public class UserInfo
    {
        public int Id { get; set; }


        [Required]
        [StringLength(maximumLength: 100)]
        public string UserName { get; set; }


        [Required]
        [DataType(DataType.EmailAddress)]
        public string UserEmail { get; set; }
    }
}