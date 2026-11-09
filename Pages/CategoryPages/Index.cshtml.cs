using Barlog_Raul_Lab2.Models;
using Barlog_Raul_Lab2.ViewModels;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Barlog_Raul_Lab2.Pages.CategoryPages
{
    public class IndexModel : PageModel
    {
        private readonly Barlog_Raul_Lab2Context _context;

        public IndexModel(Barlog_Raul_Lab2Context context)
        {
            _context = context;
        }

        public IList<Category> Category { get; set; } = default!;

        public CategoryIndexData CategoryData { get; set; } = default!;
        public int CategoryID { get; set; }
        public int BookID { get; set; }

        public async Task OnGetAsync(int? id, int? bookID)
        {
            CategoryData = new CategoryIndexData();
            CategoryData.Categories = await _context.Category
                .Include(i => i.BookCategories)
                    .ThenInclude(i => i.Book)
                        .ThenInclude(c => c!.Author)
                .OrderBy(i => i.CategoryName)
                .ToListAsync();

            if (id != null)
            {
                CategoryID = id.Value;
                Category category = CategoryData.Categories
                    .Where(i => i.ID == id.Value).Single();
                CategoryData.Books = category.BookCategories?.Where(bc => bc.Book != null).Select(bc => bc.Book!) ?? Enumerable.Empty<Book>();
            }
        }
    }
}
