using DrivingSimulation.Models;
using DrivingSimulation.Models.Eenums;

namespace DrivingSimulation.Tests.Models
{
	public class CommandTest
	{
		[Fact]
		public void GetCurrentCommand_ReturnsCurrentCommand()
		{
			var command = new Command(Movement.RIGHT);

			Assert.Equal(Movement.RIGHT, command.CurrentMovement);
		}

        [Fact]
        public void SetPreviousCommand_SetsPreviousCommand()
        {
            var command = new Command(Movement.RIGHT);
			command.PreviousMovement = Movement.LEFT;

            Assert.Equal(Movement.LEFT, command.PreviousMovement);
        }

        [Fact]
        public void SetNextCommand_SetsNextCommand()
        {
            var command = new Command(Movement.RIGHT);
            command.NextMovement = Movement.LEFT;

            Assert.Equal(Movement.LEFT, command.NextMovement);
        }
    }
}

