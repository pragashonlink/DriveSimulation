using System;
using DrivingSimulation.Application.Drive.Strategy;
using DrivingSimulation.Models.Enums;

namespace DrivingSimulation.Application.Drive.Factory
{
    public class DriveStrategyFactory : IDriveStrategyFactory
    {
        public IDriveStrategy GetGroupAllocationStrategy(MovementType movementType)
        {
            if (movementType == MovementType.FORWARD)
                return new ForwardDriveStrategy();
            else if (movementType == MovementType.RIGHT)
                return new RightDriveStrategy();
            else
                return new LeftDriveStrategy();
        }
    }
}

