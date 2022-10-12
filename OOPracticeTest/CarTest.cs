using OOPractice;
using Xunit;

namespace OOPracticeTest
{
    public class CarTest
    {
        [Fact]
        public void Should_show_message_with_name_and_speed_when_a_car_speed_up()
        {
            var car = new Car();
            var message = car.SpeedUp();
            Assert.Equal("Cool Car: speed up 30 km/h", message);
        }
    }
}