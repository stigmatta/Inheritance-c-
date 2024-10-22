using System.Text.RegularExpressions;

namespace PersonClass
{
    internal class Person
    {
        static string NamePattern = @"^[A-Za-z]+$";
        static string PhonePattern = @"^\d{12}$";
        private string name,surname,phoneNumber;
        private int age;

        public string Name { get { return name; }
            set {
                try
                {
                    if (string.IsNullOrEmpty(value) || Regex.IsMatch(value, NamePattern) == false)
                        throw new ArgumentException("Формат имени неверен");
                    else
                        name = value;
                }catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } 
        }
        public string Surname
        {
            get { return surname; }
            set
            {
                try
                {
                    if (string.IsNullOrEmpty(value) || Regex.IsMatch(value, NamePattern) == false)
                        throw new ArgumentException("Формат фамилии неверен");
                    else
                        surname = value;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set
            {
                try
                {
                    if (Regex.IsMatch(value, PhonePattern))
                        phoneNumber = value;
                    else
                        throw new ArgumentException("Формат номера телефона неверен");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                try
                {
                    if (value > 0 && value < 120)
                        age = value;
                    else
                        throw new ArgumentException("Формат возраста неверен");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public Person() : this("John", "Doe", "000000000000", 18) { }
        public Person(string name,string surname,string phoneNumber,int age)
        {
            Name = name;
            Surname = surname;
            PhoneNumber = phoneNumber;
            Age = age;  
        }

        public void Print()
        {
            Console.WriteLine("Name - {0}\nSurname - {1}\nPhone number - {2}\nAge - {3}",Name,Surname,PhoneNumber,Age);
        }
    }
}
