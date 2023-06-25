using dotNETPosgresAPI.Utilities;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace dotNETPosgresAPI.DTO.Account
{
    /// <summary>
    /// Acts as a DTO for Editing/Updating an existing User
    /// </summary>
    public class UserEditReq
    {
        [Display(Name = "User Id")]
        [Required(ErrorMessage = "User Id cannot be empty")]
        public int? Id { get; set; }

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

        public string? ProfImg { get; set; }

        [Required(ErrorMessage = "User Status Cannot be null")]
        public string? Status { get; set; }

        [Display(Name = "User Profile Image")]
        [MaxFileSize(2 * 1024)]
        [AllowedExtensions(new string[] { ".jpeg", ".jpg", ".png" })]
        public IFormFile? ProfImage { get; set; }
    }
}
