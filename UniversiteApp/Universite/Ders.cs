using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversiteApp
{
    class Ders
    {
        public String DersAdi { get; set; }
        public int Yil { get; set; }
        public int Donem { get; set; }
        public List<Sube> subeler = new List<Sube>();
        public Bolum Bolum { get; set; }

        public Ders(string dersAdi, int yil, int donem, Bolum bolum)
        {
            DersAdi = dersAdi;
            Yil = yil;
            Donem = donem;
            Bolum = bolum;
            bolum.dersler.Add(this);
        }

        public void OgretimElemaniAta()
        {
            //TODO
        }

        public void OgretimElemaniSil()
        {
            //TODO
        }

        public void OgrenciEkle()
        {
            //TODO
        }

        public void OgrenciSil()
        {
            //TODO
        }

        public void DosyayaKaydet()
        {
            //TODO Ek olarak DosyadanOkuma methodunu da değerlendir
        }

        public void SubeleriYazdir()
        {
            Console.WriteLine($"{DersAdi} Dersi'nin Şubeleri:");
            subeler.ForEach(x => {
                Console.WriteLine(x.SubeAdi);
            });
            Console.WriteLine("---SON---\n");

        }
    }
}
