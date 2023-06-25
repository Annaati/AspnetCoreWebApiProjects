using System.ComponentModel.DataAnnotations;

namespace dotNETPosgresAPI.DTO.Account
{
    /// <summary>
    /// a DTO object that acts Users returned Response
    /// </summary>
    public class UserRes
    {
        [Display(Name = "User Id")]
        public int? Id { get; set; }

        [Display(Name = "Full Name")]
        public string? FullName { get; set; }

        public string? Sex { get; set; }

        public string? Phone { get; set; }

        public string? Email { get; set; }

        [Display(Name = "User Profile Image")]
        public string? ProfImg { get; set; }

        [Display(Name = "Registered By")]
        public string? RegBy { get; set; }

        public string? Status { get; set; } = "active";

        [Display(Name = "Reg. Date")]
        public DateTime ?RegDate { get; set; }
    }
}
