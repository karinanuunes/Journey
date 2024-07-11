using Journey.Application.UseCases.Trips.GetById;

namespace Validators.Test.UseCasesTests.TripsTests.GetBydIdTests
{
    public class GetTripByIdUseCaseTests
    {
        [Fact]
        public void ShouldReturnTripById()
        {
            // Arrange
            var useCase = new GetTripByIdUseCase();

            // Act
            string tripId = "3FA85F64-5717-4562-B3FC-2C963F66AFA6";
            Guid isGuidTripId = Guid.Parse(tripId);

            var result = useCase.Execute(isGuidTripId);

            // Assert
            Assert.NotNull(result);
        }
    }
}
