using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotNETPosgresAPI.Entities
{
    /// <summary>
    /// an Entity Class object representing User Table Structure
    /// </summary>
    [Table("tbl_users")]
    public class Users
    {
        [Key]
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Sex { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string ProfImg { get; set; }
        public int RegBy { get; set;}
        public string Status { get; set; } = "active";
        public DateTime RegDate { get; set; } = DateTime.Now;
    }
}
