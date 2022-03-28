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

            BankСard bankСard = new BankСard(bank1.Name, 2142343, 544,

            BankAccount bankAccount = new BankAccount(bank.Name, )


            Check check = new Check(bank1.Name, client.FirstName,
                client.LastName, adress.Adress, bank.HotLine,
                TypeOperation.Translation, PaymentSystem.MasterCard,
                DateTime.Today, sum.Sum, 844, bankAccount.AccountNumber);


        }
}   } 

