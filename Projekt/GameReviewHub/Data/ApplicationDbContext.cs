using Microsoft.EntityFrameworkCore;
using GameReviewHub.Models;

namespace GameReviewHub.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Game> Games { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<Review> Reviews { get; set; }
    }
}