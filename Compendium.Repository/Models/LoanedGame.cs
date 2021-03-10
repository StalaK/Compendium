using System.Collections.Generic;

namespace Compendium.Repository.Models
{
    public class LoanedGame
    {
        public int Id { get; set; }

        public List<Game> Games { get; set; }
        public List<User> Users { get; set; }
    }
}
