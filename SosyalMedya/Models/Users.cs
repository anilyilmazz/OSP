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
        public string UserTitle { get; set; }
        public string UserContent { get; set; }
    }

}
