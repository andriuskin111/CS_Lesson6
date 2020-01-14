using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KD_Funkcijos_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double mase = 75;
            double ugis = 1.81;

            Console.WriteLine(GrazintiKmi(mase, ugis));

            Console.ReadLine();
        }

        static double GrazintiKmi(double mase, double ugis)
        {
            double kmi = mase / (ugis * ugis);
            return kmi;
        }
    }
}
