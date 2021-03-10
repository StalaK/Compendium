using System.Collections.Generic;
using Compendium.Common.Models;
using Compendium.Services;
using Microsoft.AspNetCore.Mvc;

namespace Compendium.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class BoardGameController : ControllerBase
    {
        private readonly IBoardGameService _boardGameService;

        public BoardGameController(IBoardGameService boardGameService)
        {
            _boardGameService = boardGameService;
        }

        [HttpGet]
        public ActionResult<List<string>> GetBoardGames()
        {
            return Ok(new List<string> { "Monopoly", "Ticket To Ride" });
        }

        [HttpGet]
        public ActionResult GetBoardGame(int boardGameId)
        {
            return Ok("Monopoly");
        }

        [HttpPost]
        public ActionResult PostAddBoardGame(NewBoardGameModel model)
        {
            return Ok($"{model.Title} added");
        }

        [HttpDelete]
        public ActionResult DeleteBoardGame(int boardGameId)
        {
            return Ok($"{boardGameId} deleted");
        }
    }
}
