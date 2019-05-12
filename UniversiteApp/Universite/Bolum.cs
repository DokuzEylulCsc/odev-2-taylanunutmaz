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
            ogrenci.Bolum = this;
            ogrenciler.Add(ogrenci);
            Console.WriteLine($"{ogrenci.Ad} {ogrenci.Soyad} isimli öğrenci " +
                $"{BolumAdi} isimli bölüme başarıyla kaydedildi!");
        }

        public void OgrenciSil(Ogrenci ogrenci)
        {
            ogrenci.Bolum = null;
            ogrenciler.Remove(ogrenci);
            Console.WriteLine($"{ogrenci.Ad} {ogrenci.Soyad} isimli öğrenci " +
                $"{BolumAdi} isimli bölümden başarıyla silindi.");
        }

        public void OgretimElemaniAta()
        {
            //TODO OgretimElemani sınıfıyla ilişkilendir
        }

        public void OgretimElemaniSil()
        {
            //TODO OgretimElemani sınfıyla ilişkilendir
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
