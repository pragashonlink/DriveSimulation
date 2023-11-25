using DrivingSimulation.Models;
using DrivingSimulation.Models.Enums;

namespace DrivingSimulation.Tests.Models
{
	public class UserMovementEntityTest
	{
        [Fact]
        public void GetMovements_ReturnsMovement()
        {
            var userMovementInput = "FRLFFR";
            var userMovement = new UserMovementEntity(userMovementInput);
            var mappedMovements = userMovement.GetMovements;

            var exepectedMovements = new List<MovementType>()
            {
                MovementType.FORWARD,
                MovementType.RIGHT,
                MovementType.LEFT,
                MovementType.FORWARD,
                MovementType.FORWARD,
                MovementType.RIGHT
            };

            var isTrue = exepectedMovements.SequenceEqual(mappedMovements);

            Assert.True(isTrue);
        }
    }
}

