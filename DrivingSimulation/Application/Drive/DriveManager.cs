using DrivingSimulation.Application.Drive.Factory;
using DrivingSimulation.Models;
using DrivingSimulation.Models.Enums;

namespace DrivingSimulation.Application.Drive
{
	public class DriveManager : IDriveManager
    {
		private readonly IDriveStrategyFactory driveStrategyFactory;

        public DriveManager(IDriveStrategyFactory driveStrategyFactory)
		{
			this.driveStrategyFactory = driveStrategyFactory;
        }

		public void Drive(VehicleEntity vehicle, CommandEntity command)
		{
			while(command.NextMovement != null)
			{
				var nextMovement = command.NextMovement.Value;

				var driveStrategy = driveStrategyFactory.GetGroupAllocationStrategy(nextMovement);
                (Direction NextDirection, MapBlockEntity NextBlock) response = driveStrategy.Execute(vehicle);

                vehicle.MoveBlock(response.NextDirection, response.NextBlock);
			}
		}
    }
}

