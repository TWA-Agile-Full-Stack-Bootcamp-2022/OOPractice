namespace OOPracticeTest
{
    using System.Collections.Generic;
    using OOPractice;
    using Xunit;

    public class DriverTest
    {
        public static IEnumerable<object[]> Engines() =>
        new List<object[]>
        {
            new object[] { new GasolineEngine(), "Cool Car: speed up 30 km/h" },
            new object[] { new ElectricEngine(), "Cool Car: speed up 25 km/h" },
        };

        [Theory]
        [MemberData(nameof(Engines))]
        public void Should_show_message_with_name_and_speed_when_drive_a_car(IEngine engine, string expectedMessage)
        {
            // given
            IVehicle vehicle = new Car("Cool Car", engine);

            // when
            string message = Driver.Drive(vehicle);

            // then
            Assert.Equal(expectedMessage, message);
        }

        [Fact]
        public void Should_show_message_with_name_and_speed_when_drive_a_truck()
        {
            // given
            IVehicle vehicle = new Truck("Big Truck");

            // when
            string message = Driver.Drive(vehicle);

            // then
            Assert.Equal("Big Truck: speed up 10 km/h", message);
        }
    }
}
