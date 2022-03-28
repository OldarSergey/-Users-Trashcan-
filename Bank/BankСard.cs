using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proect
{
    public class BankСard
    {
        public Bank Name { get; set; }
        public int CardNumber { get; set; }
        public int Cvv { get; set; }
        public Client CardHolder { get; set; }
        public int CardValidity { get; set; }   
        public BankСard(Bank name, int cardNumber, 
            int cvv, Client cardHolder, int cardValidity)
        {
            Name = name;
            CardNumber = cardNumber;
            Cvv = cvv;
            CardHolder = cardHolder;
            CardValidity = cardValidity;
        }
    }
}
