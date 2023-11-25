using DrivingSimulation.Models;
using DrivingSimulation.Models.Enums;

namespace DrivingSimulation.Tests.Models
{
	public class CommandEntityTest
	{
		[Fact]
		public void GetCurrentCommand_ReturnsCurrentCommand()
		{
			var command = new CommandEntity(MovementType.RIGHT);

			Assert.Equal(MovementType.RIGHT, command.CurrentMovement);
		}

        [Fact]
        public void SetPreviousCommand_SetsPreviousCommand()
        {
            var command = new CommandEntity(MovementType.RIGHT);
			command.PreviousMovement = MovementType.LEFT;

            Assert.Equal(MovementType.LEFT, command.PreviousMovement);
        }

        [Fact]
        public void SetNextCommand_SetsNextCommand()
        {
            var command = new CommandEntity(MovementType.RIGHT);
            command.NextMovement = MovementType.LEFT;

            Assert.Equal(MovementType.LEFT, command.NextMovement);
        }
    }
}

