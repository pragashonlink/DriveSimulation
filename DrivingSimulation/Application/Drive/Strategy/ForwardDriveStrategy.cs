using DrivingSimulation.Models;
using DrivingSimulation.Models.Enums;

namespace DrivingSimulation.Application.Drive.Strategy
{
    public class ForwardDriveStrategy : IDriveStrategy
    {
        public (Direction nextDirection, MapBlockEntity nextBlock) Execute(VehicleEntity vehicleEntity)
        {
            var currentBlock = vehicleEntity.GetCurrentBlock;
            var currentDirection = vehicleEntity.GetCurrentDirection;
            var nextBlock = currentBlock;

            if (currentDirection == Direction.NORTH)
            {
                nextBlock = currentBlock.NorthBlock;
            }
            else if (currentDirection == Direction.EAST)
            {
                
                nextBlock = currentBlock.EastBlock;
            }
            else if (currentDirection == Direction.SOUTH)
            {
                nextBlock = currentBlock.SouthBlock;
            }
            else if (currentDirection == Direction.WEST)
            {
                nextBlock = currentBlock.WestBlock;
            }

            var nextDirection = vehicleEntity.GetCurrentDirection;

            return  ( nextDirection, nextBlock );
        }
    }
}

