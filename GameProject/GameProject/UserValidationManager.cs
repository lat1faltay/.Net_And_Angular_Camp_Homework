using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 2000 && gamer.Firstname == "Latif" && gamer.Lastname == "Altay" && gamer.IdentityNumber == 123)
            {
                return true;
            }
            else 
            { 
                return false;
            }
        }
    }
}
