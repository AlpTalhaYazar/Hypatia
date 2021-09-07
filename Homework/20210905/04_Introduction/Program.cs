using System;
using System.Globalization;

namespace _04_Introduction
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = new CultureInfo("en-EN", false);

            Console.WriteLine("Metin giriniz.");
            string textInp = Console.ReadLine();
            string finalText = "";

            //for (int i = 0; i < textInp.Length; i++)
            //{
            //    if ((i % 2) == 0)
            //    {
            //        finalText += char.ToLower(textInp[i], new CultureInfo("en-EN", false));
            //    }
            //    else
            //    {
            //        finalText += char.ToUpper(textInp[i], new CultureInfo("en-EN", false));
            //    }
            //}

            for (int i = 0; i < textInp.Length; i++)
            {
                if ((i % 2) == 0)
                {
                    if (textInp[i] >= 'A' && textInp[i] <= 'Z')
                    {
                        finalText += (char)(textInp[i] + 32);
                    }
                    else
                        finalText += textInp[i];
                }
                else
                {
                    if (textInp[i] >= 'a' && textInp[i] <= 'z')
                    {
                        finalText += (char)(textInp[i] - 32);
                    }
                    else
                        finalText += textInp[i];
                }
            }

            Console.Write(finalText);

            Console.ReadKey();
        }
    }
}
