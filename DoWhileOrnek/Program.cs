using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 0;
            int toplam = 0;
            do
            {
                Console.Write("sayı giriniz:");
                sayi = Convert.ToInt32(Console.ReadLine());
                toplam += sayi;
            } while (sayi!=0);
            Console.Write("sayıların toplamı: {0}", toplam);
            Console.ReadLine();
        }
    }
}
