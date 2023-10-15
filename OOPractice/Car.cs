namespace OOPractice
{
    public class Car
    {
        public string Name { get; set; }

        public Car(string name)
        {
            Name = name;
        }

        public string ShowMessage()
        {
            return "Cool Car: speed up 30 km/h";
        }
    }
}
