namespace OOPractice
{
    using System;

    public class Car : IVehicle
    {
        private readonly string name;
        private readonly IEngine engine;

        public Car(string name, IEngine engine)
        {
            this.name = name;
            this.engine = engine;
        }

        public string SpeedUp()
        {
            return name + ": speed up " + engine.GetSpeed() + " km/h";
        }
    }
}
