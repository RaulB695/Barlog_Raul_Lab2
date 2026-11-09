using Microsoft.EntityFrameworkCore;
using Barlog_Raul_Lab2.Models;

namespace Barlog_Raul_Lab2
{
    public class Barlog_Raul_Lab2Context : DbContext
    {
        public DbSet<Barlog_Raul_Lab2.Models.Borrowing> Borrowing { get; set; } = default!;
        public DbSet<Barlog_Raul_Lab2.Models.Member> Member { get; set; } = default!;
        public Barlog_Raul_Lab2Context(DbContextOptions<Barlog_Raul_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Book> Book { get; set; } = default!;
        public DbSet<Publisher> Publisher { get; set; } = default!;
        public DbSet<Author> Author { get; set; } = default!;
        public DbSet<Category> Category { get; set; } = default!;
        public DbSet<BookCategory> BookCategory { get; set; } = default!;
    }
}
