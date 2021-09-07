using System;

namespace _03_Introduction
{
    class Program
    {
        static void Main(string[] args)
        {
            int intAmount = 0;

            Console.WriteLine("Metin giriniz.");
            string textInp = Console.ReadLine();

            for (int i = 0; i < textInp.Length; i++)
            {
                if (Char.IsDigit(textInp[i]))
                    intAmount++;
            }

            Console.Write($"Girdiginiz metnin icinde {intAmount} adet sayi bulunmaktadir.");

            Console.ReadKey();
        }
    }
}