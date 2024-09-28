using System.ComponentModel.DataAnnotations;

namespace Hammam_library.Models
{
    public class Users
    {
        [Key]
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

    }
}
