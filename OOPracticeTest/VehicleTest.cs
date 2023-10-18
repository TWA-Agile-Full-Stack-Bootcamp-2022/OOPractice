namespace OOPracticeTest
{
    using Newtonsoft.Json.Linq;
    using OOPractice;
    using System;
    using Xunit;

    public class CarTest
    {
        [Fact]
        public void Should_show_car_info()
        {
            Car car = new Car();
            string value = car.Speedup();
            Assert.Equal("Cool Car: speed up 30 km/h", value);
        }

        [Fact]
        public void Should_be_25_when_with_elecEngine()
        {
            Car car = new Car(new ElectricEngine());
            Assert.Equal("Cool Car: speed up 25 km/h", car.Speedup());
        }
    }

    public class TruckTest
    {
        [Fact]
        public void Should_show_when_truck_speedup()
        {
            var truck = new Truck();
            Assert.Equal("Big Truck:speed up 10km/h", truck.Speedup());
        }
    }

    public class DriverTest
    {
        [Fact]
        public void Should_show_different_msg_when_drive_can_and_truck()
        {
            var driver = new Driver();
            Assert.Equal("Cool Car: speed up 30 km/h", driver.Drive(new Car()));
            Assert.Equal("Big Truck:speed up 10km/h", driver.Drive(new Truck()));
        }
    }
}
