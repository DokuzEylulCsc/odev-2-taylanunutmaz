﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversiteApp
{
    class YuksekLisans:Ogrenci
    {
        public string ogrenimTuru = "YuksekLisans";

        public YuksekLisans(string ad, string soyad, Bolum bolum):base(ad, soyad, bolum)
        {

        }
    }
}
