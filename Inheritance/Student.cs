namespace PersonClass
{
    internal class Student : Person
    {
        double average;
        int number_of_group;
        
        public double Average
        {
            get { return average; }
            set {
                try
                {
                    if (value > 0 && value < 12)
                        average = value;
                    else
                        throw new ArgumentException("Формат среднего балла неверен");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public int NumberOfGroup
        {
            get { return number_of_group;}
            set
            {
                try
                {
                    if (value > 0)
                        number_of_group = value;
                    else
                        throw new ArgumentException("Формат номера группы неверен");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }



        public Student(string name, string surname, string phoneNumber, int age,double average,int number_of_group):base(name,surname,phoneNumber,age)
        {
            Average = average;
            NumberOfGroup = number_of_group;
        }

        public Student() : base()
        {
            Average =(double)0.1;
            NumberOfGroup = 1;
        }

        new public void Print()
        {
            base.Print();
            Console.WriteLine("Average score - {0}\nNumber of group - {1}\n\n",Average,NumberOfGroup);
        }

    }
}
