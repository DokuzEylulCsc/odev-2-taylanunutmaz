using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversiteApp
{
    class Sube
    {
        public String SubeAdi { get; set; }
        public Ders Ders { get; set; }
        List<Ogrenci> ogrenciler = new List<Ogrenci>(40); //bir şubede en fazla 40 öğrenci olabilir
    }
}
