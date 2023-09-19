using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        public void MusteriEkle(Musteri musteri) {
            Console.WriteLine("Müşteri eklendi, müşteri bilgileri isim : " + musteri.isim + " soyisim: " + musteri.soyisim);
        }

        public void MusteriListe(Musteri musteri) {
            Console.WriteLine("Müşteri eklendi, müşteri bilgileri isim : " + musteri.isim + " soyisim: " + musteri.soyisim + " para: " + musteri.para);
        }

        public void MusteriSil(Musteri musteri) {
            Console.WriteLine("Müşteri silindi, müşteri bilgileri isim : " + musteri.isim + " soyisim: " + musteri.soyisim );
        }

    }
}
