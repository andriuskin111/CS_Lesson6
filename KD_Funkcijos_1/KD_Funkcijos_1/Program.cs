using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KD_Funkcijos_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string vardas = "Andrius";

            IsvestiVarda(vardas);

            Console.ReadLine();
        }

        static void IsvestiVarda(string vardas)
        {
            Console.WriteLine(vardas);
        }
    }
}
