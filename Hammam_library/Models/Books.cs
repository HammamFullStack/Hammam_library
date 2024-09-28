using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hammam_library.Models
{
    public class Books
    {
        [Key]
        public int BookID { get; set; }
        public string Title { get; set; }
        public string Edition { get; set; }

        [ForeignKey("Authors")]
        public int AuthorID { get; set; }
        public Authors Authors { get; set; }
    }
}
