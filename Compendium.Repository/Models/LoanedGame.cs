namespace Compendium.Repository.Models
{
    public class LoanedGame : LoanBase
    {
        public int Id { get; set; }

        public Game Game { get; set; }

        public People Lender { get; set; }
    }
}
