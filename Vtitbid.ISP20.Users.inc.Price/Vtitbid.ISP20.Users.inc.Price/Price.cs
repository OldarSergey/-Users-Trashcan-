using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtitbid.ISP20.Users.inc.Price
{
    public class Price : IComparable
    {
        public string ProductName { get; set; }
        public string ShopName { get; set; }
        public double ProductPrice { get; set; }
        public static Price CreatPrice()
        {
            Console.Write("введите название магазина: ");
            string shopName = ChekName(Console.ReadLine(), nameof(ShopName));
            Console.Write("введите название товара: ");
            string productName = ChekName(Console.ReadLine(), nameof(ProductName));
            Console.Write("введите название цена: ");
            if (Double.TryParse(Console.ReadLine(), out double value))
            {
                double productPrice = value;
                return new Price(shopName, productName, productPrice);
            }
            else
            {
                Console.WriteLine("Ошибка ввода данных");
                return null;
            }
        }
        public static Price[] GetPriceArray(int count)
        {
            Price[] prices = new Price[count];

            for (int i = 0; i < prices.Length; i++)
            {
                prices[i] = CreatPrice();
            }
            PriceSort(prices);
            return prices;
        }
        public static Price[] PriceSort(Price[] prices)
        {
            Array.Sort(prices);

            Console.WriteLine("\nсортированный список: "); ;
            for (int i = 0; i < prices.Length; i++)
            {
                Console.WriteLine(prices[i]);
            }
            return prices;
        }
        public static Price[] PriceSearch(Price[] prices)
        {
            string nameShop = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i].ShopName == nameShop)
                {
                    Console.WriteLine($"\n{prices[i]}");
                    count++;
                }
            }

            if (count == 0)
            {
                Console.WriteLine("Такого магазина нет в списках");

            }
            return prices;

        }
        public Price(string productname, string shopname, double productprice)
        {
            ProductName = productname;
            ShopName = shopname;
            ProductPrice = productprice;
        }
        public override string ToString()
        {
            return $"Название магазина: {ShopName}\n Название товара: {ProductName}\n цена в рублях:{ProductPrice}";
        }
        private static string ChekName(string input, string fieldName = "")
        {

            switch (fieldName)
            {
                case nameof(ProductName):
                    if (!string.IsNullOrEmpty(input))
                    { return input; }
                    else { return "Название товара не определено";  }
                    break;
                case nameof(ShopName):
                    if (!string.IsNullOrEmpty(input))
                    { return input;  }
                    else { return "Названия магазина не определена";  }
                    break;
            }
            return null;

        }

        public int CompareTo(object? obj)
        {
            if (obj is Price price) return ShopName.CompareTo(price.ShopName);
            else throw new ArgumentException("Ошибка");
        }

    }
}
