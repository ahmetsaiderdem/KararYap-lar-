using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEachOrnek
{
    class Program
    {
        static void Main(string[] args)
        {

            int adet = 0;
            string[] isimler = new string[0];
            do
            {
                Console.Write("Kaç isim girilecek:");
                adet = Convert.ToInt32(Console.ReadLine());
                if (adet % 2 == 0)
                {
                    isimler = new string[adet];
                }
                else
                {
                    Console.WriteLine("Lütfen çift sayı giriniz");
                }

            } while (adet % 2 != 0);
            for (int i = 0; i < isimler.Length; i++)
            {
                //Contains methodu kullanılmadan yapılabilir mi?
                Console.Write("{0}. ismi giriniz:", i + 1);
                string isim = Console.ReadLine();
                if (isimler.Contains(isim) == true)
                {
                    i--;
                    Console.WriteLine("{0} İsmi zaten bulunmaktadır", isim);
                }
                else
                {
                    isimler[i] = isim;
                }
            }
            string[] aTakimi = new string[isimler.Length/2];
            string[] bTakimi = new string[isimler.Length/2];
            Random rnd = new Random();

            for (int i = 0; i < isimler.Length/2; i++)
            {
                string isim =isimler[ rnd.Next(0,isimler.Length)];
                if (aTakimi.Contains(isim)==true)
                {
                    i--;
                }
                else
                {
                    aTakimi[i] = isim;
                }
                
            }
            for (int i = 0; i < isimler.Length/2; i++)
            {
                string isim = isimler[rnd.Next(0, isimler.Length)];
                if (aTakimi.Contains(isim)==false && bTakimi.Contains(isim)==false)
                {
                    bTakimi[i] = isim;
                }
                else
                {
                    i--;
                }
            }
            Console.WriteLine("A Takımı :");
            foreach (string a in aTakimi)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("B Takımı :");
            foreach (string b in bTakimi)
            {
                Console.WriteLine();
            }

            Console.ReadLine();
        }

    }
}
