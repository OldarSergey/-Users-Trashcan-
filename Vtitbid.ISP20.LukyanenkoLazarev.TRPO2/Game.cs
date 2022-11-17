using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtitbid.ISP20.LukyanenkoLazarev.TRPO1
{
    public static class Game
    {
        static bool repeat = true;
        static private string[] game = new string[] { "камень","ножницы", "бумага" };

        static Random rand = new Random();
        public static void StoneScissorsPaper()
        {
            while (repeat)
            {
                string random = game[rand.Next(game.Length)];
                Console.Write("Камень, ножницы или бумага? : ");
                string input = Console.ReadLine();

                switch (input.ToLower())
                {
                    case "камень":
                        Console.WriteLine(Stone(random, input));
                        break;
                    case "ножницы":
                        
                        Console.WriteLine(Scissors(random, input));
                        break;
                    case "бумага":
                        Console.WriteLine(Paper(random, input));
                        break;
                    default:
                        Console.WriteLine("ты по-моему перепутал");
                        break;
                }
                Console.Write("1 - Продолжить\n2 - выйти : ");
                string choice = Console.ReadLine();
                    if (choice == "2") { repeat = false; }
                else Console.WriteLine("играем дальше");
                    
            }
            
        }
        public static string Stone(string random , string input)
        {
            string output;
            if (random == "ножницы")
            {

               output = $"Ты выиграл. {input} мощнее, чем {random}";   
            }
            else if (random == "бумага")
            {
                output = $"Я выиграл. {input} слабее, чем {random}";
            }
            else output = $"{input} = {random}. Мы оба хороши";

            return output;
        }
        public static string Scissors(string random, string input)
        {
            string output;
            if (random == "бумага")
            {

                output = $"Ты выиграл. {input} мощнее, чем {random}";
            }
            else if (random == "камень")
            {
                output = $"Я выиграл. {input} слабее, чем {random}";
            }
            else output = $"{input} = {random}. Мы оба хороши";

            return output;
        }
        public static string Paper(string random, string input)
        {
            string output;
            if (random == "камень")
            {

                output = $"Ты выиграл. {input} мощнее, чем {random}";
            }
            else if (random == "ножницы")
            {
                output = $"Я выиграл. {input} слабее, чем {random}";
            }
            else output = $"{input} = {random}. Мы оба хороши";

            return output;
        }


    }
}
