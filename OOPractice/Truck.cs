namespace OOPractice
{
    public class Truck
    {
        private const string Name = "Big Truck";
        private const int Speed = 10;

        public string SpeedUp()
        {
            return $"{Name}: speed up {Speed} km/h";
        }
    }
}