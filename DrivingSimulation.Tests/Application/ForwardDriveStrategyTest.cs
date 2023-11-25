using DrivingSimulation.Application.Drive.Strategy;
using DrivingSimulation.Models;
using DrivingSimulation.Models.Enums;

namespace DrivingSimulation.Tests.Application
{
	public class ForwardDriveStrategyTest
    {
		[Fact]
		void Execute_ShouldReturnVehicleDirection()
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

            var forwardDriveStrategy = new ForwardDriveStrategy();
            (Direction NextDirection, MapBlockEntity NextBlock) response = forwardDriveStrategy.Execute(vehicle);

            Assert.Equal(northBlock, response.NextBlock);
        }

    }
}

