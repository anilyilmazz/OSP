using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFGetStarted.AspNetCore.NewDb.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SosyalMedya.Models;
using YemekSepeti.Models;

namespace SosyalMedya.Controllers
{
    public class UsersController : Controller
    {
        private ApplicationDbContext _ctx;

        public UsersController(ApplicationDbContext _ctx)
        {
            this._ctx = _ctx;
        }
        public IActionResult Index()
        {
            var email = HttpContext.Session.GetString("email");
            if (email == null)
            {
                return Redirect("/");
            }
            var user = _ctx.Users.Where(a => a.Email == email).ToList();
            ViewData["email"] = email;
            ViewData["adress"] = user[0].Adress;
            List<Restorant> restorantlar = _ctx.Restorants.ToList();
            ViewData["restoranlar"] = restorantlar;
            var siparisler = _ctx.Siparis.Where(a => a.KullaniciId == user[0].Id).ToList();
            ViewData["siparisler"] = siparisler;
            return View();
        }

        public IActionResult UyeOl()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Uyeol(string email,string adress,string password)
        {
            var emailkontrol = _ctx.Users.Where(a => a.Email == email).ToList();

            if (emailkontrol.Count == 0)
            {
                var user = new Users();
                user.Email = email;
                user.Adress = adress;
                user.Password = password;
                _ctx.Users.Add(user);
                _ctx.SaveChanges();
                HttpContext.Session.SetString("email", email);
                return Redirect("/");
            }
            else{
                return Redirect("/");
            }
        }
        [HttpPost]
        public IActionResult GirisYap(string email,string password)
        {
            HttpContext.Session.Remove("email");
            var user = _ctx.Users.Where(a => a.Email == email).ToList();
            if (user != null)
            {
                if (user[0].Password == password && user[0].Email == email)
                {
                    HttpContext.Session.SetString("email", user[0].Email);
                    return Redirect("/users/index");
                }
                return Redirect("/");
            }
            return Redirect("/");
        }
        public IActionResult CikisYap()
        {
            HttpContext.Session.Remove("email");
            return Redirect("/");
        }

        // MENU İŞLEMLERİ

        public IActionResult Menu(int Id)
        {
            var restorant_adi = _ctx.Restorants.Where(a => a.Id == Id).ToList();
            var urunler = _ctx.Urunlers.Where(a => a.RestorantId == Id).ToList();
            ViewData["urunler"] = urunler;
            ViewData["restorant"] = restorant_adi[0].Ad;
            return View();
        }
        public IActionResult SiparisOlustur(string urunadi, float urunfiyat, int urunid)
        {
            var email = HttpContext.Session.GetString("email");
            var user = _ctx.Users.Where(a => a.Email == email).ToList();
            var restorant_id = _ctx.Urunlers.Where(a => a.Id == urunid).ToList()[0].RestorantId;
            var restorant_ad = _ctx.Restorants.Where(a => a.Id == restorant_id).ToList()[0].Ad;
            var yeni_siparis = new Siparis();
            yeni_siparis.KullaniciId = user[0].Id;
            yeni_siparis.UrunAdi = urunadi;
            yeni_siparis.Fiyat = urunfiyat;
            yeni_siparis.RestorantId = restorant_id;
            yeni_siparis.Kullanici_adres = user[0].Adress;
            yeni_siparis.tarih = DateTime.Now;
            yeni_siparis.RestorantAd = restorant_ad;
            _ctx.Siparis.Add(yeni_siparis);
            _ctx.SaveChanges();

            return Redirect("/");
        }
    }
}