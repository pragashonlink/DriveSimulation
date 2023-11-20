using DrivingSimulation.Models.Eenums;

namespace DrivingSimulation.Models
{
	public class Command
	{
        private readonly Movement _currentMovement;

        public Command(Movement currentMovement)
		{
            _currentMovement = currentMovement;
		}

        public Movement NextMovement { get; set; }

        public Movement PreviousMovement { get; set; }

        public Movement CurrentMovement
        {
            get
            {
                return _currentMovement;
            }
        }
	}
}

