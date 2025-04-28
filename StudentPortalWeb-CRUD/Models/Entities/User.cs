using System.ComponentModel.DataAnnotations;

namespace StudentPortalWeb_CRUD.Models.Entities
{
    public class User
    {
        public Guid Id { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; } // Plaintext for demo; use hashed in real apps!
    }
}
