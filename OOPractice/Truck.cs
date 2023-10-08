namespace OOPractice
{
    using System;

    public class Truck : IVehicle
    {
        private const decimal Speed = 10;

        private readonly string name;

        public Truck(string name)
        {
            this.name = name;
        }

        public string SpeedUp()
        {
            return name + ": speed up " + Speed + " km/h";
        }
    }
}
