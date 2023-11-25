using DrivingSimulation.Models.Enums;

namespace DrivingSimulation.Models
{
	public class CommandEntity
	{
        private readonly MovementType _currentMovement;

        public CommandEntity(MovementType currentMovement)
		{
            _currentMovement = currentMovement;
		}

        public MovementType? NextMovement { get; set; }

        public MovementType? PreviousMovement { get; set; }

        public MovementType CurrentMovement
        {
            get
            {
                return _currentMovement;
            }
        }
	}
}

