using DrivingSimulation.Models;

namespace DrivingSimulation.Application.Drive
{
	public class DriveManager
	{
		public void drive(Vehicle vehicle, Command command)
		{
			while(command.NextMovement != null)
			{
				vehicle.Move(command.NextMovement.Value);
			}
		}
    }
}

