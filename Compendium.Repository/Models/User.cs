namespace Compendium.Repository.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AccessCode { get; set; }

        public int LoanedBoardGameId { get; set; }
        public LoanedBoardGame LoanedBoardGame { get; set; }

        public int LoanedBookId { get; set; }
        public LoanedBook LoanedBook { get; set; }
    }
}
