using Journey.Application.UseCases.Trips.Delete;
using Journey.Infrastructure;

namespace Validators.Test.UseCasesTests.TripsTests.Delete
{
    public class DeleteTripByIdUseCaseTests
    {
        [Fact]
        public void ShouldDeleteTripAnId() 
        {
            using (var dbContext = new JourneyDbContext())
            {
            // Arrange
            // TripId from the database
            var tripId = "F43FD550-5F8B-485F-9D31-906AB43EDCC9";
            Guid guidTripId = Guid.Parse(tripId);

            var useCase = new DeleteTripByIdUseCase();
            var deletedTrip = dbContext.Trips.FirstOrDefault(t => t.Id == guidTripId);

            // Act
            var trip = dbContext.Trips.FirstOrDefault(t => t.Id == guidTripId);
            Assert.NotNull(trip);

            if (trip != null)
            {
                useCase.Execute(guidTripId);
            }
            

            // Assert
                Assert.Null(deletedTrip); 
            }
        }
    }
}
