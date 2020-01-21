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
            string pinKodas = "1234";
            string[] slaptazodis = new string[pinKodas.Length];
            int count = 0;
            int pinCount = 0;

            foreach (var item in pinKodas)
            {
                slaptazodis[pinCount] = item.ToString();
                pinCount++;
            }

            for (int i = 0; i < sakinys.Length; i++)
            {
                if(count < (slaptazodis.Length - 1))
                {
                    count++;
                }
                else
                {
                    count = 0;
                }
                int simbolis = (int)sakinys[i];
                simbolis += int.Parse(slaptazodis[count]); ;
                uzsifruotasSakinys += (char)simbolis;
            }

            count = 0;

            for (int i = 0; i < sakinys.Length; i++)
            {
                if (count < (slaptazodis.Length - 1))
                {
                    count++;
                }
                else
                {
                    count = 0;
                }
                int simbolis = (int)uzsifruotasSakinys[i];
                simbolis -= int.Parse(slaptazodis[count]);
                desifruotasSakinys += (char)simbolis;
            }

            Console.WriteLine($"Sakinys: {sakinys}\nUzsifroutas: {uzsifruotasSakinys}\nDesifruotas: {desifruotasSakinys}");

            Console.ReadLine();
        }
    }
}
