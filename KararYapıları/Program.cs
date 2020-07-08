using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KararYapıları
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("1.Sayıyı girinizi:");
            int s1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2.Sayıyı giriniz:");
            int s2 = Convert.ToInt32(Console.ReadLine());

            if (s1 > s2)
            {
                Console.Write("{0} sayısı {1} sayısından büyüktür", s1, s2);
            }
            else if(s2>s1)
            {
                Console.Write("{0} sayısı {1} sayısından küçüktür", s2, s1);
            }
            else
            {
                Console.Write("sayılar eşittir");
            }
           
              
            Console.ReadLine();
        }
    }
}
