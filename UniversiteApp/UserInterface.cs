using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversiteApp
{
    class UserInterface
    {
        public void Main()
        {
            List<Universite> uni = new List<Universite>();
            List<Fakulte> fak = new List<Fakulte>();
            List<Bolum> bol = new List<Bolum>();
            List<Ders> der = new List<Ders>();
            List<Sube> sub = new List<Sube>();
            List<Ogrenci> ogr = new List<Ogrenci>();
            List<OgretimElemani> ogrel = new List<OgretimElemani>();

            int tm = 0;
            int x = 1;
            while (x != 0)
            {
                Menu(tm++);
                Console.Write("Seçim: ");
                x = Convert.ToInt32(Console.ReadLine());
                switch (x)
                {
                    case 0: break;
                    case 1:
                        UniIslemleri();
                        break;
                    case 2:
                        FakIslemleri();
                        break;
                    case 3:
                        BolIslemleri();
                        break;
                    case 4:
                        DerIslemleri();
                        break;
                    case 5:
                        SubIslemleri();
                        break;
                    case 6:
                        OgrIslemleri();
                        break;
                    case 7:
                        OgrElIslemleri();
                        break;
                    //TODO dosyaya kaydet ve oku ekle
                    default:
                        Console.WriteLine("Hatalı Giriş!");
                        break;
                }
            }

            void OgrElIslemleri()
            {
                Console.Clear();
                Console.WriteLine("Öğretim Elemanı İşlemleri");
                Console.WriteLine("1-)Öğretim Elemanı Ekle");
                Console.WriteLine("2-)Öğretim Elemanlarını Listele");
                Console.Write("Seçim: ");
                x = Convert.ToInt32(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        {
                            Console.WriteLine("Yeni Öğretim Elemanı Kaydı Oluşturuluyor.");
                            Console.WriteLine("Öğretim Elemanı Ünvanı:");
                            string unvan = Console.ReadLine().ToString();
                            Console.WriteLine("Öğretim Elemanı Adı:");
                            string ad = Console.ReadLine().ToString();
                            Console.WriteLine("Öğrenci Soyadı:");
                            string soyad = Console.ReadLine().ToString();
                            Console.WriteLine("Kayıt olunabilecek bölümler");
                            int iter = 0;
                            bol.ForEach(y => {
                                Console.WriteLine((iter++) + "-)" + y.BolumAdi);
                            });
                            Console.Write("Seçim: ");
                            int z = Convert.ToInt32(Console.ReadLine());
                            Bolum bolAdi = bol[z];

                            ogrel.Add(new OgretimElemani(ad,soyad,bolAdi,unvan));
                        }
                        break;
                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("Kayıtlı Öğretim Elemanı Sayısı: " + ogr.Count);
                            ogrel.ForEach(y => {
                                Console.WriteLine($"{y.Numara} - {y.Ad} {y.Soyad}");
                            });
                        } break;
                }
            }

            void OgrIslemleri()
            {
                Console.Clear();
                Console.WriteLine("Öğrenci İşlemleri");
                Console.WriteLine("1-)Öğrencileri Listele");
                Console.WriteLine("2-)Lisans Öğrencisi Ekle");
                Console.WriteLine("3-)Yüksek Lisans Öğrencisi Ekle");
                Console.WriteLine("4-)Doktora Öğrencisi Ekle");
                Console.Write("Seçim: ");
                x = Convert.ToInt32(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        {
                            Console.Clear();
                            Console.WriteLine("Kayıtlı Öğrenci Sayısı: " + ogr.Count);
                            ogr.ForEach(y => {
                                Console.WriteLine($"{y.Numara} - {y.Ad} {y.Soyad}");
                            });
                        }
                        break;
                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("Yeni Öğrenci Kaydı Oluşturuluyor.");
                            Console.WriteLine("Öğrenci Adı:");
                            string ad = Console.ReadLine().ToString();
                            Console.WriteLine("Öğrenci Soyadı:");
                            string soyad = Console.ReadLine().ToString();
                            Console.WriteLine("Kayıt olunabilecek bölümler");
                            int iter = 0;
                            bol.ForEach(y => {
                                Console.WriteLine((iter++) + "-)" + y.BolumAdi);
                            });
                            Console.Write("Seçim: ");
                            int z = Convert.ToInt32(Console.ReadLine());
                            Bolum bolAdi = bol[z];
                            ogr.Add(new Lisans(ad, soyad, bolAdi));
                        } break;
                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine("Yeni Öğrenci Kaydı Oluşturuluyor.");
                            Console.WriteLine("Öğrenci Adı:");
                            string ad = Console.ReadLine().ToString();
                            Console.WriteLine("Öğrenci Soyadı:");
                            string soyad = Console.ReadLine().ToString();
                            Console.WriteLine("Kayıt olunabilecek bölümler");
                            int iter = 0;
                            bol.ForEach(y => {
                                Console.WriteLine((iter++) + "-)" + y.BolumAdi);
                            });
                            Console.Write("Seçim: ");
                            int z = Convert.ToInt32(Console.ReadLine());
                            Bolum bolAdi = bol[z];
                            ogr.Add(new YuksekLisans(ad, soyad, bolAdi));
                        } break;
                    case 4:
                        {
                            Console.Clear();
                            Console.WriteLine("Yeni Öğrenci Kaydı Oluşturuluyor.");
                            Console.WriteLine("Öğrenci Adı:");
                            string ad = Console.ReadLine().ToString();
                            Console.WriteLine("Öğrenci Soyadı:");
                            string soyad = Console.ReadLine().ToString();
                            Console.WriteLine("Kayıt olunabilecek bölümler");
                            int iter = 0;
                            bol.ForEach(y => {
                                Console.WriteLine((iter++) + "-)" + y.BolumAdi);
                            });
                            Console.Write("Seçim: ");
                            int z = Convert.ToInt32(Console.ReadLine());
                            Bolum bolAdi = bol[z];
                            ogr.Add(new Doktora(ad, soyad, bolAdi));
                        } break;
                }
            }

            void SubIslemleri()
            {
                if (der.Count > 0)
                {
                    Console.Clear();
                    Console.WriteLine("Şube İşlemleri");
                    Console.WriteLine("1-)Şube Ekle");
                    Console.WriteLine("2-)Şubeleri Listele");
                    Console.WriteLine("3-)Şubeye kayıtlı öğrencileri listele");
                    Console.Write("Seçim: ");
                    x = Convert.ToInt32(Console.ReadLine());
                    switch (x)
                    {
                        case 1:
                            {
                                Console.Clear();
                                Console.WriteLine("Şube Adı");
                                string subeAdi = Console.ReadLine();
                                Console.WriteLine("Seçilebilecek dersler");
                                int iter = 0;
                                der.ForEach(w => {
                                    Console.WriteLine((iter++) + "-)" + w.DersAdi);
                                });
                                Console.Write("Seçim: ");
                                int t = Convert.ToInt32(Console.ReadLine());
                                Ders dersAdi = der[t];
                                sub.Add(new Sube(subeAdi, dersAdi));
                            }
                            break;
                        case 2:
                            {
                                Console.Clear();
                                Console.WriteLine("Kayıtlı Şube Sayısı: " + sub.Count);
                                sub.ForEach(y => {
                                    Console.WriteLine(y.SubeAdi);
                                });
                            }
                            break;
                        case 3:
                            {
                                Console.Clear();
                                Console.WriteLine("Öğrencilerin listelenmesi için seçilebilecek şubeler");
                                int iter = 0;
                                sub.ForEach(y =>
                                {
                                    Console.WriteLine((iter++) + "-)" + y.SubeAdi);
                                });
                                Console.Write("Seçim");
                                int z = Convert.ToInt32(Console.ReadLine());
                                Sube secilenSube = sub[z];
                                secilenSube.OgrencileriYazdir();
                            }
                            break;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Şube ekleyebilmek için önceden Ders eklenmiş olmalı!");
                }
            }

            void DerIslemleri()
            {
                if (bol.Count > 0)
                {
                    Console.Clear();
                    Console.WriteLine("Ders İşlemleri");
                    Console.WriteLine("1-)Ders Ekle");
                    Console.WriteLine("2-)Dersleri Listele");
                    Console.WriteLine("3-)Kayıtlı Şubeleri Listele");
                    Console.WriteLine("4-)Derse Öğretim Elemanı Ata");
                    Console.WriteLine("5-)Dersten Öğretim Elemanı Sil");
                    Console.WriteLine("6-)Derse Öğrenci Ekle");
                    Console.WriteLine("7-)Dersten Öğrenci Sil");
                    Console.WriteLine("8-)Ders bilgilerini text dosyasına yazdır");
                    Console.Write("Seçim: ");
                    x = Convert.ToInt32(Console.ReadLine());
                    switch (x)
                    {
                        case 1:
                            {
                                Console.Clear();
                                Console.WriteLine("Ders Adı");
                                string dersAdi = Console.ReadLine().ToString();
                                Console.Write("Öğretim Yılı: ");
                                int yil = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Öğretim Dönemi: ");
                                int donem = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Seçilebilecek bölümler");
                                int iter = 0;
                                bol.ForEach(w => {
                                    Console.WriteLine((iter++) + "-)" + w.BolumAdi);
                                });
                                Console.Write("Seçim: ");
                                int t = Convert.ToInt32(Console.ReadLine());
                                Bolum bolAdi = bol[t];
                                der.Add(new Ders(dersAdi, yil, donem, bolAdi));
                            }
                            break;
                        case 2:
                            {
                                Console.Clear();
                                Console.WriteLine("Kayıtlı Ders Sayısı: " + der.Count);
                                der.ForEach(y => {
                                    Console.WriteLine(y.DersAdi);
                                });
                            }
                            break;
                        case 3:
                            {
                                Console.Clear();
                                Console.WriteLine("Şubelerin listelenmesi için seçilebilecek dersler");
                                int iter = 0;
                                der.ForEach(y =>
                                {
                                    Console.WriteLine((iter++) + "-)" + y.DersAdi);
                                });
                                Console.Write("Seçim");
                                int z = Convert.ToInt32(Console.ReadLine());
                                Ders secilenDers = der[z];
                                secilenDers.SubeleriYazdir();
                            }
                            break;
                        case 4:
                            {
                                Console.Clear();
                                Console.WriteLine("Öğretim elemanı atayabilmek için seçilebilecek dersler");
                                int iter = 0;
                                der.ForEach(y => {
                                    Console.WriteLine((iter++) + "-)" + y.DersAdi);
                                });
                                Console.Write("Seçim");
                                int z = Convert.ToInt32(Console.ReadLine());
                                Ders secilenDers = der[z];
                                Console.WriteLine("Öğretim elemanı atayabilmek için seçilebilecek öğretim elemanları");
                                iter = 0;
                                ogrel.ForEach(y => {
                                    Console.WriteLine((iter++) + "-)" + y.Numara + " " + y.Ad + " " + y.Soyad);
                                });
                                z = Convert.ToInt32(Console.ReadLine());
                                OgretimElemani atanacakOgrel = ogrel[z];
                                secilenDers.OgretimElemaniAta(atanacakOgrel);
                            }
                            break;
                        case 5:
                            {
                                Console.Clear();
                                Console.WriteLine("Öğretim elemanı silebilmek için seçilebilecek dersler");
                                int iter = 0;
                                der.ForEach(y => {
                                    Console.WriteLine((iter++) + "-)" + y.DersAdi);
                                });
                                Console.Write("Seçim");
                                int z = Convert.ToInt32(Console.ReadLine());
                                Ders secilenDers = der[z];
                                Console.WriteLine("Öğretim elemanı silebilemk için seçilebilecek öğretim elemanları");
                                iter = 0;
                                secilenDers.ogretimElemanlari.ForEach(y => {
                                    Console.WriteLine((iter++) + "-)" + y.Numara + " " + y.Ad + " " + y.Soyad);
                                });
                                z = Convert.ToInt32(Console.ReadLine());
                                OgretimElemani silinecekOgrel = ogrel[z];
                                secilenDers.OgretimElemaniSil(silinecekOgrel);
                            }
                            break;
                        case 6:
                            {
                                Console.Clear();
                                Console.WriteLine("Öğrenci ekleyebilmek için seçilebilecek dersler");
                                int iter = 0;
                                der.ForEach(y => {
                                    Console.WriteLine((iter++) + "-)" + y.DersAdi);
                                });
                                Console.Write("Seçim");
                                int z = Convert.ToInt32(Console.ReadLine());
                                Ders secilenDers = der[z];
                                Console.WriteLine("Öğrenci ekleyebilmek için seçilebilecek öğrenciler");
                                iter = 0;
                                ogr.ForEach(y => {
                                    Console.WriteLine((iter++) + "-)" + y.Numara + " " + y.Ad + " " + y.Soyad);
                                });
                                z = Convert.ToInt32(Console.ReadLine());
                                Ogrenci eklenecekOgrenci = ogr[z];
                                secilenDers.OgrenciEkle(eklenecekOgrenci);
                            }
                            break;
                        case 7:
                            {
                                Console.Clear();
                                Console.WriteLine("Öğrenci silebilmek için seçilebilecek dersler");
                                int iter = 0;
                                der.ForEach(y => {
                                    Console.WriteLine((iter++) + "-)" + y.DersAdi);
                                });
                                Console.Write("Seçim");
                                int z = Convert.ToInt32(Console.ReadLine());
                                Ders secilenDers = der[z];
                                Console.WriteLine("Öğrenci silebilmek için seçilebilecek öğrenciler");
                                iter = 0;
                                secilenDers.subeler.ForEach(y => {
                                    y.ogrenciler.ForEach(p => {
                                        Console.WriteLine((iter++) + "-)" + p.Numara + " " + p.Ad + " " + p.Soyad);
                                    });
                                });
                                z = Convert.ToInt32(Console.ReadLine());
                                Ogrenci silinecekOgrenci = ogr[z];
                                secilenDers.OgrenciSil(silinecekOgrenci);
                            }
                            break;
                        case 8:
                            {
                                Console.WriteLine("Dosyaya kaydetme için seşilebilecek dersler");
                                int iter = 0;
                                der.ForEach(y => {
                                    Console.WriteLine((iter++) + "-)" + y.DersAdi);
                                });
                                Console.Write("Seçim");
                                int z = Convert.ToInt32(Console.ReadLine());
                                Ders secilenDers = der[z];
                                secilenDers.DosyayaKaydet();
                            }
                            break;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Ders ekleyebilmek için önceden Bölüm eklenmiş olmalı!");
                }
                
            }
            
            void BolIslemleri()
            {
                if (fak.Count > 0)
                {
                    Console.Clear();
                    Console.WriteLine("Bölüm İşlemleri");
                    Console.WriteLine("1-)Bölüm Ekle");
                    Console.WriteLine("2-)Bölümleri Listele");
                    Console.WriteLine("3-)ögrenci Ekle");
                    Console.WriteLine("4-)Öğrenci Sil");
                    Console.WriteLine("5-)Öğretim Elemanı Ekle");
                    Console.WriteLine("6-)Öğretim Elemanı Sil");
                    Console.Write("Seçim: ");
                    x = Convert.ToInt32(Console.ReadLine());
                    switch (x)
                    {
                        case 1:
                            {
                                Console.Clear();
                                Console.WriteLine("Bölüm Adı");
                                string bolumAdi = Console.ReadLine().ToString();
                                Console.WriteLine("Seçilebilecek fakülteler");
                                int iter = 0;
                                fak.ForEach(w => {
                                    Console.WriteLine((iter++) + "-)" + w.FakulteAdi);
                                });
                                Console.Write("Seçim: ");
                                int t = Convert.ToInt32(Console.ReadLine());
                                Fakulte fakAdi = fak[t];
                                bol.Add(new Bolum(bolumAdi, fakAdi));
                            }
                            break;
                        case 2:
                            {
                                Console.Clear();
                                Console.WriteLine("Kayıtlı Bölüm Sayısı: " + bol.Count);
                                bol.ForEach(y => {
                                    Console.WriteLine(y.BolumAdi);
                                });
                            }
                            break;
                        case 3:
                            {
                                Console.WriteLine("Seçilebilecek Bölümler");
                                int iter = 0;
                                bol.ForEach(y => {
                                    Console.WriteLine((iter++) + "-)" + y.BolumAdi);
                                });
                                int z = Convert.ToInt32(Console.ReadLine());
                                Bolum secilenBolum = bol[z];
                                Console.WriteLine("Seçilebilecek Öğrenciler");
                                iter = 0;
                                ogr.ForEach(y => {
                                    Console.WriteLine((iter++) + "-)" + y.Numara + " " + y.Ad + " " + y.Soyad);
                                });
                                int p = Convert.ToInt32(Console.ReadLine());
                                Ogrenci secilenOgrenci = ogr[p];
                                secilenBolum.OgrenciKayit(secilenOgrenci);
                            }
                            break;
                        case 4:
                            {
                                Console.WriteLine("Seçilebilecek Bölümler");
                                int iter = 0;
                                bol.ForEach(y => {
                                    Console.WriteLine((iter++) + "-)" + y.BolumAdi);
                                });
                                int z = Convert.ToInt32(Console.ReadLine());
                                Bolum secilenBolum = bol[z];
                                Console.WriteLine("Seçilebilecek Öğrenciler");
                                iter = 0;
                                ogr.ForEach(y => {
                                    Console.WriteLine((iter++) + "-)" + y.Numara + " " + y.Ad + " " + y.Soyad);
                                });
                                int p = Convert.ToInt32(Console.ReadLine());
                                Ogrenci secilenOgrenci = ogr[p];
                                secilenBolum.OgrenciSil(secilenOgrenci);
                            }
                            break;
                        case 5:
                            {
                                Console.WriteLine("Seçilebilecek Bölümler");
                                int iter = 0;
                                bol.ForEach(y => {
                                    Console.WriteLine((iter++) + "-)" + y.BolumAdi);
                                });
                                int z = Convert.ToInt32(Console.ReadLine());
                                Bolum secilenBolum = bol[z];
                                Console.WriteLine("Seçilebilecek Öğretim Elemanları");
                                iter = 0;
                                ogrel.ForEach(y => {
                                    Console.WriteLine((iter++) + "-)" + y.Numara + " " + y.Ad + " " + y.Soyad);
                                });
                                int p = Convert.ToInt32(Console.ReadLine());
                                OgretimElemani secilenOgrel = ogrel[p];
                                secilenBolum.OgretimElemaniAta(secilenOgrel);
                            }
                            break;
                        case 6:
                            {
                                Console.WriteLine("Seçilebilecek Bölümler");
                                int iter = 0;
                                bol.ForEach(y => {
                                    Console.WriteLine((iter++) + "-)" + y.BolumAdi);
                                });
                                int z = Convert.ToInt32(Console.ReadLine());
                                Bolum secilenBolum = bol[z];
                                Console.WriteLine("Seçilebilecek Öğretim Elemanları");
                                iter = 0;
                                ogrel.ForEach(y => {
                                    Console.WriteLine((iter++) + "-)" + y.Numara + " " + y.Ad + " " + y.Soyad);
                                });
                                int p = Convert.ToInt32(Console.ReadLine());
                                OgretimElemani secilenOgrel = ogrel[p];
                                secilenBolum.OgretimElemaniSil(secilenOgrel);
                            }
                            break;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Bölüm ekleyebilmek için önceden Fakülte eklenmiş olmalı!");
                }
                
            }

            void FakIslemleri()
            {
                if (uni.Count > 0)
                {
                    Console.Clear();
                    Console.WriteLine("Fakülte İşlemleri");
                    Console.WriteLine("1-)Fakülte Ekle");
                    Console.WriteLine("2-)Fakülteleri Listele");
                    Console.Write("Seçim: ");
                    x = Convert.ToInt32(Console.ReadLine());
                    switch (x)
                    {
                        case 1:
                            {
                                Console.Clear();
                                Console.WriteLine("FakulteAdı:");
                                string fakAdi = Console.ReadLine();
                                Console.WriteLine("Seçilebilecek Ünviersiteler");
                                int iter = 0;
                                uni.ForEach(z => {
                                    Console.WriteLine((iter++) + "-)" + z.UniversiteAdi);
                                });
                                Console.Write("Seçim: ");
                                int y = Convert.ToInt32(Console.ReadLine());
                                Universite uniAdi = uni[y];
                                fak.Add(new Fakulte(fakAdi, uniAdi));
                            }
                            break;
                        case 2:
                            {
                                Console.Clear();
                                Console.WriteLine("Kayıtlı Fakülte Sayısı: " + fak.Count);
                                fak.ForEach(y => {
                                    Console.WriteLine(y.FakulteAdi);
                                });
                            }
                            break;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Fakülte ekleyebilmek için önceden Üniversite eklenmiş olmalı!");
                }

            }

            void UniIslemleri()
            {
                Console.Clear();
                Console.WriteLine("Universite İşlemleri");
                Console.WriteLine("1-)Unviersite Ekle");
                Console.WriteLine("2-)Universiteleri Listele");
                Console.Write("Seçim: ");
                x = Convert.ToInt32(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        {
                            Console.Clear();
                            Console.WriteLine("UniversiteAdı:");
                            string uniAdi = Console.ReadLine();
                            uni.Add(new Universite(uniAdi));
                        }
                        break;
                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("Kayıtlı Üniversite Sayısı: " + uni.Count);
                            uni.ForEach(y => {
                                Console.WriteLine(y.UniversiteAdi);
                            });
                        }
                        break;
                }
            }

            void Menu(int time)
            {

                if (time != 0)
                {
                    Console.WriteLine("\nDevam etmek için Enter'a basın.");
                    Console.ReadKey();
                }
                Console.Clear();
                Console.WriteLine("UniversiteApp");
                Console.WriteLine("1-)Universite İşlemleri");
                Console.WriteLine("2-)Fakulte İşlemleri");
                Console.WriteLine("3-)Bölüm İşlemleri");
                Console.WriteLine("4-)Ders İşlemleri");
                Console.WriteLine("5-)Şube İşlemleri");

                Console.WriteLine("\n6-)Öğrenci İşlemleri");
                Console.WriteLine("7-)Öğretim Görevlisi İşlemleri");

                Console.WriteLine("0-)Çıkış");
            }
        }
    }
}
