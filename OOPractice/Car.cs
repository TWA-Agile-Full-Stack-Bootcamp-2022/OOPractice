namespace OOPractice
{
    public class Car : Vehicle
    {
        public Car(string name, int speed)
        {
            this.name = name;
            this.speed = speed;
        }

        public string Speedup()
        {
            return this.name + ": speed up " + this.speed + " km/h";
        }
    }
}