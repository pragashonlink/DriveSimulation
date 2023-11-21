using DrivingSimulation.Models;

namespace DrivingSimulation.Tests.Models
{
	public class MapBlockTest
	{
		[Fact]
		public void GetNorthBlock_ReturnsNorthBlock()
		{
			var mapBlockNorth = new MapBlock();
            var mapBlockEast = new MapBlock();
            var mapBlockSouth = new MapBlock();
            var mapBlockWest = new MapBlock();

            var mapBlockCurrent = new MapBlock();
			mapBlockCurrent.NorthBlock = mapBlockNorth;
            mapBlockCurrent.EastBlock = mapBlockEast;
            mapBlockCurrent.SouthBlock = mapBlockSouth;
            mapBlockCurrent.WestBlock = mapBlockWest;

            Assert.Equal(mapBlockNorth, mapBlockCurrent.NorthBlock);
        }
	}
}

