using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversiteApp
{
    class Doktora:Ogrenci
    {
        public string ogrenimTuru = "Doktora";

        public Doktora(string ad, string soyad, Bolum bolum) :base(ad, soyad, bolum)
        {

        }
    }
}
