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

        public Sube(string subeAdi, Ders ders)
        {
            SubeAdi = subeAdi;
            Ders = ders;
            ders.subeler.Add(this);
        }

        public void OgrencileriYazdir()
        {
            Console.WriteLine($"{SubeAdi} Şubesi'nin Öğrencileri:");
            ogrenciler.ForEach(x => {
                Console.WriteLine($"{x.Numara} - {x.Ad} {x.Soyad}");
            });
            Console.WriteLine("---SON---\n");
        }
    }
}
