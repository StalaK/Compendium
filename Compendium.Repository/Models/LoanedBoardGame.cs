using System.Collections.Generic;

namespace Compendium.Repository.Models
{
    public class LoanedBoardGame
    {
        public int Id { get; set; }

        public List<BoardGame> BoardGame { get; set; }
        public List<User> User { get; set; }
    }
}
