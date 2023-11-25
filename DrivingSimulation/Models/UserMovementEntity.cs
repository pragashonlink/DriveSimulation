using System;
using DrivingSimulation.Models.Enums;

namespace DrivingSimulation.Models
{
	public class UserMovementEntity
	{
        private readonly IList<MovementType> userMovements;

        public UserMovementEntity(string movements)
        {
            userMovements = new List<MovementType>();
            ConvertUserInputToMovements(movements);
        }

        public IList<MovementType> GetMovements
        {
            get
            {
                return userMovements;
            }
        }

        private void ConvertUserInputToMovements(string movements)
        {
            foreach (var movement in movements)
            {
                userMovements.Add(MapToMovement(movement));
            }
        }

        private MovementType MapToMovement(char movement)
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

