namespace Vtitbid.ISP20.Users.inc.Route
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите количество маршрутов:");
            if (int.TryParse(Console.ReadLine(), out int value))
            {
                Route[] array = Route.GetRouteArray(value);
                Console.WriteLine();
                foreach (var route in array)
                {
                    Console.WriteLine(route);
                    Console.WriteLine();


                }
                array = Route.SearchRoute(array);
                
                
            }
            else
            {
                Console.WriteLine("Количесвто маршрутов не опредлено ");
            }
             



        }
    }
}