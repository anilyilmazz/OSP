using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YemekSepeti.Models
{
    public class Urunler
    {
        public int Id { get; set; }
        public int RestorantId { get; set; }
        public string YemekAdi { get; set; }
        public float Fiyat { get; set; }
    }
}
