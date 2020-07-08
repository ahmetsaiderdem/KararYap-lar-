using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2, CiftToplam=0, TekToplam=0;
            
            Console.Write("1.Sayı giriniz:");
            sayi1 = int.Parse(Console.ReadLine());
            Console.Write("2.Sayı giriniz:");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            if (sayi1!=sayi2)
            {
                if (sayi1 > sayi2)
                {
                    while (sayi2 < sayi1)
                    {
                        if (sayi2 % 2 == 0)
                        {
                            CiftToplam += sayi2;

                        }
                        else
                        {
                            TekToplam += sayi2;
                        }
                        sayi2++;
                    }
                }
                else if (sayi2 > sayi1)
                {
                    while (sayi1 < sayi2)
                    {
                        if (sayi1 % 2 == 0)
                        {
                            CiftToplam += sayi1;

                        }
                        else
                        {
                            TekToplam += sayi1;
                        }
                        sayi1++;
                    }
                }

                Console.WriteLine("Çift Sayıların Toplamı: {0}", CiftToplam);
                Console.WriteLine("Tek Sayıların Toplamı: {0}", TekToplam);
                Console.ReadLine();

            }
            else
            {
                Console.Write("Sayılar Eşittir");
            }
            Console.ReadLine();

        }
    }
}
