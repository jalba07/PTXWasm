using System.ComponentModel.DataAnnotations;

namespace ProTraxx.Shared.Dto.Account
{
    public class Login
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}