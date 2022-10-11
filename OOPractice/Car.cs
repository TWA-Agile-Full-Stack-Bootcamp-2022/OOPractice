namespace OOPractice
{
    public class Car : Vehicle
    {
        public Car(string name, int speed)
        {
            this.name = name;
            this.speed = speed;
        }

        public Car(string name, Engine engine)
        {
            this.name = name;
            if (engine.GetEngineType() == EngineType.Gasoline)
            {
                this.speed = 30;
            }

            if (engine.GetEngineType() == EngineType.Electric)
            {
                this.speed = 25;
            }
        }

        public string Speedup()
        {
            return this.name + ": speed up " + this.speed + " km/h";
        }
    }
}