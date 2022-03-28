using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proect
{
    public class Check
    {
        public Bank Name { get; set; }
        public Client client { get; set; }
        public string Adress { get; set; }
        
        public Bank Hotline { get; set; }
        public TypeOperation typeOperation { get; set; }
        public PaymentSystem paymentSystem { get; set; }
        public DateTime dateTime { get; set; }
        public int Sum { get; set; }
        public BankAccount CardNumber { get; set; }
        public int NumberOperation { get; set; }
        public int AtmNumber { get; set; }
        public int AuthorizationCode    { get; set; }

        public Check(Bank name, Client client, string adress, Bank hotline, 
            TypeOperation typeOperation, PaymentSystem paymentSystem, 
            DateTime dateTime, int sum, BankAccount cardNumber, int numberOperation, 
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

    }
}
