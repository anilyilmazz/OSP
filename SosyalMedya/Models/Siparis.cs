using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YemekSepeti.Models
{
    public class Siparis
    {
        public int Id { get; set; }
        public int RestorantId { get; set; }
        public string UrunAdi { get; set; }
        public float Fiyat { get; set; }
        public int KullaniciId { get; set; }
        public string Kullanici_adres { get; set; }
        public DateTime tarih { get; set; }
        public string RestorantAd { get; set; }
    }
}
