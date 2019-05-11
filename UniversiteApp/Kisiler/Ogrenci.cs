using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversiteApp
{
    class Ogrenci
    {
        public String Ad { get; set; }
        public String Soyad { get; set; }
        public int Numara { get; set; }
        public List<Ders> dersler = new List<Ders>(10);
        public Bolum Bolum { get; set; }

        public Ogrenci(string ad, string soyad, Bolum bolum)
        {
            Ad = ad;
            Soyad = soyad;
            Bolum = bolum;
            Random rd = new Random();
            Numara = DateTime.Now.Year * 1000000 + rd.Next(100000, 999999);
            /*
             * buranın kaldırılma açıklaması için yoruma alınan OgrenciKayıt methoduna bak
            try
            {
                OgrenciKayit();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            */
        }

        /*
         * Bölümlerin listelendirilmesinde static bir liste kullanmanın zorluğundan dolayı inşaacı yardımı
         * ile öğrenci kayıt yapımına geçildi
        private void OgrenciKayit(int retryNumber = 0)
        {
            Console.WriteLine("Yeni Öğrenci Kaydı Oluşturuluyor.");
            Console.WriteLine("Öğrenci Adı:");
            const int maxRetryNumber = 3; //maxRetryNumber için bkz(https://stackoverflow.com/a/9272075)
            try
            {
                Ad = Console.ReadLine().ToString();
            }
            catch (Exception)
            {
                if (retryNumber < maxRetryNumber)
                {
                    Console.WriteLine("Bir şeyler yanlış gitti. Hata kodu 0xMicrosoftJokes. " +
                        "Lütfen girdinizi kontrol edip tekrar deneyin.");
                    OgrenciKayit(retryNumber++);
                }
                else
                {
                    throw new Exception("Çok sayıda hatalı giriş yapıldı.");
                }
            }

            Console.WriteLine("Öğrenci Soyadı:");
            try
            {
                Soyad = Console.ReadLine().ToString();
            }
            catch (Exception)
            {
                if (retryNumber < maxRetryNumber)
                {
                    Console.WriteLine("Bir şeyler yanlış gitti. Hata kodu 0xMicrosoftJokes. " +
                        "Lütfen girdinizi kontrol edip tekrar deneyin.");
                    OgrenciKayit(retryNumber++);
                }
                else
                {
                    throw new Exception("Çok sayıda hatalı giriş yapıldı.");

                }
            }

            //TODO Kayıt sırasında bölüm ekleme yap


            Random rd = new Random();
            Numara = DateTime.Now.Year * 1000000 +  rd.Next(100000, 999999);

            Console.WriteLine($"{Ad} {Soyad} adlı öğrenci {Numara} numarasıyla başarıyla kaydedildi.");
        }
        */
    }
}
