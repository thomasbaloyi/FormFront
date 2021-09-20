using System;
using System.ComponentModel.DataAnnotations;

namespace FormFront.Models
{
    public class Form
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string ConfirmPassword { get; set; }
        public string Country { get; set; }
        public string FavouriteColour { get; set; }

        [DataType(DataType.Date)]
        public  DateTime Birthday { get; set; }

     //   [Phone]
        public int PhoneNumber { get; set; }

        public string Comments { get; set; }
    }
}
