using System.ComponentModel.DataAnnotations;

namespace MixSample.Model
{
    public class SignModel
    {
        [Required, EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
