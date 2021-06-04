using System.Collections.Generic;
using Compendium.Common.Models;
using Compendium.Services;
using Microsoft.AspNetCore.Mvc;

namespace Compendium.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class GameController : ControllerBase
    {
        private readonly IGameService _gameService;

        public GameController(IGameService gameService)
        {
            _gameService = gameService;
        }

        [HttpGet]
        public ActionResult<List<GameVm>> GetGames()
        {
            var games = _gameService.GetGames();
            return Ok(games);
        }

        [HttpGet]
        public ActionResult<GameVm> GetGame(int gameId)
        {
            var game = _gameService.GetGame(gameId);
            return Ok(game);
        }

        [HttpPost]
        public ActionResult<string> PostAddGame(NewGameModel model)
        {
            _gameService.AddGame(model);
            return Ok($"{model.Title} added");
        }

        [HttpDelete]
        public ActionResult<string> DeleteGame(int gameId)
        {
            _gameService.DeleteGame(gameId);
            return Ok($"{gameId} deleted");
        }
    }
}
