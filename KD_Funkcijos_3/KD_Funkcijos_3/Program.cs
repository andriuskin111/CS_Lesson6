using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KD_Funkcijos_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SuskaiciuotiSimbolius("Andrius"));

            Console.ReadLine();
        }

        static string SuskaiciuotiSimbolius(string eilute)
        {
            string simboliai = "";
            for (int i = 0; i < eilute.Length; i++)
            {
                simboliai += '#';
            }
            return simboliai;
        }
    }
}
