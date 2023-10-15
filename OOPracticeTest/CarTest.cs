namespace OOPracticeTest
{
    using OOPractice;
    using System;
    using Xunit;

    public class CarTest
    {
        [Fact]
        public void Should_show_car_message_with_GasolineEngine()
        {
            // given
            Engine gasolineEngine = new GasolineEngine();
            var coolCar = new Car("A Car", gasolineEngine);
            // when
            string message = coolCar.ShowMessage();
            // then
            Assert.Equal("Cool Car: speed up 30 km/h", message);
        }

        [Fact]
        public void Should_show_car_message_with_ElectricEngine()
        {
            // given
            Engine electricEngine = new ElectricEngine();
            var coolCar = new Car("A Car", electricEngine);
            // when
            string message = coolCar.ShowMessage();
            // then
            Assert.Equal("Cool Car: speed up 25 km/h", message);
        }
    }
}
