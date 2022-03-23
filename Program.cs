//Program
using System.Globalization;
using UserDateTime;
Console.Write("Ваше имя : ");

Person person = new Person();
{
    person.Name = Console.ReadLine();
    Console.Write("Введите ваш день рождения в формате дд.мм.гггг: ");

    person.birthDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

    if (person.birthDate.Year > DateTime.Now.Year)
    {
        Console.WriteLine($"{person.Name}, Вы неправильно ввели данные");
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine($" Здравствуйте, {person.Name}, Вам {person.Age} лет!!!!");
    }
}
//Class
using System;

namespace UserDateTime
{
    public class Person
    {
        public int age { get; set; }
        public DateTime birthDate { get; set; }
        public string Name { get; set; }

        public int Age
        {
            get
            {
                age = DateTime.Now.Year - birthDate.Year;
                if (DateTime.Now.Month < birthDate.Month
                || (DateTime.Now.Month == birthDate.Month && DateTime.Now.Day < birthDate.Day))
                {

                    age--;


                }
                return age;

            }
        }
    }
}