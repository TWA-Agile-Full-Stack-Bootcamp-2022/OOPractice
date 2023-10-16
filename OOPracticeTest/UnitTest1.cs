namespace OOPracticeTest
{
    using OOPractice;
    using Xunit;

    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var class1 = new Class1();
            Assert.NotNull(class1);
        }

        [Fact]
        public void Should_return_name_and_speed_when_speedup_given_car_name_and_speed()
        {
            //given
            var car = new Car("Cool Car", 30);
            //when
            var actual = car.Speedup();
            //then
            Assert.Equal("Cool Car: speed up 30 km/h", actual);
        }

        [Fact]
        public void Should_return_name_and_speed_when_speedup_given_truck_name_and_speed()
        {
            var truck = new Truck("Big Truck", 20);
            var actual = truck.Speedup();
            Assert.Equal("Big Truck: speed up 20 km/h", actual);
        }

        [Fact]
        public void Should_return_name_and_speed_when_driver_drive_car()
        {
            var car = new Car("Cool Car", 30);
            var driver = new Driver();
            var actual = driver.Drive(car);

            Assert.Equal("Cool Car: speed up 30 km/h", actual);
        }

        [Fact]
        public void Should_return_name_and_speed_when_driver_drive_truck()
        {
            var truck = new Truck("Big Truck", 20);
            var driver = new Driver();
            var actual = driver.Drive(truck);

            Assert.Equal("Big Truck: speed up 20 km/h", actual);
        }

        [Fact]
        public void Should_return_name_and_speed_when_Car_engine_is_GAS()
        {
            var car = new Car("Cool Car", Engine.GAS);
            var actual = car.Speedup();

            Assert.Equal("Cool Car: speed up 30 km/h", actual);
        }

        [Fact]
        public void Should_return_name_and_speed_when_Car_engine_is_ELECTRIC()
        {
            var car = new Car("Cool Car", Engine.ELECTRIC);
            var actual = car.Speedup();

            Assert.Equal("Cool Car: speed up 25 km/h", actual);
        }

        [Fact]
        public void Should_return_name_and_speed_when_Truck_engine_is_GAS()
        {
            var truck = new Truck("Big Truck", Engine.GAS);
            var actual = truck.Speedup();

            Assert.Equal("Big Truck: speed up 30 km/h", actual);
        }

        [Fact]
        public void Should_return_name_and_speed_when_Truck_engine_is_ELECTRIC()
        {
            var truck = new Truck("Big Truck", Engine.ELECTRIC);
            var actual = truck.Speedup();

            Assert.Equal("Big Truck: speed up 25 km/h", actual);
        }
    }
}
