using System;

namespace _01_Introduction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Birinci sayiyi giriniz");
            bool a = double.TryParse(Console.ReadLine(), out double x);
            Console.WriteLine("Ikinci sayiyi giriniz");
            bool b = double.TryParse(Console.ReadLine(), out double y);

            if (!a || !b)
            {
                Console.Write("Lutfen girdiginiz degerleri kontrol ediniz.");
            }
            else
            {
                if (y % x == 0)
                {
                    Console.Write($"Ikinci sayi, birinci sayinin {(y / x)} katidir.");
                }
                else
                {
                    Console.Write("Ikinci sayi, birinci sayinin tam kati degildir.");
                }
            }

            Console.ReadKey();
        }
    }
}
