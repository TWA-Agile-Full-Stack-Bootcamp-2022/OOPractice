namespace OOPracticeTest
{
    using System.Collections.Generic;
    using OOPractice;
    using Xunit;

    public class CarTest
    {
        public static IEnumerable<object[]> Engines() =>
        new List<object[]>
        {
            new object[] { new GasolineEngine(), "Cool Car: speed up 30 km/h" },
            new object[] { new ElectricEngine(), "Cool Car: speed up 25 km/h" },
        };

        [Theory]
        [MemberData(nameof(Engines))]
        public void Should_show_message_with_name_and_speed_when_speedup(IEngine engine, string expectedMessage)
        {
            // given
            IVehicle vehicle = new Car("Cool Car", engine);

            // when
            string message = vehicle.SpeedUp();

            // then
            Assert.Equal(expectedMessage, message);
        }
    }
}
