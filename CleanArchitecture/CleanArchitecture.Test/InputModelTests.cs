using CleanArchitecture.Application.InputModels;

namespace CleanArchitecture.Test
{
    [Trait(nameof(CleanArchitecture), "Clean Architecture")]

    public class InputModelTests
    {
        [Fact]
        public void Should_Return_With_Two_Notifications()
        {
            var carInputModel = new CarInputModel(1, "", "");

            Assert.Equal(2, carInputModel.Notifications.Count);
        }
        [Fact]
        public void Should_Return_With_One_Notifications()
        {
            var carInputModel = new CarInputModel(1, "Tiggo 2", "");

            Assert.Equal(1, carInputModel.Notifications.Count);
        }
    }
}