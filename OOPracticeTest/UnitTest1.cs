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
            Car car = new Car("Cool Car", new GasolineEngine());
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

        [Fact]
        public void Should_show_message_when_Driver_drive_given_a_car()
        {
            Driver driver = new Driver();
            string message = driver.Drive(new Car("Cool Car", new GasolineEngine()));
            Assert.Equal("Cool Car: speed up 30 km/h", message);
        }

        [Fact]
        public void Should_show_message_when_Driver_drive_given_a_truck()
        {
            Driver driver = new Driver();
            string message = driver.Drive(new Truck("Big Truck", 10));
            Assert.Equal("Big Truck: speed up 10 km/h", message);
        }

        [Fact]
        public void Should_show_message_when_speedup_given_a_car_with_gasoline_engine()
        {
            Car car = new Car("Cool Car", new GasolineEngine());
            string message = car.SpeedUp();
            Assert.Equal("Cool Car: speed up 30 km/h", message);
        }

        [Fact]
        public void Should_show_message_when_speedup_given_a_car_with_electric_engine()
        {
            Car car = new Car("Cool Car", new ElectricEngine());
            string message = car.SpeedUp();
            Assert.Equal("Cool Car: speed up 25 km/h", message);
        }
    }
}
