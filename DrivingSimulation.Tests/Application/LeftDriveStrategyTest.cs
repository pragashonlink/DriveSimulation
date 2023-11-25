using DrivingSimulation.Application.Drive.Strategy;
using DrivingSimulation.Models;
using DrivingSimulation.Models.Enums;

namespace DrivingSimulation.Tests.Application
{
	public class LeftDriveStrategyTest
	{
        [Fact]
        void Execute_ShouldReturnVehicleDirection()
        {
            var currentBlock = new MapBlockEntity(4, 5);
            currentBlock.NorthBlock = new MapBlockEntity(6, 5);
            currentBlock.EastBlock = new MapBlockEntity(5, 5);
            currentBlock.SouthBlock = new MapBlockEntity(4, 5);
            currentBlock.WestBlock = new MapBlockEntity(5, 3);

            var vehicle = new VehicleEntity(currentBlock, Direction.NORTH);

            var leftDriveStrategy = new LeftDriveStrategy();
            (Direction NextDirection, MapBlockEntity NextBlock) response = leftDriveStrategy.Execute(vehicle);

            Assert.Equal(currentBlock.WestBlock, response.NextBlock);
        }
    }
}

