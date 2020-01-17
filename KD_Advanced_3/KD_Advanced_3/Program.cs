using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KD_Advanced_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int skaiciu = 1234567;

            suskaiciuotiAtskiruSkaitmenuSuma(skaiciu);

            Console.ReadLine();
        }

        static void suskaiciuotiAtskiruSkaitmenuSuma(int skaicius)
        {
            string skaiciusString = skaicius.ToString();
            int[] skaiciusArray = new int[skaiciusString.Length];
            string[] skaiciusStringArray = new string[skaiciusString.Length];

            for (int i = 0; i < skaiciusString.Length; i++)
            {
                skaiciusStringArray[i] = Convert.ToString(skaiciusString[i]);
            }

            for (int i = 0; i < skaiciusArray.Length; i++)
            {
                skaiciusArray[i] = Convert.ToInt32(skaiciusStringArray[i]);
                Console.Write($"{skaiciusArray[i]} ");

            }

            Console.WriteLine();

            for (int i = 0; i < skaiciusArray.Length; i++)
            {
                int suma = 0;

                for (int k = 0; k < skaiciusArray[i]; k++)
                {
                    suma += k;                   
                }
                Console.Write($"{suma} ");
            }
        }
    }
}
