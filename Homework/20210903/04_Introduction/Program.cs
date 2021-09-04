using System;
using System.Globalization;

namespace _04_Introduction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lutfen dogum tarihinizi ay/gun/yil olacak sekilde giriniz : ");

            bool check = DateTime.TryParseExact(Console.ReadLine(), "MM/dd/yyyy", null, DateTimeStyles.None, out DateTime x);

            int now = int.Parse(DateTime.Now.ToString("yyyyMMdd")); //Buyukten kucuge tarih formati
            int birthDate = int.Parse(x.ToString("yyyyMMdd"));
            int difference = now - birthDate;

            if (!check)
            {
                Console.Write("Uyari! Lutfen tarihi formata uygun giriniz!");
            }
            else
            {
                if (difference < 0)
                {
                    Console.Write("18 yasindan kucuksunuz!");
                }
                else if ((difference == 0) || (difference % 10000) == 0)
                {
                    Console.Write("Dogum gununuz kutlu olsun!");
                }
                else
                {
                    Console.Write("Dogum gununuz gecmis");
                }
            }

            Console.ReadKey();
        }
    }
}
