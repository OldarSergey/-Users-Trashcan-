namespace Vtitbid.ISP20.Users.TRPO1
{
    public class Program
    {
        public static void Main(string[] args)
        {

            List<Person> notes = new List<Person>();
            int count = 0;

            for (int i = 0; i < 3; i++)
            {
                Person.AddNote(notes);
            }
            Console.WriteLine("Ваша база людей:");
            foreach (Person note in notes)
            {
                Console.WriteLine(note);
                Console.WriteLine($"Порядковый номер: {count}");
                count++;
                Console.WriteLine();
            }

            Person.Choice(notes);


            foreach (Person note in notes)
            {
                Console.WriteLine(note);
                Console.WriteLine();
            }

        }
    }
}