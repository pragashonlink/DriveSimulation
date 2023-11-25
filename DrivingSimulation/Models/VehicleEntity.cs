using DrivingSimulation.Models.Enums;

namespace DrivingSimulation.Models
{
	public class VehicleEntity
	{

		private MapBlockEntity currentBlock;
		private Direction currentDirection;

		public VehicleEntity(MapBlockEntity block, Direction direction)
		{
            currentBlock = block;
            currentDirection = direction;
		}

        public MapBlockEntity GetCurrentBlock
        {
            get
            {
                return currentBlock;
            }
        }

        public Direction GetCurrentDirection
        {
            get
            {
                return currentDirection;
            }
        }

        public void MoveBlock(Direction direction, MapBlockEntity? nextBlock)
		{
            if (nextBlock == null)
            {
                throw new InvalidOperationException("Invalid movement");
            }

            currentDirection = direction;
            currentBlock = nextBlock;
        }

    }
}

