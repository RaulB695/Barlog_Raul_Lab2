using System.ComponentModel.DataAnnotations.Schema;

namespace Barlog_Raul_Lab2.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; } = string.Empty;

        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }

        public DateTime PublishingDate { get; set; }

        public int? PublisherID { get; set; }
        public Publisher? Publisher { get; set; }

        public int? AuthorID { get; set; }
        public Author? Author { get; set; }
    }
}