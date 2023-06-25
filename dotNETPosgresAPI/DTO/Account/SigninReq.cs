using System.ComponentModel.DataAnnotations;

namespace dotNETPosgresAPI.DTO.Account
{
    public class SigninReq
    {
        [Display(Name = "User Id(Email, UserName, Phone)")]
        [Required(ErrorMessage = "Please Enter One of UserName, Email or Phone Number")]
        public string? UserId { get; set; }

        [Required(ErrorMessage = "Please Enter your Password")]
        public string? Password { get; set; }
    }
}
