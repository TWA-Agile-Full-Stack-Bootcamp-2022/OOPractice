using System.Collections.Generic;

namespace OOPractice
{
    public class Car : IVehicle
    {
        public Car(CarEngine carEngine = CarEngine.GASOLINE)
        {
            Name = "Cool Car";
            Speed = carEngine.Equals(CarEngine.ELECTRIC) ? 25 : 30;
        }

        public string Name { get; set; }

        public int Speed { get; set; }
    }
}