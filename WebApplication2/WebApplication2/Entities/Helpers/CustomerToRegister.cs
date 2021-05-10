using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Entities.Helpers
{
    public class CustomerToRegister
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}