namespace Vtitbid.ISP20.Users.inc.Bill
{
    public class Bill /*: IComparable*/
    {
        public string PayerBill { get; set; }
        public string RecipentBill { get; set; }
        public int Amount { get; set; }

        public Bill(string payerBill, string recipentBill, int amount)
        {
            PayerBill = payerBill;
            RecipentBill = recipentBill;
            Amount = amount;
        }

        public static Bill CreateBill(Action<string> writer, Func<string> reader)
        {

            writer("Введите расчетный счет плательщика: ");
            var payerBill = ChekName(reader(), nameof(PayerBill));
            writer("Введите расчетный счет получателя: ");
            var recipentBill = ChekName(reader(), nameof(RecipentBill));
            writer("Введите сумму начисления: ");
            bool CheckOfAmount = int.TryParse(reader(), out int value);
            if (CheckOfAmount)
            {

                int amount = value;
                return new Bill(payerBill, recipentBill, amount);

            }
            else
            {
                writer("Ошибка ввода данных");
                Environment.Exit(0);
            }
            return null;
        }
        public static Bill[] GetBillArray(int count, Action<string> writer, Func<string> reader)
        {
            Bill[] routes = new Bill[count];

            for (int i = 0; i < routes.Length; i++)
            {
                routes[i] = CreateBill(writer, reader);
            }

            return routes;
        }
        private static string ChekName(string input, string fieldName = "")
        {

            switch (fieldName)
            {
                case nameof(PayerBill):
                    if (!string.IsNullOrEmpty(input))
                    { return input; }
                    else { return "Расчетный счет плательщика не определен"; }
                    break;
                case nameof(RecipentBill):
                    if (!string.IsNullOrEmpty(input))
                    { return input; }
                    else { return "Расчетный счет получателя не определен"; }
                    break;

            }
            return "Ошибка ввода";

        }
        public static int SearchBill(Bill[] routes, Action<string> writer, Action<Bill> writerBill, Func<string> reader)
        {
            int count = 0;
            writer("Введите расчетный счет плательщика: ");
            string input = reader();
            
            if (string.IsNullOrEmpty(input))
                return -1;
            for (int i = 0; i < routes.Length; i++)
            {
                if (input == routes[i].PayerBill)
                {

                    writerBill(routes[i]);

                }
                {
                    count++;
                }
                if (count == routes.Length) { return -1; }
            }

            return 0;

        }
        //public int CompareTo(object? o)
        //{
        //    if (o is Bill route) return Amount.CompareTo(route.Amount);
        //    else throw new ArgumentException("Некорректное значение параметра");
        //}
        public override string ToString()
        {

            return $"Расчетный счет плательщика: {PayerBill} \nРасчетный счет получателя: {RecipentBill}\nСумма начисления: {Amount}";
        }

    }
}
