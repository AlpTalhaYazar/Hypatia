using System;

namespace _07_Introduction
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            string champ1Name = "";
            champ1Name += ((char)(rnd.Next(65, 90))).ToString();
            champ1Name += ((char)(rnd.Next(65, 90))).ToString();
            champ1Name += ((char)(rnd.Next(65, 90))).ToString();
            champ1Name += ((char)(rnd.Next(65, 90))).ToString();
            champ1Name += ((char)(rnd.Next(65, 90))).ToString();
            string champ2Name = "";
            champ2Name += ((char)(rnd.Next(65, 90))).ToString();
            champ2Name += ((char)(rnd.Next(65, 90))).ToString();
            champ2Name += ((char)(rnd.Next(65, 90))).ToString();
            champ2Name += ((char)(rnd.Next(65, 90))).ToString();
            champ2Name += ((char)(rnd.Next(65, 90))).ToString();

            DateTime champBDate = new DateTime();

            champBDate = champBDate.AddDays(rnd.Next((DateTime.Today - champBDate).Days));


            Console.WriteLine($"Merhaba ben {champ1Name} {champ2Name}. {champBDate.ToString("dd.MM.yyyy")} tarihinde dünyaya geldim.");
            Console.ReadKey();
        }
    }
}
