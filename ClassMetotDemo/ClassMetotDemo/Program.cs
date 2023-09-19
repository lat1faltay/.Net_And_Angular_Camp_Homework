using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri();
            musteri1.id = 1;
            musteri1.isim = "Latif";
            musteri1.soyisim = "Altay";
            musteri1.para = 99999999;

            Musteri musteri2 = new Musteri();
            musteri2.id = 2;
            musteri2.isim = "Ali";
            musteri2.soyisim = "Alii";
            musteri2.para = 120;

            Musteri musteri3 = new Musteri();
            musteri3.id = 3;
            musteri3.isim = "Veli";
            musteri3.soyisim = "Veli";
            musteri3.para = 200;


            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            // Müsteri tipindeki musteriler dizisinin elemanlarını yazdırma
            foreach (var musteri in musteriler)
            {
                Console.Write(musteri.id + " ");
                Console.Write(musteri.isim + " ");
                Console.Write(musteri.soyisim + " ");
                Console.Write(musteri.para);
                Console.WriteLine();
            }

            Console.WriteLine();

            // MusteriManager sınıfından bir örnek alıyoruz
            MusteriManager musteriManager = new MusteriManager();

            Console.WriteLine();
            Console.WriteLine("Müşteri Ekle");
            // MüsteriManager sınıfının MüsteriEkle metotunu kullanarak müsteri ekliyoruz
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            musteriManager.MusteriEkle(musteri3);

            Console.WriteLine();
            Console.WriteLine("Müşteri Listele");
            // MüsteriManager sınıfının MüsteriListe metotunu kullanarak müsteri listeliyoruz
            musteriManager.MusteriListe(musteri1);
            musteriManager.MusteriListe(musteri2);
            musteriManager.MusteriListe(musteri2);

            Console.WriteLine();
            Console.WriteLine("Müşteri sil");
            // MüsteriManager sınıfının MüsteriSil metotunu kullanarak müsteri siliyoruz
            musteriManager.MusteriSil(musteri1);
            musteriManager.MusteriSil(musteri1);
            musteriManager.MusteriSil(musteri1);


            Console.ReadKey();
        }
    }
}
