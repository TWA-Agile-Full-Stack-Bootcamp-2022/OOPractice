namespace OOPractice
{
    public class Driver
    {
        public string Drive(IVehicle vehicle)
        {
            return vehicle.SpeedUp();
        }
    }
}