using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderBurger
{
    internal class BurgerDirector 
    {
        private readonly IBurgerBuilder _burger;

        public BurgerDirector(IBurgerBuilder burger)
        {
            _burger = burger;
        }

        public void BuildWoper()
        {
            Console.WriteLine();
            Console.WriteLine("В состав вашего бургера входят такие ингридиенты как: ");
            _burger.BuildCheese();
            _burger.BuildCucumbers();
            _burger.BuildCutlet();
            _burger.BuildGreens();
            _burger.BuildOnion();
            _burger.BuildTomatoes();
        }  
        
        public void BuildCheese()
        {
            Console.WriteLine();
            Console.WriteLine("В состав вашего бургера входят такие ингридиенты как: ");
            _burger.BuildCheese();
            _burger.BuildCutlet();
            _burger.BuildGreens();
            _burger.BuildOnion();
            
        }
    }
}
