namespace OOPracticeTest
{
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
    }
}
