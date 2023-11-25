namespace DrivingSimulation.Models
{
	public class MapBlock
	{
        private readonly int positionX;
        private readonly int positionY;

        public MapBlock(int positionX, int positionY)
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

        public MapBlock NorthBlock { get; set; }
        public MapBlock EastBlock { get; set; }
        public MapBlock SouthBlock { get; set; }
        public MapBlock WestBlock { get; set; }
    }
}

