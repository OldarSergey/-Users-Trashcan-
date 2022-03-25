using System;

namespace HomeTask
{
    public abstract class Car : ICar
    {
        public int Move() 
        {

            Console.Write("Введите расстояние: ");
            var Distance = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите скорость: ");
            var Speed = Convert.ToInt32(Console.ReadLine());

            var result = Distance/ Speed;
          return result;
        }

        public int Age()
        {
            Console.WriteLine("Введить год машины: ");
            var birthday = Convert.ToInt32(Console.ReadLine());
            var god = DateTime.Now.Year - birthday;
            return god;

        }

        public string Infa(string infa)
        {
            throw new NotImplementedException();
        }

       
    }
}
