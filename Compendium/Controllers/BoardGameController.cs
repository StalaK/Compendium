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
        public ActionResult<List<BoardGameVm>> GetBoardGames()
        {
            var boardGames = _boardGameService.GetBoardGames();

            return Ok(boardGames);
        }

        [HttpGet]
        public ActionResult<BoardGameVm> GetBoardGame([FromQuery] int boardGameId)
        {
            var boardGame = _boardGameService.GetBoardGame(boardGameId);
            return Ok(boardGame);
        }

        [HttpPost]
        public ActionResult PostAddBoardGame(NewBoardGameModel model)
        {
            _boardGameService.AddBoardGame(model);
            return Created("/GetBoardGame", model);
        }

        [HttpDelete]
        public ActionResult DeleteBoardGame(int boardGameId)
        {
            return Ok($"{boardGameId} deleted");
        }
    }
}
