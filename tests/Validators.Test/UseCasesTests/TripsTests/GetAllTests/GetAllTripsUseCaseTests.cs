using Journey.Application.UseCases.Trips.GetAll;

namespace Validators.Test.UseCasesTests.TripsTests.GetAllTests
{
    public class GetAllTripsUseCaseTests
    {
        [Fact]
        public void ShouldReturnAllTrips()
        {
            // Arrange
            var useCase = new GetAllTripsUseCase();

            // Act
            var result = useCase.Execute();

            // Assert
            Assert.NotNull(result);
        }
    }
}
