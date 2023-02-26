using Microsoft.AspNetCore.Authentication;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace BlogWebSite.Models
{
    [Table("Blogs")]
    public class Forum
    {
        [Key]
        [Display(Name="ID")]
        public int BlogId { get; set; }

        [Required]

        [Display(Name = "NomBlog")]
        [Column(TypeName="varchar(20)")]
        public string Name { get; set; }=string.Empty;

        [Display(Name = "NomBlog")]
        [Column(TypeName = "varchar(100)")]
        public string Description { get; set; }
    }
}
