namespace OOPractice
{
    using System;
    public interface IVehicle
    {
        public abstract string Speedup();
    }

    public class Car : IVehicle
    {
        public string Speedup()
        {
            return "Cool Car: speed up 30 km/h";
        }
    }

    public class Truck : IVehicle
    {
        public string Speedup()
        {
            return "Big Truck:speed up 10km/h";
        }
    }

    public class Driver
    {
        public string Drive(IVehicle vehicle)
        {
            return vehicle.Speedup();
        }
    }
}
