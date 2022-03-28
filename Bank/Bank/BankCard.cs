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
        public long CardNumber { get; set; }
        public int Cvv { get; set; }
        
        public int CardValidity { get; set; }
        public BankСard( int cardNumber)
        {
          
            CardNumber = cardNumber;
            
            
            
        }
    }
}