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
        List<Ders> dersler = new List<Ders>(10);
        public Bolum Bolum { get; set; }

        public Ogrenci()
        {
            OgrenciKayit();
        }

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
                    Console.WriteLine("Bir şeyler yanlış gitti. Hata kodu 0xMicrosoft. " +
                        "Lütfen kontrol edip tekrar deneyin.");
                    OgrenciKayit(retryNumber++);
                }
                else
                {
                    Console.WriteLine("Çok sayıda hatalı giriş yapıldıği için " +
                        "kayıt işlemi sonlandırılıyor!");
                    throw;
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
                    Console.WriteLine("Bir şeyler yanlış gitti. Hata kodu 0xMicrosoft. " +
                        "Lütfen kontrol edip tekrar deneyin.");
                    OgrenciKayit(retryNumber++);
                }
                else
                {
                    Console.WriteLine("Çok sayıda hatalı giriş yapıldıği için " +
                        "kayıt işlemi sonlandırılıyor!");
                    throw;
                }
            }

            //TODO Kayıt sırasında bölüm ekleme yap

            Random rd = new Random();
            Numara = DateTime.Now.Year * 1000000 +  rd.Next(100000, 999999);

            Console.WriteLine($"{Ad} {Soyad} adlı öğrenci {Numara} numarasıyla başarıyla kaydedildi.");
            
        }
    }
}
