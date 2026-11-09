using Barlog_Raul_Lab2.Models;

namespace Barlog_Raul_Lab2.ViewModels
{
    public class CategoryIndexData
    {
        public IEnumerable<Category> Categories { get; set; } = default!;
        public IEnumerable<Book>? Books { get; set; }
    }
}
