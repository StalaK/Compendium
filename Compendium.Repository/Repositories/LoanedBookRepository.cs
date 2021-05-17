namespace Compendium.Repository
{
    public class LoanedBookRepository : ILoanedBookRepository
    {
        private readonly ICompendiumContext _context;

        public LoanedBookRepository(ICompendiumContext context)
        {
            _context = context;
        }
    }
}
