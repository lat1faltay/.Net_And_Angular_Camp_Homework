using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemo
{
    internal class OyuncuManager : IOyuncuService
    {
        public void BilgilerGuncelle(Oyuncu oyuncu)
        {
            Console.WriteLine("Oyuncu bilgileri güncellendi");
        }

        public void KayitOl(Oyuncu oyuncu)
        {
            Console.WriteLine("Oyuncu kayıt edildi");
        }

        public void KayitSil(Oyuncu oyuncu)
        {
            Console.WriteLine("Oyuncu kayıtı silindi");
        }


    }
}
