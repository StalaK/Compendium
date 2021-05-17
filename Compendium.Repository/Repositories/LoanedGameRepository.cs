namespace Compendium.Repository
{
    public class LoanedGameRepository : ILoanedGameRepository
    {
        private readonly ICompendiumContext _context;

        public LoanedGameRepository(ICompendiumContext context)
        {
            _context = context;
        }
    }
}
