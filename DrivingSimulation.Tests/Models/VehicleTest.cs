using System;
using DrivingSimulation.Models;

namespace DrivingSimulation.Tests.Models
{
	public class VehicleTest
	{
		[Fact]
		void GetCurrentBlock_ReturnsCurrentBlock()
		{
			var expectedCurrentBlock = new MapBlock(0, 1);

			var vehicle = new Vehicle(expectedCurrentBlock, DrivingSimulation.Models.Enums.Direction.NORTH);

			Assert.Equal(expectedCurrentBlock.GetPositionX, vehicle.GetCurrentBlock.GetPositionX);
		}

        [Fact]
		void Move_ShouldMoveVehicleToNextBlock()
		{
            var northBlock = new MapBlock(6, 5);
            var eastBlock = new MapBlock(5, 5);
            var southBlock = new MapBlock(4, 5);
            var westBlock = new MapBlock(5, 3);

            var currentBlock = new MapBlock(4, 5);
            currentBlock.NorthBlock = northBlock;
            currentBlock.EastBlock = eastBlock;
            currentBlock.SouthBlock = southBlock;
            currentBlock.WestBlock = westBlock;

            var vehicle = new Vehicle(currentBlock, DrivingSimulation.Models.Enums.Direction.NORTH);

            vehicle.Move(DrivingSimulation.Models.Enums.Movement.RIGHT);

            Assert.Equal(eastBlock, vehicle.GetCurrentBlock);
        }

    }
}

