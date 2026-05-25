using System.ComponentModel.DataAnnotations;

namespace GameReviewHub.Models
{
    public class Game
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        [StringLength(100)]
        public string Studio { get; set; }

        [Range(1970, 2035)]
        public int ReleaseYear { get; set; }

        [Range(1, 10)]
        public double Rating { get; set; }

        [StringLength(500)]
        public string? Description { get; set; }

        public int GenreId { get; set; }

        public Genre? Genre { get; set; }

        public List<Review>? Reviews { get; set; }
    }
}