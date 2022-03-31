using System;
using System.ComponentModel;
using System.Reflection;
namespace Proect

{
    class Program
    {
        public static void Main(string[] args)
        {
            Bank bank = new Bank("VTB", 900);
            Bank bank1 = new Bank("Tinkoff", 841);
            Client client = new Client("Сергей", "Лукьяненко");
            Check adress = new Check("пупкина 9");
            Console.Write("Введите сумму операции: ");
            Check sum = new Check(Convert.ToInt32(Console.ReadLine()));
            BankCard bankCard = new(8);
            bankCard.CardNumber = 879879879;
            int balance = 23423;
            BankСard Balance = new BankСard(balance);
            Console.Write($"Возможные типы операций:\n 1 - Пополнение\n 2 - Перевод \n 3 - Снятие наличных\nВыберите тип операции: ");
            int Operation = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-------------------------------");
            switch (Operation)
            {
                case 1:
                    balance = balance + sum.Sum;
                    Console.WriteLine($"Наименование банка: {bank1.Name}\n{adress.Adress}\nТелефон службы помощи клиентам: {bank1.HotLine}" +
                    $"\n+7(903)435-59-57\nТип операции:{TypeOperation.Пополнение}" +
                    $"\n{DateTime.Now.Day}.{DateTime.Now.Month}.{DateTime.Now.Year} {DateTime.Now.TimeOfDay} \n{client.FirstName} {client.LastName}\n" +
                    $"Сумма операции:{sum.Sum}\nНомер карты: {bankCard.CardNumber}\nВаш баланс: {balance}");
                    break;
                case 2:
                    balance = balance - sum.Sum;
                    if (balance >= 0)
                    {
                        Console.WriteLine($"Наименование банка: {bank1.Name}\n{adress.Adress}\nТелефон службы помощи клиентам: {bank1.HotLine}" +
                        $"\n+7(903)435-59-57\nТип операции:{TypeOperation.Перевод}" +
                        $"\n{DateTime.Now.Day}.{DateTime.Now.Month}.{DateTime.Now.Year} {DateTime.Now.TimeOfDay} \n{client.FirstName} {client.LastName}\n" +
                        $"Сумма операции:{sum.Sum}\nНомер карты: {bankCard.CardNumber}\nВаш баланс: {balance}");
                    }
                    else Console.WriteLine("Операция невозможна. Пополните баланс.");
                    break;
                case 3:
                    balance = balance - sum.Sum;
                    if (balance >= 0)
                    {
                        Console.WriteLine($"Наименование банка: {bank1.Name}\n{adress.Adress}\nТелефон службы помощи клиентам: {bank1.HotLine}" +
                        $"\n+7(903)435-59-57\nТип операции:{TypeOperation.Перевод}" +
                        $"\n{DateTime.Now.Day}.{DateTime.Now.Month}.{DateTime.Now.Year} {DateTime.Now.TimeOfDay} \n{client.FirstName} {client.LastName}\n" +
                        $"Сумма операции:{sum.Sum}\nНомер карты: {bankCard.CardNumber}\nВаш баланс: {balance}");

                    }
                    else Console.WriteLine("Операция невозможна. Пополните баланс.");
                    break;


            }
            if ((Operation > 3) || (Operation < 1))
            {
                Console.WriteLine("Вы ввели неверную операцию");
            }


            Check check = new Check(bank1.Name, client.FirstName,
            client.LastName, adress.Adress, bank.HotLine,
            Operation, PaymentSystem.MasterCard,
            DateTime.Today, sum.Sum, 842, bankCard.CardNumber);
        }


    }
}