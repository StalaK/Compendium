namespace Compendium.Repository.Models
{
    public class LoanedBook : LoanBase
    {
        public int Id { get; set; }

        public Book Book { get; set; }

        public People Lender { get; set; }
    }
}
