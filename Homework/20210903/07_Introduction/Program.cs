using System;

namespace _07_Introduction
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            string champ1Name = "";
            //champ1Name += ((char)(rnd.Next(65, 90))).ToString();
            //champ1Name += ((char)(rnd.Next(65, 90))).ToString();
            //champ1Name += ((char)(rnd.Next(65, 90))).ToString();
            //champ1Name += ((char)(rnd.Next(65, 90))).ToString();
            //champ1Name += ((char)(rnd.Next(65, 90))).ToString();

            int i1 = rnd.Next(5, 15);
            int j1;

        dongu1:
            if (i1 >= 0)
            {
                j1 = rnd.Next(2);
                if (j1 == 0)
                {
                    champ1Name += ((char)(rnd.Next(65, 91))).ToString();
                }
                else
                {
                    champ1Name += ((char)(rnd.Next(97, 123))).ToString();
                }
                i1--;
                goto dongu1;
            }

            string champ2Name = "";
            //champ2Name += ((char)(rnd.Next(65, 90))).ToString();
            //champ2Name += ((char)(rnd.Next(65, 90))).ToString();
            //champ2Name += ((char)(rnd.Next(65, 90))).ToString();
            //champ2Name += ((char)(rnd.Next(65, 90))).ToString();
            //champ2Name += ((char)(rnd.Next(65, 90))).ToString();

            int i2 = rnd.Next(5, 15);
            int j2;

        dongu2:
            if (i2 >= 0)
            {
                j2 = rnd.Next(2);
                if (j2 == 0)
                {
                    champ2Name += ((char)(rnd.Next(65, 91))).ToString();
                }
                else
                {
                    champ2Name += ((char)(rnd.Next(97, 123))).ToString();
                }
                i2--;
                goto dongu2;
            }

            DateTime champBDate = new DateTime();

            champBDate = champBDate.AddDays(rnd.Next((DateTime.Today - champBDate).Days));


            Console.WriteLine($"Merhaba ben {champ1Name} {champ2Name}. {champBDate.ToString("dd.MM.yyyy")} tarihinde dünyaya geldim.");
            Console.ReadKey();
        }
    }
}
