namespace OOPractice
{
    using System;
    public interface IVehicle
    {
        public abstract string Speedup();
    }

    public interface IEngine
    {
        public abstract int MaxSpeed();
    }

    public class GasolineEngine : IEngine
    {
        public int MaxSpeed()
        {
            return 30;
        }
    }

    public class ElectricEngine : IEngine
    {
        public int MaxSpeed()
        {
            return 25;
        }
    }

    public class Car : IVehicle
    {
        private IEngine engine;
        public Car()
        {
            engine = new GasolineEngine();
        }

        public Car(IEngine engine)
        {
            this.engine = engine;
        }

        public string Speedup()
        {
            return "Cool Car: speed up " + engine.MaxSpeed() + " km/h";
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
