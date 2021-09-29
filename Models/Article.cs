using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Database.models
{
    // [Table("posts")]
    public class Article {
        [Key]
        public int id {get; set;}
        
        [StringLength(255)]
        [Required]
        [Column(TypeName = "nvarchar")]
        public string Title {get; set;}

        [DataType(DataType.Date)]
        [Required]
        public DateTime Created {get; set;}

        [Column(TypeName = "nText")]
        public string Content {get; set;}
    }
}