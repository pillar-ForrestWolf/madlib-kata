using Microsoft.EntityFrameworkCore;

namespace MadlibApi.Models
{
    public class PuzzleContext: DbContext
    {
        public PuzzleContext(DbContextOptions<PuzzleContext> options)
            : base(options)
        {
        }

        public DbSet<Puzzle> Puzzles { get; set; }
    }
}