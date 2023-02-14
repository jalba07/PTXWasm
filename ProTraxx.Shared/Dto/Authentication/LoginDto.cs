using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProTraxx.Shared.Dto.Authentication
{
    public class LoginModel
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        [RegularExpression(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9]).{8,}$",
            ErrorMessage = "Password should have minimum 8 characters, at least 1 uppercase letter, 1 lowercase letter and 1 number.")]
        public string Password { get; set; }



        //[Required]
        //[Display(Name = "Confirm Password")]
        //[Compare("Password", ErrorMessage = "The password and confirm password fields do not match.")]
        //public string ConfirmPassword { get; set; }
    }
}
