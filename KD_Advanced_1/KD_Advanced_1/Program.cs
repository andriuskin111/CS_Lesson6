using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KD_Advanced_1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Iveskite zodi arba sakini: [exit] - iseiti is programos");
                string fraze = Console.ReadLine();

                if(fraze == "exit")
                {
                    Environment.Exit(0);
                }

                patikrintiArPalindromas(fraze);

                Console.WriteLine(patikrintiArPalindromas(fraze));
            }
        }

        static bool patikrintiArPalindromas(string fraze)
        {
            bool palindromas = false;
            string[] separator = { " " };
            string[] frazeArray = fraze.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            string frazeBeTarpu = string.Join("", frazeArray);
            string frazeBeTarpuReversed = "";

            for (int i = frazeBeTarpu.Length - 1; i >= 0 ; i--)
            {
                frazeBeTarpuReversed += string.Join("",frazeBeTarpu[i]);
            }
            
            if(frazeBeTarpu == frazeBeTarpuReversed)
            {
                palindromas = true;
            }
            else
            {
                palindromas = false;
            }

            //Console.WriteLine(frazeBeTarpu);
            //Console.WriteLine(frazeBeTarpuReversed);

            
            return palindromas;
        }
    }
}
