namespace OOPractice
{
    public interface IVehicle
    {
        string Name { get; set; }
        int Speed { get; set; }

        public string SpeedUp()
        {
            return $"{Name}: speed up {Speed} km/h";
        }
    }
}