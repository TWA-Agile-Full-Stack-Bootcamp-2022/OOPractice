using System.Text;

namespace OOPracticeTest
{
    using OOPractice;
    using Xunit;

    public class UnitTest1
    {
        [Fact]
        public void Should_show_message_when_speedup_given_a_car()
        {
            Car car = new Car("Cool Car", 30);
            string message = car.SpeedUp();
            Assert.Equal("Cool Car: speed up 30 km/h", message);
        }

        [Fact]
        public void Should_show_message_when_speedup_given_a_truck()
        {
            Truck truck = new Truck("Big Truck", 10);
            string message = truck.SpeedUp();
            Assert.Equal("Big Truck: speed up 10 km/h", message);
        }
    }
}
