using System;
using DrivingSimulation.Models;
using DrivingSimulation.Models.Enums;

namespace DrivingSimulation.Application.Drive
{
	public interface IDriveManager
	{
		void drive(MapBlock mapBlock, Direction direction, Command command);
	}
}

