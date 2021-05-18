namespace Compendium.Services
{
    public interface ILoanService
    {
        void LoanBoardGame(int boardGameId, int personId);
        void LoanBook(string isbn, int personId);
        void LoanGame(int gameId, int personId);
        void ReturnBoardGame(int loanedBoardGameId);
        void ReturnBook(int loanedBookId);
        void ReturnGame(int loanedGameId);
    }
}