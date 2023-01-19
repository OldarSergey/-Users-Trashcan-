using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderBurger
{
    public class BurgerBuilder : IBurgerBuilder
    {
        private Burger _burger;
        public BurgerBuilder()
        {
            _burger = new();
        }

        public void BuildCheese()
        {
            Console.WriteLine($"Cыр");
            _burger.Cheese = true;

        }

        public void BuildCucumbers()
        {
            Console.WriteLine($"Огурцы");
            _burger.Cucumbers = true;
        }

        public void BuildCutlet()
        {
            Console.WriteLine($"Котлета");
            _burger.Cutlet = true;
        }

        public void BuildGreens()
        {
            Console.WriteLine($"Зелень");
            _burger.Greens = true;
        }

        public void BuildOnion()
        {
            Console.WriteLine($"Лук");
            _burger.Onion = true;
        }

        public void BuildTomatoes()
        {
            Console.WriteLine($"Томаты");
            _burger.Tomatoes = true;
        }

        public Burger GetBurger()
        {
          
            Burger burger = _burger;
            _burger = new();
            return burger;
        }
    }
}
