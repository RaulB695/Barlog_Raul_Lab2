using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Barlog_Raul_Lab2.Models;
using Barlog_Raul_Lab2;

namespace Barlog_Raul_Lab2.Pages.BookCategoryPages;

public class CreateModel : PageModel
{
    private readonly Barlog_Raul_Lab2Context _context;

    public CreateModel(Barlog_Raul_Lab2Context context)
    {
        _context = context;
    }

    public IActionResult OnGet()
    {
        return Page();
    }

    [BindProperty]
    public BookCategory BookCategory { get; set; } = default!;

    // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD.
    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        _context.BookCategory.Add(BookCategory);
        await _context.SaveChangesAsync();

        return RedirectToPage("./Index");
    }
}
