using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KD_Funkcijos_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string eilute = "A A A A A A A";

            Console.WriteLine(SuskaiciuotiTarpus(eilute));

            Console.ReadLine();
        }

        static int SuskaiciuotiTarpus(string eilute)
        {
            int tarpuSkaicius = 0;

            foreach (var item in eilute)
            {
                if(item == ' ')
                {
                    tarpuSkaicius++;
                }
            }
            return tarpuSkaicius;
        }
    }
}
