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

            Console.WriteLine("Pasirinkite bilieto tipa: [1] Po 10$, [2] Po 20$, [3] Po 30$");

            while(!int.TryParse(Console.ReadLine(), out bilietoPasirinkimas))
            {
                Console.WriteLine("Ivesti neteisingi duomenys!");
            }

            if (bilietoPasirinkimas < 1 || bilietoPasirinkimas > 3)
            {
                Console.WriteLine("Neteisingai pasirinktas bilieto tipas");
                Console.ReadLine();
            }

            Console.WriteLine("Iveskite bilietu kieki");

            while (!int.TryParse(Console.ReadLine(), out bilietuKiekis))
            {
                Console.WriteLine("Ivesti neteisingi duomenys!");
            }

            
            if(bilietoPasirinkimas == 1)
            {
                ParduotiBilietus(ref bilietai10, bilietuKiekis);
            }
            else if (bilietoPasirinkimas == 2)
            {
                ParduotiBilietus(ref bilietai20, bilietuKiekis);
            }
            else
            {
                ParduotiBilietus(ref bilietai30, bilietuKiekis);
            }



            Console.ReadLine();
        }

        static void ParduotiBilietus(ref int bilietai, int bilietuKiekis)
        {
            if(bilietai == 0)
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

                Console.WriteLine($"Parduota bilietu: {bilietuKiekis}, Liko: {bilietai}");
            }
        }

    }
}
