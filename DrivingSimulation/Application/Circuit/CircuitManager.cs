using DrivingSimulation.Models;

namespace DrivingSimulation.Application.Circuit
{
    public class CircuitManager : ICircuitManager
    {

        private MapBlockEntity[,] mapCircuit;

        public void BuildCircuit()
        {
            mapCircuit = new MapBlockEntity[CircuitOption.MAX_ROWS, CircuitOption.MAX_COLS];

            for (var row = 0; row < CircuitOption.MAX_ROWS; row++)
            {
                for (var col = 0; col < CircuitOption.MAX_COLS; col++)
                {
                    var currentBlock = GetMapBlock(row, col);
                    var northBlock = GetMapBlock(row + 1, col);
                    var eastBlock = GetMapBlock(row, col + 1);
                    var southBlock = GetMapBlock(row - 1, col);
                    var westBlock = GetMapBlock(row, col - 1);

                    currentBlock.NorthBlock = northBlock;
                    currentBlock.EastBlock = eastBlock;
                    currentBlock.SouthBlock = southBlock;
                    currentBlock.WestBlock = westBlock;
                }
            }

            Console.WriteLine("Circuit creation complete ");
        }

        public MapBlockEntity[,] GetCircuit
        {
            get
            {
                return mapCircuit;
            }
        }

        private MapBlockEntity? GetMapBlock(int row, int col)
        {
            if (row < 0 || row >= CircuitOption.MAX_ROWS)
            {
                return null;
            }
                

            if (col < 0 || col >= CircuitOption.MAX_COLS)
            {
                return null;
            }

            var block = mapCircuit[row, col];

            if (block == null)
            {
                block = new MapBlockEntity(row, col);
                mapCircuit[row, col] = block;
            }

            return block;
        }

    }
}

