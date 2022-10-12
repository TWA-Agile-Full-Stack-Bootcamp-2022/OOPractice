using System.Collections.Generic;

namespace OOPractice
{
    public class Car : IVehicle
    {
        public Car()
        {
            Name = "Cool Car";
            Speed = 30;
        }

        public string Name { get; set; }

        public int Speed { get; set; }
    }
}