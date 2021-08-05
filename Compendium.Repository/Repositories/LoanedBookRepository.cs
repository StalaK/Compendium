using System;
using System.Linq;
using Compendium.Repository.Models;

namespace Compendium.Repository
{
    public class LoanedBookRepository : ILoanedBookRepository
    {
        private readonly CompendiumContext _context;

        public LoanedBookRepository(CompendiumContext context)
        {
            _context = context;
        }

        public void LoanBook(LoanedBook loanedBook)
        {
            _context.LoanedBooks.Add(loanedBook);
        }

        public void ReturnBook(int loanedBookId)
        {
            var loanedbook = _context.LoanedBooks.First(g => g.Id == loanedBookId);
            loanedbook.ReturnDate = DateTime.Now;

            _context.LoanedBooks.Update(loanedbook);
        }
    }
}
