using Compendium.Repository.Models;

namespace Compendium.Repository
{
    public interface ILoanedGameRepository
    {
        void LoanGame(LoanedGame loanedGame);
        void ReturnGame(int loanedGameId);
    }
}
