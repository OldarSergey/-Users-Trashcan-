namespace Vtitbid.ISP20.Users.inc.Zodiac
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var zodiacs = Zodiac.GetZodiacArray(n, Console.WriteLine, Console.ReadLine);


        }
    }
}