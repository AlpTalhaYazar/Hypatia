using System;

namespace _05_Introduction
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dizi elemanlarinin integer deger olacaklari baza alinmistir.
            int n = 0;
            bool check1, check2 = false;

            Console.Write("Kac adet eleman girmek istersiniz? ");
            check1 = int.TryParse(Console.ReadLine(), out n);

            int[] dataSeries = new int[n];

            if (!check1) //Array buyuklugunun dogru belirlendigine emin oluyoruz.
            {
                Console.Write("Lutfen numerik bir deger giriniz!");
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"{i + 1}. Eleman : ");
                    check2 = int.TryParse(Console.ReadLine(), out dataSeries[i]);

                    if (!check2)    //Dizi elemanlarinin integer deger olacaklari baza alindigi icin.
                    {
                        Console.WriteLine("Lutfen numerik bir deger giriniz!");
                        i--;
                    }
                }
                for (int i = 0; i < n; i += 2)
                {
                    Console.Write((dataSeries[i].ToString()).PadRight(10));

                    if (!(i == n - 1))
                        Console.WriteLine(dataSeries[i + 1]);
                }
            }

            Console.ReadKey();
        }
    }
}

