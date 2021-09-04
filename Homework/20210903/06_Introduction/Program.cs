using System;

namespace _06_Introduction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Birinci urunun fiyatini giriniz : ");
            bool a = double.TryParse(Console.ReadLine(), out double urun1fiyat);
            Console.Write("Ikinci urunun fiyatini giriniz : ");
            bool b = double.TryParse(Console.ReadLine(), out double urun2fiyat);


            if (!a && !b)
            {
                Console.Write("Lutfen girdiginiz degerleri kontrol ediniz.");
            }
            else
            {
                Console.Write($"Toplam tutar : {urun1fiyat + urun2fiyat}");

                if (urun1fiyat + urun2fiyat > 200)
                {
                    urun2fiyat = (urun2fiyat - (urun2fiyat * 0.25));
                    Console.Write($"\nIndirim sonucu tutar : {urun1fiyat + urun2fiyat}");
                }
            }


            Console.ReadKey();
        }
    }
}
