using _03_OOP;
using _03_OOP.Derived;
using System;

namespace trial
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[5];            // 
            students[0] = new Student("a", "0", "f0");      // 
            students[1] = new Student("b", "1", "f1");      // Kucuk bir database
            students[2] = new Student("c", "2", "f2");      // 
            students[3] = new Student("d", "3", "f3");      // 
            students[4] = new Student("e", "4", "f4");      // 
                                                            //
            Educator[] educators = new Educator[5];         // 
            educators[0] = new Educator("f", "5", "f5");    // 
            educators[1] = new Educator("g", "6", "f6");    // 
            educators[2] = new Educator("h", "7", "f7");    // 
            educators[3] = new Educator("i", "8", "f8");    // 
            educators[4] = new Educator("j", "9", "f9");    // 
                                                            // 
            Lecture[] lectures = new Lecture[10];           // 
            Homework[] homeworks = new Homework[10];        // 

            lectures[0] = new Lecture("Math", 6, 0, 0);
            lectures[1] = new Lecture("Bio", 4, 0, 1);
            lectures[2] = new Lecture("Art", 6, 0, 2);
            lectures[3] = new Lecture("Physics", 5, 0, 3);



            string UserName;
            string Password;

            byte CurrentAuthLevel;


            Console.WriteLine("Kullanici adi Giriniz");
            UserName = Console.ReadLine();
            Console.WriteLine("Sifre adi Giriniz");
            Password = Console.ReadLine();

            CurrentAuthLevel = School.Login(educators, students, UserName, Password); // auth duzgun calismiyor

            Console.ReadKey();
        }

    }
}
