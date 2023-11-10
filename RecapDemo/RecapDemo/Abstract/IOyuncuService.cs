using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemo
{
    internal interface IOyuncuService
    {
        void KayitOl(Oyuncu oyuncu);
        void BilgilerGuncelle(Oyuncu oyuncu);
        void KayitSil(Oyuncu oyuncu);

    }
}
