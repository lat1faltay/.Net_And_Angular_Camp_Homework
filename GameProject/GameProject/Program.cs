using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.add(new Gamer { id = 1, BirthYear = 2000, Firstname = "Latif", Lastname = "Altay", IdentityNumber = 123 });

            Console.ReadKey();
        }
    }
}
