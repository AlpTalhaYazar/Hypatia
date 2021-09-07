using System;

namespace _07_Introduction
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrMax = 0, arrMin = 0, actualVal = 0;
            string tempInp;
            bool check = false;

            Console.WriteLine("Girmek istediginiz sayilari asagida belirtiniz.");
            do
            {
                tempInp = Console.ReadLine();

                if (tempInp != "exit" && tempInp != "end")
                {
                    check = int.TryParse(tempInp, out actualVal);

                    if (!check)
                    {
                        Console.WriteLine("Lutfen girdiginiz deger uygun formatta bir sayi degeri olsun!");
                        continue;
                    }
                    arrMax = (actualVal > arrMax) ? actualVal : arrMax;//else if (actualVal > arrMax) arrMax = actualVal;
                    arrMin = (actualVal < arrMin) ? actualVal : arrMin;//else if (actualVal < arrMin) arrMin = actualVal;
                }
                else if (tempInp == "end")
                {
                    Console.Clear();
                    Console.WriteLine($"En buyuk sayi : {arrMax}, En kucuk sayi : {arrMin}.\nYeni sayi girisi bekleniyor.");
                    arrMax = 0;
                    arrMin = 0;
                }
            } while (tempInp != "exit");
            Console.ReadKey();
        }
    }
}