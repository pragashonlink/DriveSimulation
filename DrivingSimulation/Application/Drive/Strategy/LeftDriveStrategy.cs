using DrivingSimulation.Models;
using DrivingSimulation.Models.Enums;

namespace DrivingSimulation.Application.Drive.Strategy
{
	public class LeftDriveStrategy : IDriveStrategy
    {
        public (Direction nextDirection, MapBlockEntity nextBlock) Execute(VehicleEntity vehicleEntity)
        {
            var currentBlock = vehicleEntity.GetCurrentBlock;
            var currentDirection = vehicleEntity.GetCurrentDirection;
            var nextDirection = currentDirection;
            var nextBlock = currentBlock;

            if (currentDirection == Direction.NORTH)
            {
                nextDirection = Direction.WEST;
                nextBlock = currentBlock.WestBlock;
            }
            else if (currentDirection == Direction.EAST)
            {
                nextDirection = Direction.NORTH;
                nextBlock = currentBlock.NorthBlock;
            }
            else if (currentDirection == Direction.SOUTH)
            {
                nextDirection = Direction.EAST;
                nextBlock = currentBlock.EastBlock;
            }
            else if (currentDirection == Direction.WEST)
            {
                nextDirection = Direction.SOUTH;
                nextBlock = currentBlock.SouthBlock;
            }

            return (nextDirection, nextBlock);
        }
    }
}

