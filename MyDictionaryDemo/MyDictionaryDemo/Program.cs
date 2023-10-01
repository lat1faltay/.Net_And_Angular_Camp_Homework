using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionaryDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "ali");
            myDictionary.Add(2, "ahmet");


            foreach (var key in myDictionary.Keys) 
            { 
                Console.WriteLine(key);
            }

            foreach (var value in myDictionary.Values)
            {
                Console.WriteLine(value);
            }

            Console.ReadKey();  
        }
    }
}
