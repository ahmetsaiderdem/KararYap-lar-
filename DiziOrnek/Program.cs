using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiziOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("dizinin boyutunu belirleyiniz : ");
            int boyut = Convert.ToInt32(Console.ReadLine());

            string[] isimler = new string[boyut];

            for (int i = 0; i < isimler.Length; i++)
            {

                Console.Write("{0}. isimi giriniz: ", i + 1);
                isimler[i] = Console.ReadLine();


            }
            Console.Write("Hangi ismi arıyorsunuz:");
            string aranan = Console.ReadLine();
            //Burada nasıl işlediğini sor
            int sayac = 0;
            for (int i = 0; i < isimler.Length; i++)
            {
                if (isimler[i] == aranan)
                {
                    sayac++;

                }
            }
            Console.Write("{0} isminden listede {1} tane vardır", aranan, sayac);

            Console.ReadLine();


        }
    }
}
