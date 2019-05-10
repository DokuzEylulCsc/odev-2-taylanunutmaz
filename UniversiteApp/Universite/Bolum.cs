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
        public List<Ders> dersler = new List<Ders>();
        public Fakulte fakulte;
        public List<OgretimElemani> ogretimElemanlari = new List<OgretimElemani>();

        public void OgrenciKayit()
        {
            //TODO Ogrenci sınıfındaki kayıt methoduyla ve direk sınıfın kendisi ile ilişkilendir
        }

        public void OgrenciSil()
        {
            //TODO Ogrenci sınıfıyla ilişkilendir
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
