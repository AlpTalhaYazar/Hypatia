using _03_OOP.Derived;
using System;

namespace _03_OOP
{
    public class School
    {
        protected string UserName { get; set; }
        protected string Password { get; set; }
        public byte AuthLevel { get; internal set; }
        public string Name { get; set; }

        protected School(string userName, string password, string name)
        {
            this.UserName = userName;
            this.Password = password;
            this.Name = name;

            Console.WriteLine($"Yeni kayit olusturuldu.");
        }

        public static byte Login(Educator[] educators, Student[] students, string userName, string password)
        {
            for (int i = 0; i < educators.Length; i++)
            {
                if (educators[i].UserName != userName)
                {
                    if (students[i].UserName == userName)
                    {
                        if (students[i].Password == password)
                        {
                            Console.WriteLine($"Tebrikler basarili bir sekilde giris yaptiniz! Hosegeldiniz {students[i].Name}");
                            return students[i].AuthLevel;
                        }
                        else
                        {
                            Console.WriteLine("Sifre hatali");
                            continue;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Girdiginiz bilgiler hatali");
                        continue;
                    }


                }
                else
                {
                    if (educators[i].Password == password)
                    {
                        Console.WriteLine($"Tebrikler basarili bir sekilde giris yaptiniz! Hosegeldiniz {educators[i].Name} bey");
                        return educators[i].AuthLevel;
                    }
                    else
                    {
                        Console.WriteLine("Sifre hatali");
                        continue;
                    }
                }
            }
            return 0;
        }
    }
}
