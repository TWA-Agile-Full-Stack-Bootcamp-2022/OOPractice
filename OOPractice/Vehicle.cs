namespace OOPractice
{
    public abstract class Vehicle
    {
        protected string name;
        protected int speed;
        public string Speedup()
        {
            return this.name + ": speed up " + this.speed + " km/h";
        }
    }
}