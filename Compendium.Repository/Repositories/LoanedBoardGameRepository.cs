using System.Linq;
using Compendium.Repository.Models;

namespace Compendium.Repository
{
    public class LoanedBoardGameRepository : ILoanedBoardGameRepository
    {
        private readonly ICompendiumContext _context;

        public LoanedBoardGameRepository(ICompendiumContext context)
        {
            _context = context;
        }
    }
}
