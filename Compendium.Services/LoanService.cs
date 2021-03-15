using Compendium.Repository;

namespace Compendium.Services
{
    public class LoanService : ILoanService
    {
        private readonly ILoanedBoardGameRepository _loanedBoardGameRepository;
        private readonly ILoanedBookRepository _loanedBookRepository;
        private readonly ILoanedGameRepository _loanedGameRepository;

        public LoanService(
            ILoanedBoardGameRepository loanedBoardGameRepository,
            ILoanedBookRepository loanedBookRepository,
            ILoanedGameRepository loanedGameRepository)
        {
            _loanedBoardGameRepository = loanedBoardGameRepository;
            _loanedBookRepository = loanedBookRepository;
            _loanedGameRepository = loanedGameRepository;
        }
    }
}
