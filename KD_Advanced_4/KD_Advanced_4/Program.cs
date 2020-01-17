using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KD_Advanced_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int skaicius = 5;
            Console.WriteLine($"{skaicius}! = {parodytiFactoriala(1, skaicius)}");

            Console.ReadLine();
        }

        static int parodytiFactoriala(int skaiciusNuo, int skaiciusIki)
        {
            int result = skaiciusNuo;

            if(skaiciusNuo < skaiciusIki)
            {
                skaiciusNuo++;
                return result *= parodytiFactoriala(skaiciusNuo, skaiciusIki);
            }
            return result;
        }
    }
}
