using System;

namespace _02_Introduction
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            Console.WriteLine("Birinci sayiyi giriniz");
            bool a = int.TryParse(Console.ReadLine(), out int x);
            Console.WriteLine("Ikinci sayiyi giriniz");
            bool b = int.TryParse(Console.ReadLine(), out int y);


            if (!a || !b)
            {
                Console.Write("Lutfen Girdilerinizi kontrol ediniz.");
            }
            else
            {
                int sayi1 = rnd.Next(x, y);
                int sayi2 = rnd.Next(x, y);

                Console.WriteLine($"Birinci sayi arti ikinci sayi = {sayi1 + sayi2}");
                Console.WriteLine($"Birinci sayi eksi ikinci sayi = {sayi1 - sayi2}");
                Console.WriteLine($"Birinci sayi carpi ikinci sayi = {sayi1 * sayi2}");
                Console.WriteLine($"Birinci sayi bolu ikinci sayi = {(sayi1 / (double)sayi2)}");
            }

            Console.ReadKey();

        }
    }
}
