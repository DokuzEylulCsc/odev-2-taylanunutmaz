using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversiteApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Universite deu = new Universite("Dokuz Eylül");
            Fakulte fen = new Fakulte("Fen", deu);
            Bolum bil = new Bolum("Bilgisayar Bilimleri", fen);
            Ders bil1001 = new Ders("Bilgisayar Bilimlerine Giris", 1, 1, bil);
            Sube bil1001_a = new Sube("A", bil1001);

            
            fen.BolumleriYazdir();
            bil1001.SubeleriYazdir();

            Lisans taylan = new Lisans("Taylan", "Unutmaz", bil);

            bil1001.OgrenciEkle(taylan);
            bil1001.OgrenciSil(taylan);

            OgretimElemani ali = new OgretimElemani("Ali", "Can", bil, "Araştırma Görevlisi");
            OgretimElemani ali2 = new OgretimElemani("Ali", "Can", bil, "Araştırma Görevlisi");

            bil1001.OgretimElemaniAta(ali);
            bil1001.OgretimElemaniAta(ali2);
            bil1001.OgretimElemaniSil(ali2);

            Console.WriteLine(taylan.Bolum.BolumAdi);

            bil.OgrenciSil(taylan);
            bil.OgrenciKayit(taylan);

            Console.WriteLine(taylan.Bolum.BolumAdi);

            bil.OgrencileriYadir();


            Console.ReadKey();
        }

        
    }
}
