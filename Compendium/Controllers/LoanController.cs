using System.Collections.Generic;
using Compendium.Services;
using Microsoft.AspNetCore.Mvc;

namespace Compendium.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class LoanController : ControllerBase
    {
        private readonly ILoanService _loanService;

        public LoanController(ILoanService loanService)
        {
            _loanService = loanService;
        }

        [HttpPost]
        public string PostAddLender(string name)
        {
            return $"{name} added as a lender";
        }

        [HttpGet]
        public List<string> GetLoanedBooks()
        {
            return new List<string> { "Harry Potter", "The Hobbit" };
        }

        [HttpGet]
        public List<string> GetLoanedGames()
        {
            return new List<string> { "The Legend Of Zelda", "Stardew Valley" };
        }

        [HttpGet]
        public List<string> GetLoanedBoardGames()
        {
            return new List<string> { "Cluedo", "Cards Against Humanity" };
        }

        [HttpPost]
        public string PostLendBook(int lenderId, string isbn)
        {
            return $"{isbn} lent out to {lenderId}";
        }

        [HttpPost]
        public string PostLendGame(int lenderId, int gameId)
        {
            return $"{gameId} lent out to {lenderId}";
        }

        [HttpPost]
        public string PostLendBoardGame(int lenderId, int boardGameId)
        {
            return $"{boardGameId} lent out to {lenderId}";
        }

        [HttpPatch]
        public string PatchReturnBook(string isbn)
        {
            return $"{isbn} returned";
        }

        [HttpPatch]
        public string PatchReturnGame(int gameId)
        {
            return $"{gameId} returned";
        }

        [HttpPatch]
        public string PatchReturnBoardGame(int boardGameId)
        {
            return $"{boardGameId} returned";
        }
    }
}
