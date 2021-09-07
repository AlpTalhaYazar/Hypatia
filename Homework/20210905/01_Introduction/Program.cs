using System;

namespace _01_Introduction
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            byte[] dice = new byte[1000];

            for (int i = 0; i < 1000; i++)
            {
                dice[i] = (byte)(rnd.Next(1, 7));
            }

            //Console.WriteLine($"1 sayisi {(Array.FindAll(dice, x => x == 1)).Length} kere gelmistir.\n2 sayisi {(Array.FindAll(dice, x => x == 2)).Length} kere gelmistir.\n3 sayisi {(Array.FindAll(dice, x => x == 3)).Length} kere gelmistir.\n4 sayisi {(Array.FindAll(dice, x => x == 4)).Length} kere gelmistir.\n5 sayisi {(Array.FindAll(dice, x => x == 5)).Length} kere gelmistir.\n6 sayisi {(Array.FindAll(dice, x => x == 6)).Length} kere gelmistir.");
            //Kod okunurlugunu arttirmak adina tercih edilmemistir.

            int length1 = (Array.FindAll(dice, x => x == 1)).Length;
            int length2 = (Array.FindAll(dice, x => x == 2)).Length;
            int length3 = (Array.FindAll(dice, x => x == 3)).Length;
            int length4 = (Array.FindAll(dice, x => x == 4)).Length;
            int length5 = (Array.FindAll(dice, x => x == 5)).Length;
            int length6 = (Array.FindAll(dice, x => x == 6)).Length;

            Console.WriteLine($"1 sayisi {length1} kere gelmistir.\n2 sayisi {length2} kere gelmistir.\n3 sayisi {length3} kere gelmistir.\n4 sayisi {length4} kere gelmistir.\n5 sayisi {length5} kere gelmistir.\n6 sayisi {length6} kere gelmistir.");

            Console.ReadKey();
        }
    }
}
