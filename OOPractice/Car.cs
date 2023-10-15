namespace OOPractice
{
    public class Car
    {
        public Car(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public string ShowMessage()
        {
            return "Cool Car: speed up 30 km/h";
        }
    }
}
