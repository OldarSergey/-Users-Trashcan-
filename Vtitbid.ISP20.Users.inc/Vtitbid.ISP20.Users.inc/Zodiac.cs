using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtitbid.ISP20.Users.inc
{
    public class Zodiac
    {
        private string _firstName;
        private string _lastName;
        private int[] _dateOfBirth;
        private ZodiacSign _zodiacSign;
        private bool _repeat = true;
        public string FirstName { get { return _firstName;  } set { _repeat = true; CheckTo(value); _firstName = value; } }
        public string LastName { get { return _lastName; } set { _repeat = true; CheckTo(value); _lastName = value; } }
        public int[] DateOfBirth { get; set; }
        public ZodiacSign ZodiacSign { get; set; }
        

        public Zodiac(string firstName, string lastName, int[] dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;

            ZodiacSign = SignDate(DateOfBirth);
        }
        public Zodiac() { }
       
        public static Zodiac[] GetZodiacsArray()
        {
            int quantityOfPeople = 0;
            string input;
            
            do
            {
                Console.Write("Введите количество людей:");
                input = Console.ReadLine();
            } while (!Int32.TryParse(input,out quantityOfPeople));
            Zodiac[] zodiacs = new Zodiac[quantityOfPeople];
            //while (_repeat) 
            //{
                for (int i = 0; i < zodiacs.Length; i++)
                {
                    int[] dateOfBirth = new int[3];
                    DateTime dob; // date of birth
                    string inputDob;

                    Console.Write("Введите имя: ");
                    string firstName = Console.ReadLine();
                    Console.Write("Введите фамилию: ");
                    string lastName = Console.ReadLine();
                    do
                    {
                        Console.WriteLine("Введите дату рождения в формате дд.ММ.гггг (день.месяц.год):");
                        inputDob = Console.ReadLine();
                    }
                    while (!DateTime.TryParseExact(inputDob, "dd.MM.yyyy", null, DateTimeStyles.None, out dob));
                    dateOfBirth[0] = dob.Day;
                    dateOfBirth[1] = dob.Month;
                    dateOfBirth[2] = dob.Year;
                    //_repeat = false;
                    zodiacs[i] = new Zodiac(firstName, lastName, dateOfBirth);
                    

                //}
               
                }
            
            return zodiacs;

        }
        private ZodiacSign SignDate(int[] dateOfBirth)
        {
            var day = dateOfBirth[0];
            var month = dateOfBirth[1];

            if (day >= 21 && month == 3 || day <= 20 && month == 4)
                return ZodiacSign.Aries;

            if (day >= 21 && month == 4 || day <= 20 && month == 5)
                return ZodiacSign.Taurus;

            if (day >= 21 && month == 5 || day <= 21 && month == 6)
                return ZodiacSign.Gemini;

            if (day >= 22 && month == 6 || day <= 22 && month == 7)
                return ZodiacSign.Cancer;

            if (day >= 23 && month == 7 || day <= 22 && month == 8)
                return ZodiacSign.Leo;

            if (day >= 23 && month == 8 || day <= 23 && month == 9)
                return ZodiacSign.Virgo;

            if (day >= 24 && month == 9 || day <= 23 && month == 10)
                return ZodiacSign.Libra;

            if (day >= 24 && month == 10 || day <= 22 && month == 11)
                return ZodiacSign.Scorpio;

            if (day >= 23 && month == 11 || day <= 21 && month == 12)
                return ZodiacSign.Sagittarius;

            if (day >= 22 && month == 12 || day <= 20 && month == 1)
                return ZodiacSign.Capricorn;

            if (day >= 21 && month == 1 || day <= 18 && month == 2)
                return ZodiacSign.Aquarius;
            else
                return ZodiacSign.Pisces;

        }
        public string ZodiacSignToString()
        {
            switch (ZodiacSign)
            {
                case ZodiacSign.Aries: return "Овен";
                case ZodiacSign.Taurus: return "Телец";
                case ZodiacSign.Gemini: return "Близнецы";
                case ZodiacSign.Cancer: return "Рак";
                case ZodiacSign.Leo: return "Лев";
                case ZodiacSign.Virgo: return "Дева";
                case ZodiacSign.Libra: return "Весы";
                case ZodiacSign.Scorpio: return "Скорпион";
                case ZodiacSign.Sagittarius: return "Стрелец";
                case ZodiacSign.Capricorn: return "Козерог";
                case ZodiacSign.Aquarius: return "Водолей";
                case ZodiacSign.Pisces: return "Рыбы";
                default: return null;
            }

        }
        public override string ToString()
        {
            return $"Имя: {_firstName}   Фамилия:{_lastName}    ДР:{_dateOfBirth}   ЗЗ:{_zodiacSign}  ";
        }
        public string CheckTo(string value)
        {
            if (String.IsNullOrEmpty(value))
            {
                Console.WriteLine("некоректные данные");
            
                _repeat = true;
                return null;
            }
            else
            {

                return value;

            }
        }

    }
}
