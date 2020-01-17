using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ND_Metodai_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite varda:");
            string vardas = Console.ReadLine();
            Console.WriteLine("Iveskite pavarde:");
            string pavarde = Console.ReadLine();
            Console.WriteLine(sujungtiVardaPavarde(vardas, pavarde));

            Console.ReadLine();
        }

        static string sujungtiVardaPavarde(string vardas, string pavarde)
        {
            string vardasPavarde = vardas + ", " + pavarde;
            return vardasPavarde;
        }
    }
}
