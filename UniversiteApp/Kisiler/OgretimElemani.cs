using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversiteApp
{
    class OgretimElemani
    {
        public String Unvan { get; set; }
        public String Ad { get; set; }
        public String Soyad { get; set; }
        public int Numara { get; set; }
        public Bolum Bolum { get; set; }

        public OgretimElemani()
        {
            try
            {
                OgretimElemaniKayıt();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        private void OgretimElemaniKayıt(int retryNumber = 0)
        {
            Console.WriteLine("Yeni Öğretim Elemanı Kaydı Oluşturuluyor.");
            Console.WriteLine("Öğretim Elemanı Adı:");
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
                    OgretimElemaniKayıt(retryNumber++);
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
                    OgretimElemaniKayıt(retryNumber++);
                }
                else
                {
                    throw new Exception("Çok sayıda hatalı giriş yapıldı.");
                }
            }

            //TODO Kayıt sırasında bölüm ekleme yap

            Random rd = new Random();
            Numara = DateTime.Now.Year * 10000 + rd.Next(1000, 9999);

            Console.WriteLine($"{Ad} {Soyad} adlı öğretim elemanı {Numara} numarasıyla başarıyla kaydedildi.");
        }
    }
}
