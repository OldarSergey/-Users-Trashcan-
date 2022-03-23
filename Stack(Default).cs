using System;
using System.Collections.Generic;
using System.Linq;

namespace Stack
{
    class Program
    {

        static void Main(string[] args)
        {
            var Stack = new Stack<string>();
            {
                Stack.Push("Сергей");
                Stack.Push("Лукьяненко");
                Stack.Push("Дмитрий");
                Stack.Push("Лазарев");
                var a = Stack.Pop();
                var b = Stack.Peek();

                Console.WriteLine(a);
                Console.WriteLine();
                Console.WriteLine(b);
                Console.WriteLine();

                foreach (var item in Stack)
                {
                    Console.WriteLine(item);
                }
            }
        }

    }
}