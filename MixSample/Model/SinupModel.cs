using System.ComponentModel.DataAnnotations;
namespace MixSample.Model
{
    public class SinupModel
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [Compare("ConfrimPassword")]
        public string Password { get; set; }

        [Required]
        public string ConfrimPassword { get; set; }

    }
}
