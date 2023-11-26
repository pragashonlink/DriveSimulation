using System;
using DrivingSimulation.Application.Circuit;

namespace DrivingSimulation.Tests.Application.Circuit
{
	public class CircuitManagerTest
	{
		[Fact]
		void BuildCircuit_ShouldCreateNewDrivingCircuit()
		{
			var circuitManager = new CircuitManager();
			circuitManager.BuildCircuit();

			var circuit = circuitManager.GetCircuit;

			var block = circuit[1, 2];
			var expectedNorthBlock = circuit[2, 2];
			var expectedEastBlock = circuit[1, 3];
			var expectedSouthBlock = circuit[0, 2];
			var expectedWestBlock = circuit[1, 1];

            Assert.Equal(expectedNorthBlock.GetCol, block.NorthBlock?.GetCol);
            Assert.Equal(expectedNorthBlock.GetRow, block.NorthBlock?.GetRow);

            Assert.Equal(expectedEastBlock.GetCol, block.EastBlock?.GetCol);
            Assert.Equal(expectedEastBlock.GetRow, block.EastBlock?.GetRow);

            Assert.Equal(expectedSouthBlock.GetCol, block.SouthBlock?.GetCol);
            Assert.Equal(expectedSouthBlock.GetRow, block.SouthBlock?.GetRow);

            Assert.Equal(expectedWestBlock.GetCol, block.WestBlock?.GetCol);
            Assert.Equal(expectedWestBlock.GetRow, block.WestBlock?.GetRow);
        }

    }
}

