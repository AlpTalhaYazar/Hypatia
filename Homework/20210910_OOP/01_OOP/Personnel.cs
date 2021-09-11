using System;

namespace _01_OOP
{
    class Personnel
    {
        private string _firstName;
        public string FirstName     //Property uzerinden instance  yapildiktan sonra yeni deger set kontrolu 
        {
            get { return _firstName; }
            set { CommonSet(value, ref _firstName); }
        }

        private string _middleName;
        public string MiddleName
        {
            get { return _middleName; }
            set
            {
                if ((value.Length <= 6 && value.Length >= 3) || value.Length == 0)
                {
                    _middleName = value;
                    Console.WriteLine("Yeni isim basariyla kaydedilmistir!");
                }
            }
        }

        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set { CommonSet(value, ref _lastName); }
        }

        internal Personnel(string firstName, string middleName, string lastName)
        {
            _firstName = firstName;
            _middleName = middleName;
            _lastName = lastName;
        }

        public static Personnel CreateInstance(string firstName, string middleName, string lastName)
        {
            if (firstName != "" && lastName != "" && ((middleName.Length <= 6 && middleName.Length >= 3) || middleName.Length == 0))
            {
                Console.WriteLine("Kisi basariyla kaydedilmistir!");
                return new Personnel(firstName, middleName, lastName);
            }
            Console.WriteLine("Hatali giris yaptiniz! Kisi kaydedilmemistir!!!");
            return null;
        }

        protected void CommonSet(string nameValue, ref string _nameValue)
        {
            if (nameValue.Length < 1)
            {
                Console.WriteLine("Hatali giris! Isim Kaydedilememistir!");
                return;
            }
            else
            {
                _nameValue = nameValue;
                Console.WriteLine("Yeni isim basariyla kaydedilmistir!");
            }
        }
    }
}
