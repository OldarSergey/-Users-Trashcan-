using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vtitbid.ISP20.Users.inc;

namespace Vtitbid.ISP20.Luk.GetPR
{
    public class User
    {
        public string FirstName { get; set; }
        public DateOfBirth DateOfBirth { get; set; }
        private  string _password;
        private static  string _login = "";
        public static string alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        public User(string firstName, DateOfBirth dateOfBirth)
        {
            FirstName = firstName;
            DateOfBirth = dateOfBirth;
        }

        public User()
        {
        }

        public static User CreateUser()
        {

            Console.Write("Введите Ваше имя: ");
            var firstName = Console.ReadLine();
            Console.Write("Введите Вашу фамилию: ");  
            var dateOfBirth = DateOfBirth.CreateDateOfBirth();
            ConvertLogin(firstName, dateOfBirth);
            return new User(firstName, dateOfBirth);
        }


        public static string ConvertLogin (string firstName, DateOfBirth dateOfBirth)
        {
            firstName = firstName.ToLower();
            for (int i = 0; i< firstName.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (firstName[i] == alphabet[j])
                    {
                        _login = _login+(j+1); 
                    }
                }
            }
            Console.WriteLine(_login);
            char[] loginDate = (Convert.ToString((dateOfBirth.Day))+ Convert.ToString((dateOfBirth.Month)) + Convert.ToString((dateOfBirth.Year))).ToCharArray();
            
            int Sum = 0;
            

            for (int i = 0; i < loginDate.Length; i++)
            {
                Sum += (int)Char.GetNumericValue(loginDate[i]);  
            }
           
            
            _login += Sum;
            Console.WriteLine($"Ваш Логин {firstName}: {_login}") ;
            return _login;
        }



    }
}
