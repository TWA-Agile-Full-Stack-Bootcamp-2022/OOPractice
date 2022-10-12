namespace OOPractice
{
    public class Driver
    {
        public static string Drive(IVehicle vehicle)
        {
            return vehicle.SpeedUp();
        }
    }
}