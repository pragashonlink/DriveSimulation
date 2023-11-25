using DrivingSimulation.Models.Enums;

namespace DrivingSimulation.Models
{
	public class Vehicle
	{

		private MapBlock currentBlock;
		private Direction currentDirection;

		public Vehicle(MapBlock block, Direction direction)
		{
            currentBlock = block;
            currentDirection = direction;
		}

        public MapBlock GetCurrentBlock
        {
            get
            {
                return currentBlock;
            }
        }

		public void Move(Movement movement)
		{
            var nextBlock = GetNextBlock(movement);

            if (nextBlock == null)
            {
                throw new Exception("Invalid movement");
            }

            currentBlock = nextBlock;
        }

		private MapBlock? GetNextBlock(Movement movement)
		{
            MapBlock? nextBlock = null;

			if (currentDirection == Direction.NORTH && movement == Movement.FORWARD)
			{
                nextBlock = currentBlock.NorthBlock;
			}
			else if (currentDirection == Direction.NORTH && movement == Movement.RIGHT)
			{
				currentDirection = Direction.EAST;
                nextBlock = currentBlock.EastBlock;
			}
            else if (currentDirection == Direction.NORTH && movement == Movement.LEFT)
            {
				currentDirection = Direction.WEST;
                nextBlock = currentBlock.WestBlock;
            }
            else if (currentDirection == Direction.EAST && movement == Movement.FORWARD)
            {
                nextBlock = currentBlock.EastBlock;
            }
            else if (currentDirection == Direction.EAST && movement == Movement.RIGHT)
            {
                currentDirection = Direction.SOUTH;
                nextBlock = currentBlock.SouthBlock;
            }
            else if (currentDirection == Direction.EAST && movement == Movement.LEFT)
            {
                currentDirection = Direction.NORTH;
                nextBlock = currentBlock.NorthBlock;
            }
            else if (currentDirection == Direction.SOUTH && movement == Movement.FORWARD)
            {
                nextBlock = currentBlock.SouthBlock;
            }
            else if (currentDirection == Direction.SOUTH && movement == Movement.RIGHT)
            {
                currentDirection = Direction.WEST;
                nextBlock = currentBlock.WestBlock;
            }
            else if (currentDirection == Direction.SOUTH && movement == Movement.LEFT)
            {
                currentDirection = Direction.EAST;
                nextBlock = currentBlock.EastBlock;
            }
            else if (currentDirection == Direction.WEST && movement == Movement.FORWARD)
            {
                nextBlock = currentBlock.WestBlock;
            }
            else if (currentDirection == Direction.WEST && movement == Movement.RIGHT)
            {
                currentDirection = Direction.NORTH;
                nextBlock = currentBlock.NorthBlock;
            }
            else if (currentDirection == Direction.WEST && movement == Movement.LEFT)
            {
                currentDirection = Direction.SOUTH;
                nextBlock = currentBlock.SouthBlock;
            }

            return nextBlock;
        }

        //public MapBlock CurrentBlock { set; }
        //public Direction CurrentDirection { set; }
    }
}

