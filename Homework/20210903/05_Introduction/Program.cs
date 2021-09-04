using System;
using System.Linq;

namespace _05_Introduction
{
    class Program
    {
        //static string findMax(int x)
        //{
        //    string[] personName = new string[x];
        //    int[] personAge = new int[x];

        //    for (int i = 0; i < x; i++)
        //    {
        //        Console.Write($"{i + 1}. kisinin adini giriniz : ");
        //        personName[i] = Console.ReadLine();
        //        Console.Write($"{i + 1}. kisinin yasini giriniz : ");
        //        personAge[i] = int.Parse(Console.ReadLine());
        //    }

        //    int maxIndex = Array.FindIndex(personAge, x => x.Equals(personAge.Max()));

        //    return (personName[maxIndex]);
        //}
        static void Main(string[] args)
        {
            //Console.WriteLine("Kac kisiyi karsilastirmak istersiniz?");
            //int x = int.Parse(Console.ReadLine());
            //Console.Write($"En Yasli kisi { findMax(x)}.");

            Console.Write("Birinci kisinin adini giriniz : ");
            string person1Name = Console.ReadLine();
            Console.Write("Birinci kisinin yasini giriniz : ");
            bool check1 = int.TryParse(Console.ReadLine(), out int person1Age);

            Console.Write("Ikinci kisinin adini giriniz : ");
            string person2Name = Console.ReadLine();
            Console.Write("Ikinci kisinin yasini giriniz : ");
            bool check2 = int.TryParse(Console.ReadLine(), out int person2Age);

            Console.Write("Ucuncu kisinin adini giriniz : ");
            string person3Name = Console.ReadLine();
            Console.Write("Ucuncu kisinin yasini giriniz : ");
            bool check3 = int.TryParse(Console.ReadLine(), out int person3Age);

            if (!check1 || !check2 || !check3)
            {
                Console.Write("Lutfen yas bilgilerini dogru giriniz.");
            }
            else
            { 
                Console.Write(enbuyuk()); 
            }

            string enbuyuk()
            {
                if (person1Age > person2Age)
                {
                    if (person1Age == person3Age)
                    {
                        return ($"{person1Name} ve {person3Name} yaslari esit ve {person2Name} adli kisiden buyuk.");
                    }
                    if (person1Age > person3Age)
                    {
                        return ($"{person1Name} en buyuk");
                    }
                    else
                    {
                        return ($"{person3Name} en buyuk");
                    }
                }
                else
                {
                    if (person1Age == person2Age)
                    {
                        if (person1Age == person3Age)
                        {
                            return ("Hepsinin yasi esit.");
                        }
                        else
                        {
                            return ($"{person1Name} ve {person2Name} yaslari esit ve {person3Name} adli kisiden buyuk.");
                        }
                    }
                    if (person2Age > person3Age)
                    {
                        return ($"{person2Name} en buyuk");
                    }
                    if (person2Age == person3Age)
                    {
                        return ($"{person2Name} ve {person3Name} yaslari esit ve {person1Name} adli kisiden buyuk.");
                    }
                    else
                    {
                        return ($"{person3Name} en buyuk");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}