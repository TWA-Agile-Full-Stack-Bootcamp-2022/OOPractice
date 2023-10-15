namespace OOPracticeTest
{
    using OOPractice;
    using Xunit;

    public class DriverTest
    {
        [Fact]
        public void Should_show_car_message_when_speed_up_given_a_car_with_GasolineEngine()
        {
            // given
            var driver = new Diver();
            Engine gasolineEngine = new GasolineEngine();
            Car car = new Car("A car", gasolineEngine);
            // when
            string message = driver.SpeedUp(car);
            // then
            Assert.Equal("Cool Car: speed up 30 km/h", message);
        }

        [Fact]
        public void Should_show_car_message_when_speed_up_given_a_car_with_ElectricEngine()
        {
            // given
            var driver = new Diver();
            Engine electricEngine = new ElectricEngine();
            Car car = new Car("A car", electricEngine);
            // when
            string message = driver.SpeedUp(car);
            // then
            Assert.Equal("Cool Car: speed up 25 km/h", message);
        }

        [Fact]
        public void Should_should_truck_message_when_speed_up_given_a_truck()
        {
            // given
            var driver = new Diver();
            Truck truck = new Truck("A Truck");
            // when
            string message = driver.SpeedUp(truck);
            // then
            Assert.Equal("Big Truck: speed up 10 km/h", message);
        }
    }
}
