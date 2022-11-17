using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtitbid.ISP20.Users.TRPO1
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long NumberOfPhone { get; set; }

        public Person(string firstName, string secondName, int numberOfPhone)
        {
            FirstName = firstName;
            LastName = secondName;
            NumberOfPhone = numberOfPhone;
        }
    
        public static Person CreateNote()
        {

            Console.Write("Введите имя: ");
            var firstName = ChekName(Console.ReadLine(), nameof(FirstName));
            Console.Write("Введите фамилию: ");
            var secondName = ChekName(Console.ReadLine(), nameof(LastName));
            Console.Write("Введите номер телефона: ");
            bool CheckOfNumberOfPhone = int.TryParse(Console.ReadLine(), out int value);
             
            if (CheckOfNumberOfPhone)
            {

                int numberOfPhone = value;
                return new Person(firstName, secondName, numberOfPhone);

            }
            else
            {
                Console.WriteLine("Ошибка ввода данных");
                Environment.Exit(1);
            }
            return null;
        }
        
        private static string ChekName(string input, string fieldName = "")
        {

            switch (fieldName)
            {
                case nameof(FirstName):
                    if (!string.IsNullOrEmpty(input))
                    { return input; }
                    else { return "Имя не определено"; }
                    break;
                case nameof(LastName):
                    if (!string.IsNullOrEmpty(input))
                    { return input; }
                    else { return "Фамилия не определена"; }
                    break;

            }
            return null;

        }
        public static List<Person> AddNote(List<Person> notes)
        {
            notes.Add(CreateNote()); 
            return notes;
        }

        public static List<Person> RemoveNote (List<Person> notes)
        {
           
            int d = int.Parse(Console.ReadLine());
            notes.RemoveAt(index: d);
            return notes;
        }
        public static List<Person> СhangeNote (List<Person> notes)
        {
            RemoveNote(notes);
            AddNote(notes);
            return notes;
        }

        
        public static List <Person> Choice(List<Person> notes)
        {
            bool Tr = true;
            while (Tr)
            {  
            
            
                Console.WriteLine("Список доступных операций: \n1)Добавить\n2)Удалить\n3)Изменить\n4)Выход");
                Console.Write("Операция: ");
                int number = int.Parse(Console.ReadLine());
                switch (number)
                {
                    case 1:
                        AddNote(notes);
                        break;
                    case 2:
                        Console.Write("Напишите порядковый номер человека, которого вы хотите удалить: ");
                        RemoveNote(notes);
                        break;
                    case 3:
                        Console.Write("Напишите порядковый номер человека, запись котого вы хотите заменить: ");
                        СhangeNote(notes);
                        break;
                    case 4:
                        Tr = false;
                        break;
                    default:
                        Console.WriteLine("Такой операции не существует!");
                        break;               
                }
            }
            return notes;
        }
        
        public int CompareTo(object? o)
        {
            if (o is Person note) return NumberOfPhone.CompareTo(note.NumberOfPhone);
            else throw new ArgumentException("Некорректное значение параметра");
        }
        public override string ToString()
        {

            return $"Имя: {FirstName} \nФамилия: {LastName}\nНомер телефона: {NumberOfPhone}";
        }

    }
}

