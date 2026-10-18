using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Barlog_Raul_Lab2.Models;

namespace Barlog_Raul_Lab2.Pages.BookPages
{
    public class IndexModel : PageModel
    {
        private readonly Barlog_Raul_Lab2Context _context;

        public IndexModel(Barlog_Raul_Lab2Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get; set; } = default!;

        public async Task OnGetAsync()
        {
            Book = await _context.Book
                .Include(b => b.Publisher)
                .Include(b => b.Author)
                .ToListAsync();
        }
    }
}