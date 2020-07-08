using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[10];
            int[] sayilar = new int[5];

            isimler[4] = "Ahmet";
            sayilar[0] = 4;

            char[] karakterler = { 'A', 'b', '?', '4' };

            Array.Resize(ref karakterler, 6);

            int boyut = isimler.Length;
            Array.Resize(ref isimler, isimler.Length + 1);
        }   
    }
}
