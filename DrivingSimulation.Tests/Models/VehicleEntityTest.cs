using DrivingSimulation.Models.Enums;
using DrivingSimulation.Models;

namespace DrivingSimulation.Tests.Models
{
	public class VehicleEntityTest
	{
		[Fact]
		void GetCurrentBlock_ReturnsCurrentBlock()
		{
			var expectedCurrentBlock = new MapBlockEntity(0, 1);

			var vehicle = new VehicleEntity(expectedCurrentBlock, DrivingSimulation.Models.Enums.Direction.NORTH);

			Assert.Equal(expectedCurrentBlock.GetRow, vehicle.GetCurrentBlock.GetRow);
		}

        [Fact]
		void Move_ShouldMoveVehicleToNextBlock()
		{
            var northBlock = new MapBlockEntity(6, 5);
            var eastBlock = new MapBlockEntity(5, 5);
            var southBlock = new MapBlockEntity(4, 5);
            var westBlock = new MapBlockEntity(5, 3);

            var currentBlock = new MapBlockEntity(4, 5);
            currentBlock.NorthBlock = northBlock;
            currentBlock.EastBlock = eastBlock;
            currentBlock.SouthBlock = southBlock;
            currentBlock.WestBlock = westBlock;

            var vehicle = new VehicleEntity(currentBlock, Direction.NORTH);

            vehicle.MoveBlock(Direction.EAST, eastBlock);

            Assert.Equal(eastBlock, vehicle.GetCurrentBlock);
        }

        [Fact]
        void Move_ThrowExceptionWhenOutOfBlock()
        {
            var northBlock = new MapBlockEntity(6, 5);
            var southBlock = new MapBlockEntity(4, 5);
            var westBlock = new MapBlockEntity(5, 3);

            var currentBlock = new MapBlockEntity(4, 5);
            currentBlock.NorthBlock = northBlock;
            currentBlock.SouthBlock = southBlock;
            currentBlock.WestBlock = westBlock;

            var vehicle = new VehicleEntity(currentBlock, Direction.NORTH);

            Assert.Throws<InvalidOperationException>(() => vehicle.MoveBlock(Direction.EAST, null));
        }

    }
}

