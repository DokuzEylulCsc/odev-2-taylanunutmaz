﻿using System;
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
                }
            }

            void OgrIslemleri()
            {
                Console.Clear();
                Console.WriteLine("Öğrenci İşlemleri");
                Console.WriteLine("1-)Öğrenci Ekle");
                Console.WriteLine("2-)Öğrencileri Listele");
                Console.Write("Seçim: ");
                x = Convert.ToInt32(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        {
                            //TODO Ogrenci sınıfındaki yoruma alınan kayıt fonksiyonundan yaraklanarak düzenle
                        } break;
                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("Kayıtlı Öğrenci Sayısı: " + ogr.Count);
                            ogr.ForEach(y => {
                                Console.WriteLine($"{y.Numara} - {y.Ad} {y.Soyad}");
                            });
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
                    Console.Write("Seçim: ");
                    x = Convert.ToInt32(Console.ReadLine());
                    switch (x)
                    {
                        case 1:
                            {
                                Console.Clear();
                                Console.WriteLine("Şube Adı");
                                string subeAdi = Console.ReadLine();
                                Ders dersAdi;
                                der.ForEach(w => {
                                    Console.WriteLine(w.DersAdi);
                                });
                                int t = Convert.ToInt32(Console.ReadLine());
                                dersAdi = der[t];
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
                    Console.Write("Seçim: ");
                    x = Convert.ToInt32(Console.ReadLine());
                    switch (x)
                    {
                        case 1:
                            {
                                Console.WriteLine("Ders Adı");
                                string dersAdi = Console.ReadLine().ToString();
                                int yil = Convert.ToInt32(Console.ReadLine());
                                int donem = Convert.ToInt32(Console.ReadLine());
                                Bolum bolAdi;
                                bol.ForEach(w => {
                                    Console.WriteLine(w.BolumAdi);
                                });
                                int t = Convert.ToInt32(Console.ReadLine());
                                bolAdi = bol[t];
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
                    Console.Write("Seçim: ");
                    x = Convert.ToInt32(Console.ReadLine());
                    switch (x)
                    {
                        case 1:
                            {
                                Console.WriteLine("Bölüm Adı");
                                string bolumAdi = Console.ReadLine().ToString();
                                Fakulte fakAdi;
                                fak.ForEach(w => {
                                    Console.WriteLine(w.FakulteAdi);
                                });
                                int t = Convert.ToInt32(Console.ReadLine());
                                fakAdi = fak[t];
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
                                Universite uniAdi;
                                uni.ForEach(z =>
                                {
                                    Console.WriteLine(z.UniversiteAdi);
                                });
                                int y = Convert.ToInt32(Console.ReadLine());
                                uniAdi = uni[y];
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