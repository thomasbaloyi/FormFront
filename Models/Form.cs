using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        public string Country { get; set; }
        public string FavouriteColour { get; set; }
        public  DateTime Birthday { get; set; }
        public int PhoneNumber { get; set; }
        public string Comments { get; set; }
    }
}
