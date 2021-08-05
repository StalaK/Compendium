using System;
using System.Linq;
using Compendium.Repository.Models;

namespace Compendium.Repository
{
    public class LoanedGameRepository : ILoanedGameRepository
    {
        private readonly CompendiumContext _context;

        public LoanedGameRepository(CompendiumContext context)
        {
            _context = context;
        }

        public void LoanGame(LoanedGame loanedGame)
        {
            _context.LoanedGames.Add(loanedGame);
        }

        public void ReturnGame(int loanedGameId)
        {
            var loanedGame = _context.LoanedGames.First(g => g.Id == loanedGameId);
            loanedGame.ReturnDate = DateTime.Now;

            _context.LoanedGames.Update(loanedGame);
        }
    }
}
