using Barlog_Raul_Lab2.Models;

namespace Barlog_Raul_Lab2.ViewModels
{
    public class PublisherIndexData
    {
        public IEnumerable<Publisher> Publishers { get; set; } = default!;
        public IEnumerable<Book>? Books { get; set; }
    }
}
