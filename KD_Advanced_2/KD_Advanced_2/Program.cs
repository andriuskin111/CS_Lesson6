using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KD_Advanced_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int maksimalusRezultatuSkaicius = 20;

            ParodytiFibonacioSkaiciu(maksimalusRezultatuSkaicius);

            Console.ReadLine();
        }

        static void ParodytiFibonacioSkaiciu(int aMaksimalusRezultatuSkaicius)
        {
            int pirmasSkaicius = 0;
            int antrasSkaicius = 1;

            for (int i = 0; i <= aMaksimalusRezultatuSkaicius; i++ )
            {
                int temp = pirmasSkaicius;
                pirmasSkaicius = antrasSkaicius;
                antrasSkaicius += temp;
                Console.Write($"{pirmasSkaicius}, ");
            }
        }
    }
}
