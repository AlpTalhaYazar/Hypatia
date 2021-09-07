using System;

namespace _02_Introduction
{
    class Program
    {
        static void Main(string[] args)
        {
            string tempInp = "";
            int numInp = 0, sum = 0;
            bool check = false;

            Console.WriteLine("Toplanmasini istediginiz sayilari giriniz!");

            do
            {
                tempInp = Console.ReadLine();
                check = int.TryParse(tempInp, out numInp);
                if (!check)
                {
                    Console.WriteLine("Lutfen girdinizi kontrol ediniz. Sadece sayi girisi yapiniz.");
                }
                else
                    sum += numInp;
            } while (tempInp != "tamam");

            Console.Write($"Toplam : {sum}");

            Console.ReadKey();
        }
    }
}
