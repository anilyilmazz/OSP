using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SosyalMedya.Models;

namespace SosyalMedya.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var email = HttpContext.Session.GetString("email");
            var restorantEmail = HttpContext.Session.GetString("restorant-email");
            if (restorantEmail != null)
            {
                return Redirect("/restorant/index");
            }
            if (email != null)
            {
                ViewData["email"] = email;
                return Redirect("/users/index");
            }
            if (email == null || restorantEmail ==null)
            {
                return View();
            }

            return View();
        }
    }
}
