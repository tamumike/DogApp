using System.ComponentModel.DataAnnotations;

namespace Review.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "Must provide a password at least 4 characters long")]
        public string Password { get; set; }
    }
}