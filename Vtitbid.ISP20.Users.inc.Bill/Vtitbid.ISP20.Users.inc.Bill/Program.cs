namespace Vtitbid.ISP20.Users.inc.Bill
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите количество операций:");
            if (int.TryParse(Console.ReadLine(), out int value))
            {
                Bill[] array = Bill.GetBillArray(value, Console.WriteLine, Console.ReadLine);
                
                Console.WriteLine();
                foreach (var route in array)
                {
                    Console.WriteLine(route);
                    Console.WriteLine();
                }

                Bill.SearchBill(array, Console.WriteLine, Console.WriteLine, Console.ReadLine);
                
            }
            else
            {
                Console.WriteLine("Количесвто операций не опредлено ");
            }




        }
    }
}