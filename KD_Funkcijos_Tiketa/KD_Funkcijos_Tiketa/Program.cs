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
            int veiksmoPasirinkimas;
            int bilietoPasirinkimas;
            int bilietuKiekis;

            
            while (true)
            {
                Console.WriteLine($"Bilietu likutis:\nUz 10$: {bilietai10}\nUz 20$: {bilietai20}\nUz 30$: {bilietai30}");
                Console.WriteLine("Pasirinkite veiksma: [1] Prideti bilietus, [2] Parduoti bilietus,[3] Iseiti is programos");
                while (!int.TryParse(Console.ReadLine(), out veiksmoPasirinkimas))
                {
                    Console.WriteLine("Ivesti neteisingi duomenys!");
                }

                if (veiksmoPasirinkimas < 1 || veiksmoPasirinkimas > 3)
                {
                    Console.WriteLine("Ivestas neteisingas skaicius");
                }
                else if (veiksmoPasirinkimas == 3)
                {
                    Environment.Exit(0);
                }
                else if(veiksmoPasirinkimas == 1)
                {
                    Console.WriteLine("Pasirinkite bilieto tipa: [1] Po 10$, [2] Po 20$, [3] Po 30$");

                    while (!int.TryParse(Console.ReadLine(), out bilietoPasirinkimas))
                    {
                        Console.WriteLine("Ivesti neteisingi duomenys!");
                    }

                    if (bilietoPasirinkimas < 1 || bilietoPasirinkimas > 3)
                    {
                        Console.WriteLine("Ivestas neteisingas skaicius");
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
                            PridetiBilietus(ref bilietai10, bilietuKiekis, bilietoPasirinkimas);
                        }
                        else if (bilietoPasirinkimas == 2)
                        {
                            PridetiBilietus(ref bilietai20, bilietuKiekis, bilietoPasirinkimas);
                        }
                        else
                        {
                            PridetiBilietus(ref bilietai30, bilietuKiekis, bilietoPasirinkimas);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Pasirinkite bilieto tipa: [1] Po 10$, [2] Po 20$, [3] Po 30$");

                    while (!int.TryParse(Console.ReadLine(), out bilietoPasirinkimas))
                    {
                        Console.WriteLine("Ivesti neteisingi duomenys!");
                    }

                    if (bilietoPasirinkimas < 1 || bilietoPasirinkimas > 3)
                    {
                        Console.WriteLine("Ivestas neteisingas skaicius");
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
            
        }

        static void PridetiBilietus(ref int bilietai, int bilietuKiekis, int bilietoTipas)
        {
            string tipas;
            if (bilietoTipas == 1)
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

                bilietai += bilietuKiekis;

                Console.WriteLine($"Prideta bilietu {tipas}: {bilietuKiekis}, Likutis: {bilietai}");          
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
