﻿using DrivingSimulation.Models;
using DrivingSimulation.Models.Enums;

namespace DrivingSimulation.Tests.Models
{
	public class UserMovementEntityTest
	{
        [Fact]
        public void GetMovements_ReturnsMovement()
        {
            var exepectedMovements = new List<MovementType>()
            {
                MovementType.FORWARD,
                MovementType.RIGHT,
                MovementType.LEFT,
                MovementType.FORWARD,
                MovementType.FORWARD,
                MovementType.RIGHT
            };

            var userMovement = new UserMovementEntity(exepectedMovements);
            var mappedMovements = userMovement.GetMovements;

            var isTrue = exepectedMovements.SequenceEqual(mappedMovements);

            Assert.True(isTrue);
        }
    }
}

