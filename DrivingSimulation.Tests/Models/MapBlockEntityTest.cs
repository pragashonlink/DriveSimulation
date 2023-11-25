using DrivingSimulation.Models;

namespace DrivingSimulation.Tests.Models
{
	public class MapBlockEntityTest
	{
		[Fact]
		public void GetNorthBlock_ReturnsNorthBlock()
		{
			var mapBlockNorth = new MapBlockEntity(6, 5);
            var mapBlockEast = new MapBlockEntity(5, 5);
            var mapBlockSouth = new MapBlockEntity(4, 5);
            var mapBlockWest = new MapBlockEntity(5, 3);

            var mapBlockCurrent = new MapBlockEntity(4, 5);
			mapBlockCurrent.NorthBlock = mapBlockNorth;
            mapBlockCurrent.EastBlock = mapBlockEast;
            mapBlockCurrent.SouthBlock = mapBlockSouth;
            mapBlockCurrent.WestBlock = mapBlockWest;

            Assert.Equal(mapBlockNorth, mapBlockCurrent.NorthBlock);
        }
	}
}

