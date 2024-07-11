using Journey.Application.UseCases.Trips.Register;
using Journey.Communication.Requests;
using Journey.Exception.ExceptionsBase;
using Journey.Infrastructure;

namespace Journey.Tests.UseCases.Trips
{
    public class RegisterTripUseCaseTests
    {
        [Fact]
        public void ShouldCreateValidatidateTrip()
        {
            // Arrange
            using (var dbContext = new JourneyDbContext())
            {
                var useCase = new RegisterTripUseCase();

                var request = new RequestRegisterTripJson
                {
                    Name = "Test Trip",
                    StartDate = DateTime.UtcNow.AddDays(1),
                    EndDate = DateTime.UtcNow.AddDays(7)
                };

                // Act
                var result = useCase.Execute(request);

                // Assert
                Assert.NotNull(result);
                Assert.Equal(request.Name, result.Name);
                Assert.Equal(request.StartDate, result.StartDate);
                Assert.Equal(request.EndDate, result.EndDate);
            }

        }

        [Fact]
        public void ShouldCreateNotValidatidateTrip()
        {
            // Arrange
            var useCase = new RegisterTripUseCase();

            var invalidRequest = new RequestRegisterTripJson
            {
                Name = "Test",
                StartDate = DateTime.UtcNow,
                EndDate = DateTime.UtcNow,
            };

            // Act & Assert
            Assert.Throws<ErrorOnValidationException>(() => useCase.Execute(invalidRequest));
        }
    }
}
