using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KD_Funkcijos_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double skaicius = 10;
            int laipsnis = 3;

            Console.WriteLine($"Skaiciaus {skaicius} pakeltas {laipsnis}-iuoju laipsniu lygus {pakeltiSkaiciuLaipsniu(skaicius, laipsnis)}");

            Console.ReadLine();
        }

        static double pakeltiSkaiciuLaipsniu(double skaicius, int laipsnis)
        {
            double pakeltasSkaiciusLaipsniu = Math.Pow(skaicius, laipsnis);
            return pakeltasSkaiciusLaipsniu;
        }
    }

}
