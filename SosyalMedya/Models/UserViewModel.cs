using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SosyalMedya.Models
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Adress { get; set; }
    }
}
