using System.ComponentModel.DataAnnotations;

namespace UserDirectory.Models
{
    public class User
    {
        public int UserId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Company { get; set; }
    }
}