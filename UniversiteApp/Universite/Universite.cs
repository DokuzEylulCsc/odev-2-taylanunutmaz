using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversiteApp
{
    class Universite
    {
        public String UniversiteAdi { get; set; }
        public List<Fakulte> fakulteler = new List<Fakulte>();

        public Universite(string universiteAdi)
        {
            UniversiteAdi = universiteAdi;
        }
    }
}
