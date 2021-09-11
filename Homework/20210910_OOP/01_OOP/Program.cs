using System;

namespace _01_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            string FirstName;
            string MiddleName;
            string LastName;

            Console.Write("What is First Name? ");
            FirstName = Console.ReadLine();

            Console.Write("What is Middle Name?");
            MiddleName = Console.ReadLine();

            Console.Write("What is Last Name?");
            LastName = Console.ReadLine();

            Personnel personnel = Personnel.CreateInstance(FirstName, MiddleName, LastName);

            personnel.FirstName = "";
            Console.WriteLine(personnel.FirstName);
            personnel.FirstName = "b";
            Console.Write(personnel.FirstName);

            Console.ReadKey();
        }
    }
}
