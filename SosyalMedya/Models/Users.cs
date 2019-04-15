using EFGetStarted.AspNetCore.NewDb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SosyalMedya.Models
{
    
    public class Users
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Adress { get; set; }
    }

}
