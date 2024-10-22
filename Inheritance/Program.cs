using AcademyGroupClass;
using PersonClass;

AcademyGroup group = new AcademyGroup();

group.Add(new Student { Name = "Ivan", Surname = "Ivanov", Age = 20, PhoneNumber = "123456789012", Average = 4.5, NumberOfGroup = 101 });
group.Add(new Student { Name = "Maria", Surname = "Petrova", Age = 22, PhoneNumber = "123456789012", Average = 3.8, NumberOfGroup = 102 });
group.Add(new Student { Name = "Sergey", Surname = "Sergeev", Age = 21, PhoneNumber = "123456789012", Average = 4.2, NumberOfGroup = 101 });
group.Print();

group.Remove("Ivanov");
group.Print();

group.Search();

