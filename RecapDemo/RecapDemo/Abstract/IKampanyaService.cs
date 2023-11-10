using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemo
{
    internal interface IKampanyaService
    {
        void KampanyaEkle(Oyuncu oyuncu);
        void KampanyaGuncelle(Oyuncu oyuncu);
        void KampanyayiSil(Oyuncu oyuncu);
    }
}
