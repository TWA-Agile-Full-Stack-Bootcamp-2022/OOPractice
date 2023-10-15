namespace OOPracticeTest
{
    using OOPractice;
    using Xunit;

    public class TruckTest
    {
        [Fact]
        public void Should_show_truck_message()
        {
            // given
            var bigTruck = new Truck("A Truck");
            // when
            string message = bigTruck.ShowMessage();
            // then
            Assert.Equal("Big Truck: speed up 10 km/h", message);
        }
    }
}
