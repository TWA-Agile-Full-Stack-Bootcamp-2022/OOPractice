using OOPractice;
using Xunit;

namespace OOPracticeTest
{
    public class VehicleTest
    {
        [Fact]
        public void Should_show_message_with_name_and_speed_when_a_car_speed_up()
        {
            IVehicle car = new Car();
            var message = car.SpeedUp();
            Assert.Equal("Cool Car: speed up 30 km/h", message);
        }

        [Fact]
        public void Should_show_message_with_name_and_speed_when_a_truck_speed_up()
        {
            IVehicle truck = new Truck();
            var message = truck.SpeedUp();
            Assert.Equal("Big Truck: speed up 10 km/h", message);
        }
    }
}