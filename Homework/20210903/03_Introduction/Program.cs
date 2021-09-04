using System;

namespace _03_Introduction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lutfen dort basamakli sayiyi giriniz : ");

            bool check = Int32.TryParse(Console.ReadLine(), out int x);
            bool check4digit = (x / 1000 > 0) && (x / 10000 == 0);


            int a = x % 10;             //birler basamagi
            int b = (x % 100) / 10;     //onlar basamagi
            int c = (x % 1000) / 100;   //yuzler basamagi
            int d = x / 1000;           //binler basamagi

            if (x <= 9999 && x >= 1000)
            {
                Console.WriteLine($"{a} x 1 = {a}");
                Console.WriteLine($"{b} x 10 = {b * 10}");
                Console.WriteLine($"{c} x 100 = {c * 100}");
                Console.WriteLine($"{d} x 1000 = {d * 1000}");
            }
            else if (!check4digit || !check)
            {
                Console.Write("Uyari! Lutfen dort basamakli bir sayi girisi yapiniz!");
            }

            Console.ReadKey();
        }
    }
}
