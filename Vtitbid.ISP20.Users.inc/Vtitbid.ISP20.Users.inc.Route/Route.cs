namespace Vtitbid.ISP20.Users.inc.Route
{
    public class Route: IComparable
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
            bool CheckOfNumberOfRoute = int.TryParse(Console.ReadLine(), out int value);
            if (CheckOfNumberOfRoute)
            {
               
                int numberOfRoute = value;
                return new Route(nameStartOfRoute, nameEndOfRoute, numberOfRoute);

            }
            else
            {
                Console.WriteLine("Ошибка ввода данных");
            }
            return null;
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
                    { return input; }
                    else { return "Начальная точка маршрута не определена"; }
                    break;
                case nameof(NameEndOfRoute):
                    if (!string.IsNullOrEmpty(input))
                    { return input; }
                    else { return "Конечная точка маршрут не определена"; }
                    break;

            }
            return null;

        }
        public static Route[] SearchRoute(Route[] routes)
        {
            
            Console.WriteLine("Введите номер вашего маршрута");
            if (!int.TryParse(Console.ReadLine(), out int numberOfRoute))
                return routes;
            for (int i = 0; i < routes.Length; i++)
            {
                if (numberOfRoute == routes[i].NumberOfRoute)
                {

                    Console.WriteLine(routes[i]);
                    
                }
                
            }

            return routes;

        }
        public int CompareTo(object? o)
        {
            if (o is Route route) return NumberOfRoute.CompareTo(route.NumberOfRoute);
            else throw new ArgumentException("Некорректное значение параметра");
        }
        public override string ToString()
        {

            return $"Начало марщрута: {NameStartOfRoute} \nКонец маршрута: {NameEndOfRoute}\nНомер маршрута: {NumberOfRoute}";
        }

    }
}
