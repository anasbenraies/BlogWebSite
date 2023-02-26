using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using System.Diagnostics.CodeAnalysis;

namespace BlogWebSite.Models
{
    [Table("Posts")]
    public class Post
    {
        [Key]
        [Display(Name = "ID")]
        public int? PostId { get; set; }

        [Required]

        [Display(Name = "Content")]
        [Column(TypeName = "varchar(20)")]
        public string Content { get; set; } = string.Empty;

        [Display(Name = "DateOfCreation")]
        [Column(TypeName = "DateTime2")]
        public DateTime Date { get; set; }
        public Boolean IsComment { get; set; }

        public Forum forum { get; set; }
        public User user { get; set; }
        [ForeignKey("Post")]
        public Post? Postref { get; set; }
        
    }

}
