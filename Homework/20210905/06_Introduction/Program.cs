using System;

namespace _06_Introduction
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://www.millipiyangoonline.com/sayisal-loto/kurallar
            //Joker sayisinin kurallardan cikarildigi baza allinmistir!!!

            Random rnd = new Random();

            bool check = false;
            int tutanKolon = 0;
            int[] lotoResult = new int[6];
            int[] lotoUser = new int[6];

            Console.WriteLine("Kolonlara gireceginiz sayilar 1 ila 90 arasinda olmak zorundalar! Iyi Sanslar!");

            for (int i = 0; i < 6; i++)
            {
                Console.Write($"{i + 1}. kolonu giriniz : ");
                check = int.TryParse(Console.ReadLine(), out lotoUser[i]);

                if (!check)
                {
                    Console.WriteLine("Lutfen girdiginiz degeri kontrol edip tekrar deneyiniz!");
                    i--;
                }

            }
            for (int i = 0; i < 6; i++)
            {
                lotoResult[i] = rnd.Next(1, 91);
                Console.WriteLine(lotoResult[i]);
                if (lotoUser[i] == lotoResult[i])
                    tutanKolon++;
            }
            int number = 9;
            Console.Write($"Oynadiginiz kolonlardan {tutanKolon} tanesi tuttu. {(tutanKolon >= 1 ? "Bir daha deneyiniz." : "Ikramiye Kazandiniz, Tebrikler!!!")}");

            Console.ReadKey();
        }
    }
}
