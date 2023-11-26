using DrivingSimulation.Models.Enums;
using DrivingSimulation.Utils;

namespace DrivingSimulation.Tests.Utils
{
	public class StringExtensionsTest
	{
        [Fact]
        public void InputAsNumber_ReturnsIntFromString()
        {
            var input = "FRLFFR";
            var mappedMovements = input.InputToMovementType();

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

