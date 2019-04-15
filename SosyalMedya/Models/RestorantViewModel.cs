using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YemekSepeti.Models
{
    public class RestorantViewModel
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Adress { get; set; }
        public string Tur { get; set; }
    }
}
