using System;

namespace _06_Introduction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Birinci urunun fiyatini giriniz : ");
            double urun1fiyat = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ikinci urunun fiyatini giriniz : ");
            double urun2fiyat = Convert.ToDouble(Console.ReadLine());

            Console.Write($"Toplam tutar : {urun1fiyat + urun2fiyat}");

            if (urun1fiyat + urun2fiyat > 200)
            {
                urun2fiyat = (urun2fiyat - (urun2fiyat * 0.25));
                Console.Write($"\nIndirim sonucu tutar : {urun1fiyat + urun2fiyat}");
            }



            Console.ReadKey();
        }
    }
}
