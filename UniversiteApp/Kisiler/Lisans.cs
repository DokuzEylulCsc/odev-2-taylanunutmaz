﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversiteApp
{
    class Lisans:Ogrenci
    {
        public string ogrenimTuru = "Lisans";

        public Lisans(string ad, string soyad, Bolum bolum):base(ad, soyad, bolum)
        {

        }
    }
}
