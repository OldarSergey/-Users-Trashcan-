using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtitbid.ISP20.Users.inc.Route
{
    public class Route
    {
        public string NameStartOfRoute { get; set; }
        public string NameEndOfRoute { get; set; }
        public int NumberOfRoute { get; set; }

        public Route(string nameStartOfRoute, string nameEndOfRoute, int numberOfRoute)
        {
            NameStartOfRoute = nameStartOfRoute;
            NameEndOfRoute = nameEndOfRoute;
            NumberOfRoute = numberOfRoute;
        }

        public static Route CreateRoute()
        {

            Console.Write("Введите начало маршрута: ");
            var nameStartOfRoute = ChekName(Console.ReadLine(), nameof(NameStartOfRoute));
            Console.Write("Введите конец маршрута: ");
            var nameEndOfRoute = ChekName(Console.ReadLine(), nameof(NameEndOfRoute));
            Console.Write("Введите номер маршрута: ");
            if (int.TryParse(Console.ReadLine(), out int value))
            {
                int numberOfRoute = value;
                return new Route(nameStartOfRoute, nameEndOfRoute, numberOfRoute);
            }
            else
            {
                Console.WriteLine("Ошибка ввода данных");
                return null;
            }
                
            
        }
        public static Route[] GetRouteArray(int count)
        {
            Route[] routes = new Route[count];

            for (int i = 0; i < routes.Length; i++)
            {
                routes[i] = CreateRoute();
            }

            return routes;
        }
        private static string ChekName(string input, string fieldName = "")
        {

            switch (fieldName)
            {
                case nameof(NameStartOfRoute):
                    if (!string.IsNullOrEmpty(input))
                    { return input; break; }
                    else { return "Начальная точка маршрута не определена"; break; }

                case nameof(NameEndOfRoute):
                    if (!string.IsNullOrEmpty(input))
                    { return input; break; }
                    else { return "Конечная точка маршрут не определена"; break; }


            }
            return null;

        }
        public static Route SearchRoute(Route[] array)
        {
            Console.WriteLine("Введите номер вашего маршрута");
            if (int.TryParse(Console.ReadLine(), out int numberOfRoute))
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (!(numberOfRoute == array[i].NumberOfRoute))
                    {
                        
                        Console.WriteLine(array[i]);
                    }
                    else
                    {
                        Console.WriteLine(array[i]);
                        i++;
                        
                    }
                }
            }
            return null;
        }
        public override string ToString()
        {
           
            return $"Начало марщрута: {NameStartOfRoute} \nКонец маршрута: {NameEndOfRoute}\nНомер маршрута: {NumberOfRoute}";
        }

    }
}
