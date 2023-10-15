namespace OOPractice
{
    public class Truck : Vehicle
    {
        public Truck(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public override string ShowMessage()
        {
            return "Big Truck: speed up 10 km/h";
        }
    }
}
