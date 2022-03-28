using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proect
{
    public class Check
    {
        private string firstName;
        private string lastName;
        private string adress1;
        private int hotLine;
        private TypeOperation translation;
        private PaymentSystem masterCard;
        private DateTime today;
        private int v;
        private object accountNumber;

        public Bank Name { get; set; }
        public Client client { get; set; }
        public string Adress { get; set; }

        public Bank Hotline { get; set; }
        public TypeOperation typeOperation { get; set; }
        public PaymentSystem paymentSystem { get; set; }
        public DateTime dateTime { get; set; }
        public int Sum { get; set; }
        public  BankCard CardNumber { get; set; }
        public int NumberOperation { get; set; }
        public int AtmNumber { get; set; }
        public int AuthorizationCode { get; set; }

        public Check(Bank name, Client client, string adress, Bank hotline,
            TypeOperation typeOperation, PaymentSystem paymentSystem,
            DateTime dateTime, int sum, BankCard cardNumber, int numberOperation,
            int atmNumber, int authorizationCode)
        {
            Name = name;
            this.client = client;
            Adress = adress;
            Hotline = hotline;
            this.typeOperation = typeOperation;
            this.paymentSystem = paymentSystem;
            this.dateTime = dateTime;
            Sum = sum;
            CardNumber = cardNumber;
            NumberOperation = numberOperation;
            AtmNumber = atmNumber;
            AuthorizationCode = authorizationCode;
        }

        public Check(string adress)
        {
            Adress = adress;
        }
        public Check(int sum)
        {
            Sum = sum;
        }

        public Check(string adress, string firstName, string lastName, string adress1,
            int hotLine, TypeOperation translation, PaymentSystem masterCard, DateTime today,
            int sum, int v, object accountNumber) : this(adress)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.adress1 = adress1;
            this.hotLine = hotLine;
            this.translation = translation;
            this.masterCard = masterCard;
            this.today = today;
            Sum = sum;
            this.v = v;
            this.accountNumber = accountNumber;
        }
    }

    public class BankCard
    {
        private int v;

        public BankCard(int v)
        {
            this.v = v;
        }

        public int CardNumber { get; internal set; }
    }
}