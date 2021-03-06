using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Compendium.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class GameController : ControllerBase
    {
        public GameController()
        {
        }

        [HttpGet]
        public List<string> GetGames()
        {
            return new List<string> { "Mario", "Zelda" };
        }

        [HttpGet]
        public string GetGame(int gameId)
        {
            return "Mario";
        }

        [HttpPost]
        public string PostAddGame(string game)
        {
            return game;
        }

        [HttpDelete]
        public string DeleteGame(int gameId)
        {
            return $"{gameId} deleted";
        }
    }
}
