using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFGetStarted.AspNetCore.NewDb.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YemekSepeti.Models;

namespace SosyalMedya.Controllers
{
    public class RestorantController : Controller
    {
        private ApplicationDbContext _ctx;

        public RestorantController(ApplicationDbContext _ctx)
        {
            this._ctx = _ctx;
        }
        public IActionResult Index()
        {
            var email = HttpContext.Session.GetString("restorant-email");
            var restorant = _ctx.Restorants.Where(a => a.Email == email).ToList();

            List<Siparis> siparisler = _ctx.Siparis.Where(a => a.RestorantId == restorant[0].Id).ToList();
            ViewData["siparisler"] = siparisler;

            return View();
        }
        public IActionResult UyeOL()
        {
            return View();
        }
        [HttpPost]
        public IActionResult UyeOL(string ad, string email,string password,string adress,string tur)
        {
            var restorant = new Restorant();
            restorant.Ad = ad;
            restorant.Email = email;
            restorant.Password = password;
            restorant.Adress = adress;
            restorant.Tur = tur;
            _ctx.Restorants.Add(restorant);
            _ctx.SaveChanges();
            HttpContext.Session.SetString("restorant-email", email);
            return Redirect("/");
        }
        [HttpPost]
        public IActionResult GirisYap(string email, string password)
        {
            HttpContext.Session.Remove("restorant-email");
            var restorant = _ctx.Restorants.Where(a => a.Email == email).Select(s => new RestorantViewModel() { Email = s.Email, Password = s.Password }).ToList();
            if (restorant != null )
            {
                if (restorant[0].Password == password && restorant[0].Email == email)
                {
                    HttpContext.Session.SetString("restorant-email", restorant[0].Email);
                    return Redirect("/restorant/index");
                }
                return Redirect("/");
            }
            return Redirect("/");
        }
        public IActionResult Giris()
        {
            return View();
        }
        public IActionResult CikisYap()
        {
            HttpContext.Session.Remove("restorant-email");
            return Redirect("/");
        }

        //MENU İŞLEMLERİ
        public IActionResult Menu()
        {
            var email = HttpContext.Session.GetString("restorant-email");
            if (email == null)
            {
                return Redirect("/");
            }

            var restorant = _ctx.Restorants.Where(a => a.Email == email).Select(s => new RestorantViewModel() { Id = s.Id }).ToList();

            List<Urunler> urunler = _ctx.Urunlers.Where(a => a.RestorantId == restorant[0].Id).ToList();
            ViewData["urunler"] = urunler;
            return View();
        }
        public IActionResult UrunEkle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UrunEkle(float fiyat, string yemekadi)
        {
            var email = HttpContext.Session.GetString("restorant-email");
            if (email == null)
            {
                return Redirect("/");
            }

            var restorant = _ctx.Restorants.Where(a => a.Email == email).Select(s => new RestorantViewModel() { Id=s.Id }).ToList();
            var urun = new Urunler();
            urun.Fiyat = fiyat;
            urun.RestorantId = restorant[0].Id;
            urun.YemekAdi = yemekadi;
            _ctx.Urunlers.Add(urun);
            _ctx.SaveChanges();
            return Redirect("/restorant/menu");
        }
        public IActionResult UrunSil(int id)
        {
            var silinen_Urun = new Urunler { Id = id };
            _ctx.Urunlers.Attach(silinen_Urun);
            _ctx.Urunlers.Remove(silinen_Urun);
            _ctx.SaveChanges();
            return Redirect("/restorant/menu");
        }

  

       
    }
}