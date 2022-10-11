namespace OOPractice
{
    using System;

    public class Truck : IVehicle
    {
        private readonly string name;
        private readonly decimal speed;

        public Truck(string name, decimal speed)
        {
            this.name = name;
            this.speed = speed;
        }

        public string SpeedUp()
        {
            return name + ": speed up " + speed + " km/h";
        }
    }
}