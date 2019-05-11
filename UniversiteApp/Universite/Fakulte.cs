using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversiteApp
{
    class Fakulte
    {
        public String FakulteAdi { get; set; }
        public Universite Universite { get; set; }
        public List<Bolum> bolumler = new List<Bolum>();

        public Fakulte(string fakulteAdi, Universite universite)
        {
            FakulteAdi = fakulteAdi;
            Universite = universite;
            universite.fakulteler.Add(this);
        }

        public void BolumleriYazdir()
        {
            Console.WriteLine($"{FakulteAdi} Fakultesi'nin Bölümleri:");
            bolumler.ForEach(x => {
                Console.WriteLine(x.BolumAdi);
            });
            Console.WriteLine("---SON---\n");
        }
    }
}
