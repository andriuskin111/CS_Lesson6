using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KD_Funkcijos_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int pirmasSkaicius = 10;
            int antrasSkaicius = 20;
            bool rodytiTarpineSuma = true;

            isvestiSuma(pirmasSkaicius, antrasSkaicius);
            isvestiSuma(pirmasSkaicius, antrasSkaicius, rodytiTarpineSuma);

            Console.ReadLine();
        }

        static void isvestiSuma(int nuo, int iki)
        {
            int suma = 0;
            for (int i = nuo; i <= iki; i++)
            {
                suma += i;
            }

            Console.WriteLine($"Skaiciu suma nuo {nuo} iki {iki} lygi {suma}");
        }
        static void isvestiSuma(int nuo, int iki, bool rodytiTarpineSuma)
        {
            int sum = 0;

            Console.WriteLine($"Skaiciu nuo {nuo} iki {iki} tarpine suma:");
            for (int i = nuo; i <= iki; i++)
            {
                Console.Write(sum);
                sum += i;
                Console.WriteLine($" + {i} = {sum}");
            }
        }
    }
}
