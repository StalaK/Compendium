using Compendium.Repository;
using Compendium.Repository.Models;

namespace Compendium.Services
{
    public class LoanService : ILoanService
    {
        private readonly ILoanedBoardGameRepository _loanedBoardGameRepository;
        private readonly ILoanedBookRepository _loanedBookRepository;
        private readonly ILoanedGameRepository _loanedGameRepository;
        private readonly IBoardGameRepository _boardGameRepository;
        private readonly IBookRepository _bookRepository;
        private readonly IGameRepository _gameRepository;
        private readonly IPeopleRepository _peopleRepository;

        public LoanService(
            ILoanedBoardGameRepository loanedBoardGameRepository,
            ILoanedBookRepository loanedBookRepository,
            ILoanedGameRepository loanedGameRepository,
            IBoardGameRepository boardGameRepository,
            IBookRepository bookRepository,
            IGameRepository gameRepository,
            IPeopleRepository peopleRepository)
        {
            _loanedBoardGameRepository = loanedBoardGameRepository;
            _loanedBookRepository = loanedBookRepository;
            _loanedGameRepository = loanedGameRepository;
            _boardGameRepository = boardGameRepository;
            _bookRepository = bookRepository;
            _gameRepository = gameRepository;
            _peopleRepository = peopleRepository;
        }

        public void LoanBoardGame(int boardGameId, int personId)
        {
            var boardGame = _boardGameRepository.GetBoardGame(boardGameId);
            var person = _peopleRepository.GetPerson(personId);

            var loanedBoardGame = new LoanedBoardGame
            {
                BoardGame = boardGame,
                Lender = person
            };

            _loanedBoardGameRepository.LoanBoardGame(loanedBoardGame);
        }

        public void ReturnBoardGame(int loanedBoardGameId)
        {
            _loanedBoardGameRepository.ReturnBoardGame(loanedBoardGameId);
        }

        public void LoanBook(string isbn, int personId)
        {
            var book = _bookRepository.GetBook(isbn);
            var person = _peopleRepository.GetPerson(personId);

            var loanedBook = new LoanedBook
            {
                Book = book,
                Lender = person
            };

            _loanedBookRepository.LoanBook(loanedBook);
        }

        public void ReturnBook(int loanedBookId)
        {
            _loanedBookRepository.ReturnBook(loanedBookId);
        }

        public void LoanGame(int gameId, int personId)
        {
            var game = _gameRepository.GetGame(gameId);
            var person = _peopleRepository.GetPerson(personId);

            var loanedGame = new LoanedGame
            {
                Game = game,
                Lender = person
            };

            _loanedGameRepository.LoanGame(loanedGame);
        }

        public void ReturnGame(int loanedGameId)
        {
            _loanedGameRepository.ReturnGame(loanedGameId);
        }
    }
}
