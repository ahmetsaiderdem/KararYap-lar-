using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 100;
            while (sayi > 0)
            {
                Console.WriteLine("Merhaba Dünya-{0}", sayi);
                sayi--;
            }
            Console.Clear();

            int sayi1 = 0;
            while (sayi1 < 100)
            {
                sayi1++;
                int toplam = sayi1 * (sayi1 + 1) / 2;
                Console.WriteLine(toplam);


            }
            Console.Clear();


            int TekToplam = 0, ÇiftToplam = 0;
            int deger = 0;
            while (deger < 100)
            {
                if (deger % 2 == 0)
                {
                    ÇiftToplam += deger;
                }
                else
                {
                    TekToplam += deger;
                }
                deger++;

            }
            Console.Write("Çiftsayıların Toplamı:{0}", ÇiftToplam);
            string Çt = Console.ReadLine();
            Console.Write("Tek Sayıların Toplamı:{0}", TekToplam);
            string TT = Console.ReadLine();
            Console.ReadLine();
        }
    }
}
