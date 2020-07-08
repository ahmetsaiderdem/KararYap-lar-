using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Mevsim giriniz:");
            

            switch (Console.ReadLine())
            {
                case "yaz": Console.Write("haziran-temmuz-ağurstos"); break;
                case "kış": Console.Write("aralık-ocak-şubat"); break;
                case "sonbahar": Console.Write("eylül-ekim-kasım"); break;
                case "ilkbahar": Console.Write("mart-nisan-mayıs"); break;
                default: Console.Write("girilen değer yanlıştır lütfen mevsim giriniz"); break;
            }
            Console.ReadLine();
        }
    }
}
