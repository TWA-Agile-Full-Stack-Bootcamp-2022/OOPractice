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
    }
}
