using Compendium.Repository.Models;

namespace Compendium.Repository
{
    public interface ILoanedBookRepository
    {
        void LoanBook(LoanedBook loanedBook);
        void ReturnBook(int loanedBookId);
    }
}
