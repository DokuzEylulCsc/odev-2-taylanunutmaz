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
        public Universite universite { get; set; }
        public List<Bolum> bolumler = new List<Bolum>();

        public Fakulte(string fakulteAdi)
        {
            FakulteAdi = fakulteAdi;
        }
    }
}
