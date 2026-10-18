using Microsoft.EntityFrameworkCore;

namespace Barlog_Raul_Lab2
{
    public class Barlog_Raul_Lab2Context : DbContext
    {
        public Barlog_Raul_Lab2Context(DbContextOptions<Barlog_Raul_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Barlog_Raul_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Barlog_Raul_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Barlog_Raul_Lab2.Models.Author> Author { get; set; } = default!;
    }
}