using  Vtitbid.ISP20.Users.inc.Price;

namespace Vtitbid.ISP20.Users.inc.Price
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество магазинов: ");
            if (int.TryParse(Console.ReadLine(), out int value))
            {
                Price[] array = Price.GetPriceArray(value);
                Console.WriteLine();
                Console.WriteLine(Price.PriceSearch(array));
            }
            else
            {
                Console.WriteLine("\nОшибка");
            }
        }
    }
}
