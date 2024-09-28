using System.ComponentModel.DataAnnotations;

namespace Hammam_library.Models
{
    public class Authors
    {
        [Key]
        public int AuthorID { get; set; }
        public string AuthorName { get; set; }
    }
}
