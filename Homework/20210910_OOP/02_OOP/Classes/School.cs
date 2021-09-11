using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP.Classes
{
    class School
    {
        private string UserName { get; set; }
        private string Password { get; set; }
        public byte AuthLevel { get; set; }
        public string Name { get; set; }

        public School()
        {
            Console.WriteLine($"Sisteme kaydiniz olusturulmustur, Sayin {Name}");
        }

        protected void Login(string userName, string password)
        {
            if (this.UserName != userName)
                Console.WriteLine("Kullanici adi hatali!");
            if (this.Password != password)
                Console.WriteLine("Sifre hatali!");
        }
    }
}
