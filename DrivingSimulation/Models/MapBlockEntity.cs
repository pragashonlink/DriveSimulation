namespace DrivingSimulation.Models
{
public class MapBlockEntity
	{
        private readonly int row;
        private readonly int col;

        public MapBlockEntity(int row, int col)
        {
            this.row = row;
            this.col = col;
        }

        public int GetRow
        {
            get
            {
                return row;
            }
        }

        public int GetCol
        {
            get
            {
                return col;
            }
        }

        public MapBlockEntity? NorthBlock { get; set; }
        public MapBlockEntity? EastBlock { get; set; }
        public MapBlockEntity? SouthBlock { get; set; }
        public MapBlockEntity? WestBlock { get; set; }
    }
}

