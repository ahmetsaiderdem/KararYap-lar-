using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] karakterler = { 'A', '5', 'f' };

            foreach (char item in karakterler)
            {

            }


            Console.Write(" Kaç isim girilecek :");
            int boyut = Convert.ToInt32(Console.ReadLine());
            string[] isimler = new string[boyut];

            for (int i = 0; i < isimler.Length; i++)
            {
                Console.Write(" {0}. ismi giriniz :",i+1);
                isimler[i] = Console.ReadLine();
            }
            Console.Write("aranacak isim :");
            string aranacak = Console.ReadLine();
            int sayac = 0;
            
           
            foreach (string eleman in isimler)
            {
                if (eleman == aranacak)
                {                                  
                        sayac++;                  
                }
              
                

            }
            Console.WriteLine("{0} isminden listede {1} tane vardır", aranacak, sayac);
            Console.ReadLine();
        }
    }
}
