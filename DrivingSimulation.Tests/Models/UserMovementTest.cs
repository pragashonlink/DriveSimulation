using DrivingSimulation.Models;
using DrivingSimulation.Models.Enums;

namespace DrivingSimulation.Tests.Models
{
	public class UserMovementTest
	{
        [Fact]
        public void GetMovements_ReturnsMovement()
        {
            var userMovementInput = "FRLFFR";
            var userMovement = new UserMovement(userMovementInput);
            var mappedMovements = userMovement.GetMovements;

            var exepectedMovements = new List<Movement>()
            {
                Movement.FORWARD,
                Movement.RIGHT,
                Movement.LEFT,
                Movement.FORWARD,
                Movement.FORWARD,
                Movement.RIGHT
            };

            var isTrue = exepectedMovements.SequenceEqual(mappedMovements);

            Assert.True(isTrue);
        }
    }
}

