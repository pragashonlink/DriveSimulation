using System;
using DrivingSimulation.Application.Drive.Strategy;
using DrivingSimulation.Models.Enums;

namespace DrivingSimulation.Application.Drive.Factory
{
	public interface IDriveStrategyFactory
    {
        IDriveStrategy GetGroupAllocationStrategy(MovementType movementType);
    }
}

