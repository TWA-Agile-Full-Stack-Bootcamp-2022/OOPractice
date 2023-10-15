using OOPracticeTest;

namespace OOPractice
{
    public class Car : Vehicle
    {
        private readonly Engine engine;

        public Car(string name, Engine engine)
        {
            Name = name;
            this.engine = engine;
        }

        public string Name { get; set; }

        public override string ShowMessage()
        {
            return $"Cool Car: speed up {engine.Speed} km/h";
        }
    }
}
