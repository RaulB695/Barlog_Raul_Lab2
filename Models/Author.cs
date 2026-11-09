using System.ComponentModel.DataAnnotations;

namespace Barlog_Raul_Lab2.Models
{
    public class Author
    {
        public int ID { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;

        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        public override string ToString() => FullName;

        public ICollection<Book>? Books { get; set; }
    }
}
