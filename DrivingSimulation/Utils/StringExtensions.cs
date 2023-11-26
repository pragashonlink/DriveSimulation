using System;
using DrivingSimulation.Models.Enums;

namespace DrivingSimulation.Utils
{
	public static class StringExtensions
	{
        public static IList<MovementType> InputToMovementType(this string movements)
        {
            IList<MovementType> userMovements = new List<MovementType>();

            foreach (var movement in movements)
            {
                userMovements.Add(MapToMovement(movement));
            }

            return userMovements;
        }

        private static MovementType MapToMovement(char movement)
        {
            var movementsMapper = new Dictionary<char, MovementType>()
            {
                { 'F', MovementType.FORWARD },
                { 'L', MovementType.LEFT },
                { 'R', MovementType.RIGHT }
            };

            var mappedMovement = MovementType.INVALID;

            movementsMapper.TryGetValue(movement, out mappedMovement);

            return mappedMovement;
        }
    }
}

