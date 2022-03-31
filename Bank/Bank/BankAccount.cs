using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proect
{
    public class BankAccount
    {
        public Bank Name { get; set; }
        public BankСard CardNumber { get; set; }
        public int AccountNumber { get; set; }
        public Client Holder { get; set; }
        public int Balance { get; set; }

        public BankAccount( BankСard cardNumber)
        {
            
            CardNumber = cardNumber;
           
        }
    }
}