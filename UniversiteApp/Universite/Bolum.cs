using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversiteApp
{
    class Bolum
    {
        public String BolumAdi { get; set; }
        public Fakulte Fakulte;
        public List<Ders> dersler = new List<Ders>();
        //TODO ogretim elemanının Sube sınıfı ile ilişkisine bak
        public List<OgretimElemani> ogretimElemanlari = new List<OgretimElemani>();

        public Bolum(string bolumAdi, Fakulte fakulte)
        {
            BolumAdi = bolumAdi;
            Fakulte = fakulte;
        }

        public void OgrenciKayit()
        {
            //TODO Ogrenci ve Sube sınıfındaki kayıt methoduyla ve direk sınıfın kendisi ile ilişkilendir
        }

        public void OgrenciSil()
        {
            //TODO Ogrenci Sube sınıfıyla ilişkilendir
        }

        public void OgretimElemaniAta()
        {
            //TODO OgretimElemani sınıfıyla ilişkilendir
        }

        public void OgretimElemaniSil()
        {
            //TODO OgretimElemani sınfıyla ilişkilendir
        }

        public void DersAc()
        {
            //TODO Ders sınıfı ile ilişkilendir
        }

        public void DersKapa()
        {
            //TODO Ders sınıfı ile ilişkilendir veya sadece List üzeründen müdahale et
        }
    }
}
