namespace OOPractice
{
    public class Vehicle
    {
        private string name;
        private int speed;

        public Vehicle(string name, int speed)
        {
            this.name = name;
            this.speed = speed;
        }

        public string Speedup()
        {
            return $"{this.name}: speed up {this.speed} km/h";
        }
    }
}