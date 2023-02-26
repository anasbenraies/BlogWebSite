using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace BlogWebSite.Models
{
    [Table("Users")]
    public class User
    {
        [Key]
        [Display(Name = "ID")]
        public int UserId { get; set; }

        [Required]

        [Display(Name = "Username")]
        [Column(TypeName = "varchar(20)")]
        public string Name { get; set; } = string.Empty;

        [Display(Name = "Password")]
        [Column(TypeName = "varchar(30)")]
        public string Password { get; set; } = string.Empty;

        [Display(Name = "e-mail")]
        [Column(TypeName = "varchar(50)")]
        public string email { get; set; }

        [Display(Name = "DateOfBirth")]
        [Column(TypeName = "DateTime2")]
        public DateTime Date { get; set; }

        [Display(Name="Image User")]
        [Column(TypeName="varchar(250)")]
        public string ImageUser { get; set; }

    }
}
