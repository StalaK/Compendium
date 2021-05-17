using System.Collections.Generic;

namespace Compendium.Repository.Models
{
    public class People
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string Surname { get; set; }

        public List<LoanedBoardGame> LoanedBoardGames { get; set; }
        public List<LoanedBook> LoanedBooks { get; set; }
        public List<LoanedGame> LoanedGames { get; set; }
    }
}
