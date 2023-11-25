using DrivingSimulation.Models;

namespace DrivingSimulation.Tests.Models
{
	public class MapBlockTest
	{
		[Fact]
		public void GetNorthBlock_ReturnsNorthBlock()
		{
			var mapBlockNorth = new MapBlock(6, 5);
            var mapBlockEast = new MapBlock(5, 5);
            var mapBlockSouth = new MapBlock(4, 5);
            var mapBlockWest = new MapBlock(5, 3);

            var mapBlockCurrent = new MapBlock(4, 5);
			mapBlockCurrent.NorthBlock = mapBlockNorth;
            mapBlockCurrent.EastBlock = mapBlockEast;
            mapBlockCurrent.SouthBlock = mapBlockSouth;
            mapBlockCurrent.WestBlock = mapBlockWest;

            Assert.Equal(mapBlockNorth, mapBlockCurrent.NorthBlock);
        }
	}
}

