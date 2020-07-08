using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileOrnek2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int tutulan = rnd.Next(1, 6);
            Console.WriteLine("1 ile 6 arasında sayı tutunuz");

            int girilen = 0;
            int hak = 5;

            do
            {
                if(hak!=0)
                {
                    Console.Write("{0}.tahmini giriniz Giriniz:", hak);
                    girilen = Convert.ToInt32(Console.ReadLine());

                    if (girilen < tutulan)
                    {
                        if (hak!=1)
                        {
                            Console.WriteLine("Daha büyük bir sayı yaızınız");
                        }
                        
                    }
                    else if (girilen > tutulan)
                    {
                        if (hak!=1)
                        {
                            Console.WriteLine("Daha küçük bir sayı giriniz");
                        }
                        
                    }

                    hak--;
                }

            } while (tutulan != girilen & hak != 0);
            if (girilen != tutulan && hak == 0)
            {
                Console.Write("Hakkınız bitmiştir.Tutulan sayı: {0}",tutulan);
            }
            else
            {
                Console.Write("Tebrikler bildiniz");
            }

            Console.ReadLine();
        }
    }
}
