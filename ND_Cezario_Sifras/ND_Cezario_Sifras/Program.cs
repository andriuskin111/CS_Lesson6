using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ND_Cezario_Sifras
{
    class Program
    {
        static void Main(string[] args)
        {
            string sakinys = "Kosmonautas isskrido i menuli";
            string uzsifruotasSakinys = "";
            string desifruotasSakinys = "";
            string slaptazodis = "4";

            for (int i = 0; i < sakinys.Length - 1; i++)
            {
                int simbolis = (int)sakinys[i];
                simbolis += int.Parse(slaptazodis);
                uzsifruotasSakinys += (char)simbolis;
            }

            for (int i = 0; i < sakinys.Length - 1; i++)
            {
                int simbolis = (int)uzsifruotasSakinys[i];
                simbolis -= int.Parse(slaptazodis);
                desifruotasSakinys += (char)simbolis;
            }

            Console.WriteLine($"Sakinys: {sakinys}\nUzsifroutas: {uzsifruotasSakinys}\nDesifruotas: {desifruotasSakinys}");

            Console.ReadLine();
        }
    }
}
