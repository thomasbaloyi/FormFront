using System;

namespace FormFront.Models
{
    public class Form
    {
        public Form()
        {

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Country { get; set; }
        public string FavouriteColour { get; set; }
        public  DateTime Birthday { get; set; }
        public int PhoneNumber { get; set; }
        public string Comments { get; set; }
    }
}
