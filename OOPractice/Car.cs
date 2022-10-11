namespace OOPractice
{
    public class Car
    {
        private string carName;
        private int speed;

        public Car(string carName, int speed)
        {
            this.carName = carName;
            this.speed = speed;
        }

        public string Speedup()
        {
            return this.carName + ": speed up " + this.speed + " km/h";
        }
    }
}