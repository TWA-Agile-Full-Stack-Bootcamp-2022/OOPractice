namespace OOPracticeTest
{
    using OOPractice;
    using Xunit;

    public class CarTest
    {
        [Fact]
        public void Should_show_car_message()
        {
            // given
            var coolCar = new Car("A Car");
            // when
            string message = coolCar.ShowMessage();
            // then
            Assert.Equal("Cool Car: speed up 30 km/h", message);
        }
    }
}
