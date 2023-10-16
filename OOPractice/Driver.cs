namespace OOPractice
{
    public class Driver
    {
        public string Drive(Car car)
        {
            return car.Speedup();
        }

        public string Drive(Truck truck)
        {
            return truck.Speedup();
        }
    }
}