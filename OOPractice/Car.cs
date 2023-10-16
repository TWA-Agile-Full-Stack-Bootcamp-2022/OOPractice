namespace OOPractice
{
    public class Car : Vehicle
    {
        public Car(string name, int speed) : base(name, speed)
        {
        }

        public Car(string name, Engine engine) : base(name, engine)
        {
        }
    }
}