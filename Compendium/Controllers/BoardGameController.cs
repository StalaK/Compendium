using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Compendium.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class BoardGameController : ControllerBase
    {
        public BoardGameController()
        {
        }

        [HttpGet]
        public List<string> GetBoardGames()
        {
            return new List<string> { "Monopoly", "Ticket To Ride" };
        }

        [HttpGet]
        public string GetBoardGame(int boardGameId)
        {
            return "Monopoly";
        }

        [HttpPost]
        public string PostAddBoardGame(string gameName)
        {
            return $"{gameName} added";
        }

        [HttpDelete]
        public string DeleteBoardGame(int boardGameId)
        {
            return $"{boardGameId} deleted";
        }
    }
}
