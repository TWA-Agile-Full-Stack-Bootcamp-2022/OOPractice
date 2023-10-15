namespace OOPractice
{
    public class Car : Vehicle
    {
        public Car(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public override string ShowMessage()
        {
            return "Cool Car: speed up 30 km/h";
        }
    }
}
