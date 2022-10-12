using OOPractice;
using Xunit;

namespace OOPracticeTest
{
    public class DriverTest
    {
        [Fact]
        public void Should_show_speed_up_message_when_driver_drive_a_car()
        {
            IVehicle car = new Car();

            var message = Driver.Drive(car);

            Assert.Equal("Cool Car: speed up 30 km/h", message);
        }

        [Fact]
        public void Should_show_speed_up_message_when_driver_drive_a_truck()
        {
            IVehicle truck = new Truck();

            var message = Driver.Drive(truck);

            Assert.Equal("Big Truck: speed up 10 km/h", message);
        }
    }
}