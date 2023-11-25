using System;
using DrivingSimulation.Models;
using DrivingSimulation.Models.Enums;

namespace DrivingSimulation.Application.Drive.Strategy
{
	public class RightDriveStrategy : IDriveStrategy
    {
        public (Direction nextDirection, MapBlockEntity nextBlock) Execute(VehicleEntity vehicleEntity)
        {
            var currentBlock = vehicleEntity.GetCurrentBlock;
            var currentDirection = vehicleEntity.GetCurrentDirection;
            var nextDirection = currentDirection;
            var nextBlock = currentBlock;

            if (currentDirection == Direction.NORTH)
            {
                nextDirection = Direction.EAST;
                nextBlock = currentBlock.EastBlock;
            }
            else if (currentDirection == Direction.EAST)
            {
                nextDirection = Direction.SOUTH;
                nextBlock = currentBlock.SouthBlock;
            }
            else if (currentDirection == Direction.SOUTH)
            {
                nextDirection = Direction.WEST;
                nextBlock = currentBlock.WestBlock;
            }
            else if (currentDirection == Direction.WEST)
            {
                nextDirection = Direction.NORTH;
                nextBlock = currentBlock.NorthBlock;
            }

            return (nextDirection, nextBlock);
        }
    }
}

