using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForDongusu
{
    class Program
    {
        static void Main(string[] args)
        {
            int dongu = 0;
            while (dongu < 100)
            {
                Console.Write("Sayı giriniz :");
                int sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi ==0)
                {
                    Console.WriteLine("0 sayısının faktöriyeli 1 ");
                }
                else
                {
                    // Not: 31 sayısına geldiğinde for döngüsünün breaklemesini istiyorum
                    int sonuc = 1;
                    for (int i = sayi; i > 0; i--)
                    {
                        
                        Console.Write("{0}*", i);
                        sonuc *= i;
                        
                    }
                    Console.WriteLine("\n{0} sayısının faktöriyeli: {1}", sayi, sonuc);

                }
                
            }

            Console.ReadLine();
        }
    }
}
