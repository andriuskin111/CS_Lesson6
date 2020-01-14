using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KD_Funkcijos_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string vardas = "Andrius";
            int kartai = 10;

            IsvestiVarda(vardas, kartai);

            Console.ReadLine();
        }

        static void IsvestiVarda(string vardas, int kartai)
        {
            for (int i = 0; i < kartai; i++)
            {
                Console.WriteLine(vardas);
            }
        }
    }
}
