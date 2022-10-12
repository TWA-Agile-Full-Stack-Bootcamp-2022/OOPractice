namespace OOPractice
{
    public class Car
    {
        private const string Name = "Cool Car";
        private const int Speed = 30;

        public string SpeedUp()
        {
            return $"{Name}: speed up {Speed} km/h";
        }
    }
}