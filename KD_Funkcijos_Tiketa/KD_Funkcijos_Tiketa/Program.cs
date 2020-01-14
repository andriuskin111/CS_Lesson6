using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KD_Funkcijos_Tiketa
{
    class Program
    {
        static void Main(string[] args)
        {
            int bilietai10 = 100;
            int bilietai20 = 100;
            int bilietai30 = 100;
            int bilietoPasirinkimas;
            int bilietuKiekis;

            
            while (true)
            {
                Console.WriteLine($"Bilietu likutis:\nUz 10$: {bilietai10}\nUz 20$: {bilietai20}\nUz 30$: {bilietai30}");
                Console.WriteLine("Pasirinkite bilieto tipa: [1] Po 10$, [2] Po 20$, [3] Po 30$, [4] Iseiti is programos");

                while (!int.TryParse(Console.ReadLine(), out bilietoPasirinkimas))
                {
                    Console.WriteLine("Ivesti neteisingi duomenys!");
                }

                if(bilietoPasirinkimas < 1 || bilietoPasirinkimas > 4)
                {
                    Console.WriteLine("Ivestas neteisingas skaicius");
                }
                else if(bilietoPasirinkimas == 4)
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Iveskite bilietu kieki");

                    while (!int.TryParse(Console.ReadLine(), out bilietuKiekis))
                    {
                        Console.WriteLine("Ivesti neteisingi duomenys!");
                    }

                    if (bilietoPasirinkimas == 1)
                    {
                        ParduotiBilietus(ref bilietai10, bilietuKiekis, bilietoPasirinkimas);
                    }
                    else if (bilietoPasirinkimas == 2)
                    {
                        ParduotiBilietus(ref bilietai20, bilietuKiekis, bilietoPasirinkimas);
                    }
                    else
                    {
                        ParduotiBilietus(ref bilietai30, bilietuKiekis, bilietoPasirinkimas);
                    }
                }

            }
            
        }

        static void ParduotiBilietus(ref int bilietai, int bilietuKiekis, int bilietoTipas)
        {
            string tipas;
            if(bilietoTipas == 1)
            {
                tipas = "uz 10$";
            }
            else if (bilietoTipas == 2)
            {
                tipas = "uz 20$";
            }
            else
            {
                tipas = "uz 30$";
            }

            if (bilietai == 0)
            {
                Console.WriteLine("Bilietu nera");
            }
            else if((bilietai - bilietuKiekis) < 0)
            {
                Console.WriteLine("Bilietu kiekis nepakankamas");
            }
            else
            {


                bilietai -= bilietuKiekis;

                Console.WriteLine($"Parduota bilietu {tipas}: {bilietuKiekis}, Liko: {bilietai}");
            }
        }

    }
}
