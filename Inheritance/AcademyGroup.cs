using PersonClass;

namespace AcademyGroupClass
{
    internal class AcademyGroup
    {
        Student[] arr;
        int count;
        public AcademyGroup()
        {
            arr = new Student[0];
            count = 0;
        }

        public AcademyGroup(Student[] arr)
        {
            this.arr = arr;
            this.count = arr.Length;
        }

        public void Add(Student student)
        {
            Array.Resize(ref arr, ++count);
            arr[count-1] = student;
        }

        public void Remove(string surname)
        {
            int indexToRemove = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Surname == surname)
                {
                    indexToRemove = i;
                    break;
                }
            }

            if (indexToRemove == -1)
            {
                Console.WriteLine("Такого студента не найдено.");
                return;
            }


            for (int i = indexToRemove; i < arr.Length; i++)
            {
                if (i + 1 < arr.Length)
                    arr[i] = arr[i + 1];
            }

            Array.Resize(ref arr, arr.Length - 1);

        }

        public void Edit(string surname)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Surname == surname)
                {
                    Console.WriteLine("Что хотите изменить?");
                    Console.WriteLine("1 - имя");
                    Console.WriteLine("2 - фамилия");
                    Console.WriteLine("3 - возраст");
                    Console.WriteLine("4 - номер телефона");
                    Console.WriteLine("5 - средняя оценка");
                    Console.WriteLine("6 - номер группы");

                    int choice = 0;
                    while (true)
                    {
                        Console.WriteLine("Выберите опцию (1-6):");
                        try
                        {
                            choice = int.Parse(Console.ReadLine());
                            if (choice >= 1 && choice <= 6)
                                break;
                            else
                                Console.WriteLine("Некорректный выбор. Попробуйте снова.");
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Некорректный ввод. Введите число от 1 до 6.");
                        }
                    }

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Введите новое имя:");
                            arr[i].Name = Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("Введите новую фамилию:");
                            arr[i].Surname = Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("Введите новый возраст:");
                            arr[i].Age = int.Parse(Console.ReadLine());
                            break;
                        case 4:
                            Console.WriteLine("Введите новый номер телефона:");
                            arr[i].PhoneNumber = Console.ReadLine();
                            break;
                        case 5:
                            Console.WriteLine("Введите новую среднюю оценку:");
                            arr[i].Average = double.Parse(Console.ReadLine());
                            break;
                        case 6:
                            Console.WriteLine("Введите новый номер группы:");
                            arr[i].NumberOfGroup = int.Parse(Console.ReadLine());
                            break;
                        default:
                            Console.WriteLine("Неверный выбор.");
                            break;
                    }

                    Console.WriteLine("Изменения сохранены.");
                    break; 
                }
            }
        }


        public void Print()
        {
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i].Print();
            }
        }

        public void Save()
        {
            Console.WriteLine("Данные сохранены в файл");
        }

        public void Load()
        {
            Console.WriteLine("Данные загружены в файл");
        }

        public void Search()
        {
            Console.WriteLine("Критерий поиска:");
            Console.WriteLine("1 - имя");
            Console.WriteLine("2 - фамилия");
            Console.WriteLine("3 - возраст");
            Console.WriteLine("4 - номер телефона");
            Console.WriteLine("5 - средняя оценка");
            Console.WriteLine("6 - номер группы");

            int choice = 0;
            while (true)
            {
                Console.WriteLine("Выберите опцию (1-6):");
                try
                {
                    choice = int.Parse(Console.ReadLine());
                    if (choice >= 1 && choice <= 6)
                        break;
                    else
                        Console.WriteLine("Некорректный выбор. Попробуйте снова.");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Некорректный ввод. Введите число от 1 до 6.");
                }
            }

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Введите имя для поиска:");
                    string name = Console.ReadLine();
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (arr[i].Name.Equals(name))
                        {
                            Console.WriteLine("Студент найден:");
                            arr[i].Print();
                            break;
                        }
                    }
                    break;

                case 2:
                    Console.WriteLine("Введите фамилию для поиска:");
                    string surname = Console.ReadLine();
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (arr[i].Surname.Equals(surname))
                        {
                            Console.WriteLine("Студент найден:");
                            arr[i].Print();
                            break;
                        }
                    }
                    break;

                case 3:
                    Console.WriteLine("Введите возраст для поиска:");
                    if (int.TryParse(Console.ReadLine(), out int age))
                    {
                        for (int i = 0; i < arr.Length; i++)
                        {
                            if (arr[i].Age == age)
                            {
                                Console.WriteLine("Студент найден:");
                                arr[i].Print();
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Некорректный возраст.");
                    }
                    break;

                case 4:
                    Console.WriteLine("Введите номер телефона для поиска:");
                    string phone = Console.ReadLine();
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (arr[i].PhoneNumber.Equals(phone))
                        {
                            Console.WriteLine("Студент найден:");
                            arr[i].Print();
                            break;
                        }
                    }
                    break;

                case 5:
                    Console.WriteLine("Введите среднюю оценку для поиска:");
                    if (double.TryParse(Console.ReadLine(), out double average))
                    {
                        for (int i = 0; i < arr.Length; i++)
                        {
                            if (arr[i].Average == average)
                            {
                                Console.WriteLine("Студент найден:");
                                arr[i].Print();
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Некорректная средняя оценка.");
                    }
                    break;

                case 6:
                    Console.WriteLine("Введите номер группы для поиска:");
                    if (int.TryParse(Console.ReadLine(), out int group))
                    {
                        for (int i = 0; i < arr.Length; i++)
                        {
                            if (arr[i].NumberOfGroup == group)
                            {
                                Console.WriteLine("Студент найден:");
                                arr[i].Print();
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Некорректный номер группы.");
                    }
                    break;

                default:
                    Console.WriteLine("Некорректный выбор.");
                    break;
            }
        }
    }
}
