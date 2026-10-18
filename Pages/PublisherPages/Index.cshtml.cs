using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Barlog_Raul_Lab2.Models;

namespace Barlog_Raul_Lab2.Pages.PublisherPages;

public class IndexModel : PageModel
{
    private readonly Barlog_Raul_Lab2Context _context;

    public IndexModel(Barlog_Raul_Lab2Context context)
    {
        _context = context;
    }

    public IList<Publisher> Publisher { get; set; } = default!;

    public async Task OnGetAsync()
    {
        Publisher = await _context.Publisher.ToListAsync();
    }
}
