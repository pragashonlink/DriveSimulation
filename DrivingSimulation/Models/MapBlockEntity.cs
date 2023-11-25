namespace DrivingSimulation.Models
{
	public class MapBlockEntity
	{
        private readonly int positionX;
        private readonly int positionY;

        public MapBlockEntity(int positionX, int positionY)
        {
            this.positionX = positionX;
            this.positionY = positionY;
        }

        public int GetPositionX
        {
            get
            {
                return positionX;
            }
        }

        public int GetPositionY
        {
            get
            {
                return positionY;
            }
        }

        public MapBlockEntity NorthBlock { get; set; }
        public MapBlockEntity EastBlock { get; set; }
        public MapBlockEntity SouthBlock { get; set; }
        public MapBlockEntity WestBlock { get; set; }
    }
}

