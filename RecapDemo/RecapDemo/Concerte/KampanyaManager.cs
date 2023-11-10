using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemo
{
    internal class KampanyaManager : IKampanyaService
    {
        public void KampanyaEkle(Oyuncu oyuncu)
        {
            Console.WriteLine("KAmpanya Eklendi");
        }

        public void KampanyaGuncelle(Oyuncu oyuncu)
        {
            Console.WriteLine("KAmpanya Güncellendi");
        }

        public void KampanyayiSil(Oyuncu oyuncu)
        {
            Console.WriteLine("KAmpanya Silindi");
        }
    }
}
