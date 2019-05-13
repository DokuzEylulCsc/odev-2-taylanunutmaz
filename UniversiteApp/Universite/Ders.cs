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
        public List<OgretimElemani> ogretimElemanlari = new List<OgretimElemani>(3);// her ders için maksimum 3 öğretim elemanı

        public Ders(string dersAdi, int yil, int donem, Bolum bolum)
        {
            DersAdi = dersAdi;
            Yil = yil;
            Donem = donem;
            Bolum = bolum;
            bolum.dersler.Add(this);
        }

        public void OgretimElemaniAta(OgretimElemani ogretimElemani)
        {
            if (ogretimElemanlari.Count <= ogretimElemanlari.Capacity)
            {
                ogretimElemanlari.Add(ogretimElemani);
                Console.WriteLine($"{ogretimElemani.Ad} {ogretimElemani.Soyad} isimli" +
                    $"öğretim elemanı {DersAdi} isimli derse eklendi.");
            }
            else
            {
                Console.WriteLine($"İşlem başarısız! Dersi verebilecek maksimum öğretim elamanı" +
                    $"sayısı aşıldı.(Kapasite: {ogretimElemanlari.Capacity})");
            }
        }

        public void OgretimElemaniSil(OgretimElemani ogretimElemani)
        {
            if(ogretimElemanlari.Contains(ogretimElemani))
            {
                ogretimElemanlari.Remove(ogretimElemani);
                Console.WriteLine($"{ogretimElemani.Ad} {ogretimElemani.Soyad} isimli " +
                    $"öğretim elemanı {DersAdi} isimli dersten başarıyla silindi.");
            }
            else
            {
                Console.WriteLine($"İşlem başarısız! {ogretimElemani.Ad} {ogretimElemani.Soyad} " +
                    $"isimli öğretim elemanı {DersAdi} isimli derse kayıtlı değil!");
            }
        }

        public void OgrenciEkle(Ogrenci ogrenci)
        {
            if (subeler.Count > 0)
            {
                if (ogrenci.Bolum == this.Bolum)
                {
                    Sube secilenSube = subeler[0];
                    this.subeler.ForEach(x => {
                        if (secilenSube.ogrenciler.Count > x.ogrenciler.Count)
                        {
                            secilenSube = x;
                        }
                    });
                    if (secilenSube.ogrenciler.Count <= secilenSube.ogrenciler.Capacity)
                    {
                        secilenSube.ogrenciler.Add(ogrenci);
                        ogrenci.dersler.Add(this);

                        Console.WriteLine($"{ogrenci.Ad} {ogrenci.Soyad} isimli öğrenci {DersAdi} isimli" +
                            $"dersin {secilenSube.SubeAdi} şubesine kaydoldu.");
                    }
                    else
                    {
                        Console.WriteLine($"{secilenSube.SubeAdi} dolayısıyla {DersAdi} şubeleri maksimum " +
                            $"öğrenci kapasitesine ulaştı. Ek şube açarak tekrar deneyin.");
                    }
                        
                }
                else
                {
                    Console.WriteLine($"Bu öğrenci faklı bölümden ders alamaz!. " +
                        $"{ogrenci.Ad} {ogrenci.Soyad} isimli öğrencinin bölümü {ogrenci.Bolum.BolumAdi}" +
                        $"fakat kayıt edilmek istenen ders {this.Bolum.BolumAdi} bölümünde.");
                }
            }
            else
            {
                Console.WriteLine($"{DersAdi} isimli dersin herhangi bir şubesi oluşturulmamış. " +
                    "şube oluşturup tekrar deneyin!");
            }
            
            
        }

        public void OgrenciSil(Ogrenci ogrenci)
        {
            Sube silinecekSube = null;
            this.subeler.ForEach(x => {
                if (x.ogrenciler.Contains(ogrenci))
                {
                    silinecekSube = x;
                }
            });
            if (silinecekSube != null)
            {
                silinecekSube.ogrenciler.Remove(ogrenci);
                Console.WriteLine($"{ogrenci.Ad} {ogrenci.Soyad} isimli öğrenci " +
                    $"{silinecekSube.Ders.DersAdi} dersinin {silinecekSube.SubeAdi} " +
                    $"şubesinden silindi silindi!");
            }
            else
            {
                Console.WriteLine($"{ogrenci.Ad} {ogrenci.Soyad} isimli öğrenci" +
                    $"{this.DersAdi} isimli dersin herhangi bir şubesine kayıtlı değil!");
            }
        }

        public void DosyayaKaydet()
        {
            //TODO Ek olarak DosyadanOkuma methodunu da değerlendir
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter("ders.txt"))
            {
                file.WriteLine(DersAdi);
                file.WriteLine(Yil.ToString());
                file.WriteLine(Donem.ToString());
                file.WriteLine("subeler");
                subeler.ForEach(x => {
                    file.WriteLine(x.SubeAdi);
                    file.WriteLine("subeler->ogrenciler");
                    x.ogrenciler.ForEach(y => {
                        file.WriteLine($"{y.Numara} {y.Ad} {y.Soyad}");
                    });
                    file.WriteLine("endof->subeler->ogrenciler");
                });
                file.WriteLine("endof->subeler");
                file.WriteLine(Bolum.BolumAdi);
                file.WriteLine("ogretimelemanlari");
                ogretimElemanlari.ForEach(x => {
                    file.WriteLine($"{x.Numara} {x.Ad} {x.Soyad}");
                });
                file.WriteLine("endof->ogretimelemanlari");
            }
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
