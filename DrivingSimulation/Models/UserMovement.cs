using System;
using DrivingSimulation.Models.Enums;

namespace DrivingSimulation.Models
{
	public class UserMovement
	{
        private readonly IList<Movement> userMovements;


        public UserMovement(string movements)
        {
            userMovements = new List<Movement>();
            ConvertUserInputToMovements(movements);
        }

        public IList<Movement> GetMovements
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

        private Movement MapToMovement(char movement)
        {
            var movementsMapper = new Dictionary<char, Movement>()
            {
                { 'F', Movement.FORWARD },
                { 'L', Movement.LEFT },
                { 'R', Movement.RIGHT }
            };

            var mappedMovement = Movement.INVALID;

            movementsMapper.TryGetValue(movement, out mappedMovement);

            return mappedMovement;
        }
    }
}

