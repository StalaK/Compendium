using System;
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

        public void LoanBoardGame(LoanedBoardGame loanedBoardGame)
        {
            _context.LoanedBoardGames.Add(loanedBoardGame);
        }

        public void ReturnBoardGame(int loanedBoardGameId)
        {
            var loanedBoardGame = _context.LoanedBoardGames.First(g => g.Id == loanedBoardGameId);
            loanedBoardGame.ReturnDate = DateTime.Now;

            _context.LoanedBoardGames.Update(loanedBoardGame);
        }
    }
}
