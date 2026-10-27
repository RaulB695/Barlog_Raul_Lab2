using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Barlog_Raul_Lab2.Models;
using Barlog_Raul_Lab2;

namespace Barlog_Raul_Lab2.Pages.BookCategoryPages;

public class IndexModel : PageModel
{
    private readonly Barlog_Raul_Lab2Context _context;

    public IndexModel(Barlog_Raul_Lab2Context context)
    {
        _context = context;
    }

    public IList<BookCategory> BookCategory { get; set; } = default!;

    public async Task OnGetAsync()
    {
        BookCategory = await _context.BookCategory.ToListAsync();
    }
}
