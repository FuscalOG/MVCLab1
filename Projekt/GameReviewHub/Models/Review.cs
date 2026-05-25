using System.ComponentModel.DataAnnotations;

namespace GameReviewHub.Models
{
    public class Review
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Author { get; set; }

        [Required]
        [StringLength(300)]
        public string Comment { get; set; }

        [Range(1, 10)]
        public int Score { get; set; }

        public int GameId { get; set; }

        public Game? Game { get; set; }
    }
}