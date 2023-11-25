using System;
using DrivingSimulation.Models;
using DrivingSimulation.Models.Enums;

namespace DrivingSimulation.Application.Drive
{
	public interface IDriveManager
	{
		void Drive(VehicleEntity vehicle, CommandEntity command);
	}
}

