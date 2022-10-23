﻿namespace Vtitbid.ISP20.Users.inc.Zodiac
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите количество людей:");
            if (int.TryParse(Console.ReadLine(), out int value))
            {
                Zodiac[] array = Zodiac.GetZodiacArray(value);
                Console.WriteLine();
                foreach (var zodiac in array)
                {
                    Console.WriteLine(zodiac);
                    Console.WriteLine();


                }
            }
            else
            {
                Console.WriteLine("Количесвто людей не опредлено ");
            }

            
            
        }
    }
}