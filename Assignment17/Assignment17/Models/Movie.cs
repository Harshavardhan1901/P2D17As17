using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Assignment17.Models
{
    [Table("Movie")]
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Title { get; set; }
        [Required]
        [StringLength(100)]
        public string Director { get; set; }
        [Required]
        public DateTime ReleaseDate { get; set; }
        [Required]
        [StringLength(100)]
        public string Genre { get; set; }
        public double Rating { get; set; }
    }
}
