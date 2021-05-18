namespace Compendium.Repository.Models
{
    public class LoanedBoardGame : LoanBase
    {
        public int Id { get; set; }

        public BoardGame BoardGame { get; set; }

        public People Lender { get; set; }
    }
}
