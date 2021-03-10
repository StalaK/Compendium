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
        public ActionResult<List<string>> GetGames()
        {
            return Ok(new List<string> { "Mario", "Zelda" });
        }

        [HttpGet]
        public ActionResult<string> GetGame(int gameId)
        {
            return Ok("Mario");
        }

        [HttpPost]
        public ActionResult<string> PostAddGame(NewGameModel model)
        {
            return Ok(model.Title);
        }

        [HttpDelete]
        public ActionResult<string> DeleteGame(int gameId)
        {
            return Ok($"{gameId} deleted");
        }
    }
}
