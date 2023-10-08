namespace OOPracticeTest
{
    using OOPractice;
    using Xunit;

    public class TruckTest
    {
        [Fact]
        public void Should_show_message_with_name_and_speed_when_speedup()
        {
            // given
            IVehicle vehicle = new Truck("Big Truck");

            // when
            string message = vehicle.SpeedUp();

            // then
            Assert.Equal("Big Truck: speed up 10 km/h", message);
        }
    }
}
