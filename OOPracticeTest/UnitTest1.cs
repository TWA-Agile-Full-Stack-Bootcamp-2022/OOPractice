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

        public class CarTest
        {
            [Fact]
            public void Should_return_name_and_speed_when_speedup_given_car_with_name_Cool_Car_and_speed_250()
            {
                //given
                var car = new Car("Cool Car", 30);
                //when
                var show = car.Speedup();
                //then
                Assert.Equal("Cool Car: speed up 30 km/h", show);
            }

            [Fact]
            public void Should_return_name_and_speed_when_speedup_given_truck_with_name_Cool_Car_and_speed_250()
            {
                //given
                var truck = new Truck("Big Truck", 10);
                //when
                var show = truck.Speedup();
                //then
                Assert.Equal("Big Truck: speed up 10 km/h", show);
            }

            [Fact]
            public void Should_return_name_and_speed_when_driver_diver_car_given_car_with_name_Cool_Car_and_speed_250()
            {
                //given
                var car = new Car("Cool Car", 30);
                var driver = new Driver();
                //when
                var show = driver.Drive(car);
                //then
                Assert.Equal("Cool Car: speed up 30 km/h", show);
            }

            [Fact]
            public void Should_return_name_and_speed_when_driver_diver_truck_given_truck_with_name_Cool_Car_and_speed_250()
            {
                //given
                var truck = new Truck("Big Truck", 10);
                var driver = new Driver();
                //when
                var show = driver.Drive(truck);
                //then
                Assert.Equal("Big Truck: speed up 10 km/h", show);
            }

            [Fact]
            public void Should_return_name_and_speed_30_when_driver_diver_vehicle_given_vehicle_with_gasoline_engine()
            {
                //given
                var engine = new Engine(EngineType.Gasoline);
                var truck = new Truck("Big Truck", engine);
                var driver = new Driver();
                //when
                var show = driver.Drive(truck);
                //then
                Assert.Equal("Big Truck: speed up 30 km/h", show);
            }

            [Fact]
            public void Should_return_name_and_speed_25_when_driver_diver_vehicle_given_vehicle_with_electric_engine()
            {
                //given
                var engine = new Engine(EngineType.Electric);
                var truck = new Truck("Big Truck", engine);
                var driver = new Driver();
                //when
                var show = driver.Drive(truck);
                //then
                Assert.Equal("Big Truck: speed up 25 km/h", show);
            }

            [Fact]
            public void Should_return_name_and_speed_30_when_driver_diver_car_given_vehicle_with_gasoline_engine()
            {
                //given
                var engine = new Engine(EngineType.Gasoline);
                var truck = new Car("Cool Car", engine);
                var driver = new Driver();
                //when
                var show = driver.Drive(truck);
                //then
                Assert.Equal("Cool Car: speed up 30 km/h", show);
            }

            [Fact]
            public void Should_return_name_and_speed_25_when_driver_diver_car_given_vehicle_with_electric_engine()
            {
                //given
                var engine = new Engine(EngineType.Electric);
                var truck = new Car("Cool Car", engine);
                var driver = new Driver();
                //when
                var show = driver.Drive(truck);
                //then
                Assert.Equal("Cool Car: speed up 25 km/h", show);
            }
        }
    }
}
