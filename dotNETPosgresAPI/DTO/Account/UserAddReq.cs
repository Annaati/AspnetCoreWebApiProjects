using dotNETPosgresAPI.Utilities;
using System.ComponentModel.DataAnnotations;

namespace dotNETPosgresAPI.DTO.Account
{
    /// <summary>
    /// Acts as a DTO for inserting a new User
    /// </summary>
    public class UserAddReq
    {
        [Required(ErrorMessage = "User Full Name Cannot be empty")]
        [Display(Name = "User Full Name")]
        public string? FullName { get; set; }

        [Display(Name = "User Sex")]
        public string? Sex { get; set; }

        [Required(ErrorMessage = "User Phone Cannot be empty")]
        [RegularExpression(@"^(\d{10})$", ErrorMessage = "Enter a valid Phine Number")]
        [Display(Name = "User Phone")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "User Emial Cannot be empty")]
        [EmailAddress(ErrorMessage = "Please provide a vlaid Email Address")]
        [Display(Name = "User EMail")]
        public string? Email { get; set; }

        [Display(Name = "User Profile Image")]
        [MaxFileSize(2 * 1024)]
        [AllowedExtensions(new string[] { ".jpeg", ".jpg", ".png" })]
        public IFormFile? ProfImg { get; set; }

        [Display(Name = "Registered By")]
        public int? RegBy { get; set; }
    }
}
