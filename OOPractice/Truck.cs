namespace OOPractice
{
    public class Truck : IVehicle
    {
        public Truck()
        {
            Name = "Big Truck";
            Speed = 10;
        }

        public string Name { get; set; }

        public int Speed { get; set; }
    }
}