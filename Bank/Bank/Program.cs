using System;
namespace Proect

{
    class Program
    {
        public static void Main(string[] args)
        {
            Bank bank = new Bank("VTB", 900);
            Bank bank1 = new Bank("Tinkoff", 841);
            Client client = new Client("Cергей", "Лукьяненко");
            Check adress = new Check("пупкина 9");
            Check sum = new Check(1250);
            BankCard bankCard = new(23424);

            bankCard.CardNumber = 22022642;

            Check check = new Check(bank1.Name, client.FirstName,
                client.LastName, adress.Adress, bank.HotLine,
                TypeOperation.Translation, PaymentSystem.MasterCard,
                DateTime.Today, sum.Sum, 842, bankCard.CardNumber);
            
            Console.WriteLine($"{bank1.Name}\n{adress.Adress}\nТелефон службы помощи клиентам: {bank1.HotLine}" +
                $"\n+7(903)435-59-57\n{TypeOperation.Translation}" +
                $"\n{DateTime.Now.Date}             {DateTime.Now.TimeOfDay} \n{client.FirstName} {client.LastName}\n" +
                $"{sum.Sum}\n{bankCard.CardNumber}");


        }
    }
}
