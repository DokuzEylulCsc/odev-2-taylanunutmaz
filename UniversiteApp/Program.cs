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

            Console.ReadKey();
        }

        
    }
}
