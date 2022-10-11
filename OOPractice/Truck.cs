namespace OOPractice
{
    public class Truck : Vehicle
    {
        public Truck(string name, int speed)
        {
            this.name = name;

            this.speed = speed;
        }

        public Truck(string name, Engine engine)
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
    }
}