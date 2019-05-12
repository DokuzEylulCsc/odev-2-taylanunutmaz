using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversiteApp
{
    class Bolum
    {
        public String BolumAdi { get; set; }
        public Fakulte Fakulte;
        public List<Ogrenci> ogrenciler = new List<Ogrenci>();
        public List<Ders> dersler = new List<Ders>();
        public List<OgretimElemani> ogretimElemanlari = new List<OgretimElemani>();

        public Bolum(string bolumAdi, Fakulte fakulte)
        {
            BolumAdi = bolumAdi;
            Fakulte = fakulte;
            fakulte.bolumler.Add(this);
        }

        public void OgrenciKayit(Ogrenci ogrenci)
        {
            //Bu method öğrencinin bölüm değiştirmesi yada bölümü silinen öğrencilerin 
            //yeniden bir bölüme atanması için kullanılacaktır.
            if (!ogrenciler.Contains(ogrenci) && ogrenci.Bolum == null)
            {
                ogrenci.Bolum = this;
                ogrenciler.Add(ogrenci);
                Console.WriteLine($"{ogrenci.Ad} {ogrenci.Soyad} isimli öğrenci " +
                    $"{BolumAdi} isimli bölüme başarıyla kaydedildi!");
            }
            else
            {
                Console.WriteLine($"{ogrenci.Ad} {ogrenci.Soyad} isimli öğrenci " +
                    $"zaten {ogrenci.Bolum.BolumAdi} isimli bölüme kayıtlı olduğundan " +
                    $"{BolumAdi} isimli bölüme kaydedilemedi!");
            }
        }

        public void OgrenciSil(Ogrenci ogrenci)
        {
            if (ogrenciler.Contains(ogrenci))
            {
                ogrenci.Bolum = null;
                ogrenciler.Remove(ogrenci);
                Console.WriteLine($"{ogrenci.Ad} {ogrenci.Soyad} isimli öğrenci " +
                    $"{BolumAdi} isimli bölümden başarıyla silindi.");
            }
            else
            {
                Console.WriteLine($"{ogrenci.Ad} {ogrenci.Soyad} isimli öğrenci " +
                    $"zaten {BolumAdi} isimli bölüme kayatılı değil!");
            }
        }

        public void OgretimElemaniAta(OgretimElemani ogretimElemani)
        {
            //Bölümü değiştirilen veya daha önceden bölümü silinen öğretim elemanına 
            //bölüm atamanak için kullanılacak method
            if (!ogretimElemanlari.Contains(ogretimElemani) && ogretimElemani.Bolum == null)
            {
                ogretimElemani.Bolum = this;
                ogretimElemanlari.Add(ogretimElemani);
                Console.WriteLine($"{ogretimElemani.Ad} {ogretimElemani.Soyad} isimli öğretim elemanı " +
                    $"{BolumAdi} isimli bölüme atandı.");

            }
            else
            {
                Console.WriteLine($"{ogretimElemani.Ad} {ogretimElemani.Soyad} isimli öğretim elemanı " +
                    $"zaten {ogretimElemani.Bolum.BolumAdi} isimli bölüme kayıtlı olduğundan " +
                    $"{BolumAdi} isimli bölüme kaydedilemedi!");
            }
        }

        public void OgretimElemaniSil(OgretimElemani ogretimElemani)
        {
            if (ogretimElemanlari.Contains(ogretimElemani))
            {
                ogretimElemani.Bolum = null;
                ogretimElemanlari.Remove(ogretimElemani);
                Console.WriteLine($"{ogretimElemani.Ad} {ogretimElemani.Soyad} isimli öğretim elemanı " +
                    $"{BolumAdi} isilmi bölümden başarıyla kaldırıldı.");
            }
            else
            {
                Console.WriteLine($"{ogretimElemani.Ad} {ogretimElemani.Soyad} isimli öğretim elemanı " +
                    $"zaten {BolumAdi} isimli bölüme kayıtlı değil!");
            }
        }

        public void DersAc()
        {
            //TODO Ders sınıfı ile ilişkilendir
        }

        public void DersKapa()
        {
            //TODO Ders sınıfı ile ilişkilendir veya sadece List üzeründen müdahale et
        }

        public void DersleriYazdir()
        {
            Console.WriteLine($"{BolumAdi} Bölümü'nün Dersleri:");
            dersler.ForEach(x => {
                Console.WriteLine(x.DersAdi);
            });
            Console.WriteLine("---SON---\n");
        }

        public void OgrencileriYadir()
        {
            Console.WriteLine($"{BolumAdi} bölümünün öğrencileri:");
            ogrenciler.ForEach(x => {
                Console.WriteLine(x.Numara + " " + x.Ad + " " + x.Soyad);
            });
            Console.WriteLine("---SON---\n");
        }
    }
}
