using System;
using DrivingSimulation.Models;
using DrivingSimulation.Models.Enums;

namespace DrivingSimulation.Application.Drive.Strategy
{
	public interface IDriveStrategy
	{
        (Direction nextDirection, MapBlockEntity nextBlock) Execute(VehicleEntity vehicleEntity);
    }
}

