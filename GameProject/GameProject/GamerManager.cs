using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    // MicroService dışarıdan çekerek kullandığımız servislere verilen isim)
    internal class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("Kayıt başarılı");
            }
            else 
            {
                Console.WriteLine("Kayıt başarısız");
            }

        }

        public void delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt silindi");
        }

        public void update(Gamer gamer)
        {
            Console.WriteLine("Kayıt güncellendi");
        }
    }
}
