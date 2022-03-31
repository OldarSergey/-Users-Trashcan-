using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proect
{
    public class Bank
    {
        public string Name { get; set; }
        public int HotLine { get; set; }
        public Bank(string name, int hotLine)
        {
            Name = name;
            HotLine = hotLine;
        }
    }
}