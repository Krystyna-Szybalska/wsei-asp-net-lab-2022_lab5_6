using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace lab_5.Models
{
    public class BookDetails
    {
        public string ISBN { get; set; }

        [Display(Name = "Liczba stron")]
        public int NumberOfPages { get; set; }
        [Display(Name = "Ocena")]
        public int Rating { get; set; }
    }
}
