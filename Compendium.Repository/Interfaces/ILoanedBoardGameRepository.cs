using Compendium.Repository.Models;

namespace Compendium.Repository
{
    public interface ILoanedBoardGameRepository
    {
        void LoanBoardGame(LoanedBoardGame loanedBoardGame);
        void ReturnBoardGame(int loanedBoardGameId);
    }
}
