using System.Collections.Generic;
using Compendium.Repository.Models;

namespace Compendium.Repository
{
    public interface IGameRepository
    {
        IEnumerable<Game> GetGames();
        Game GetGame(int gameId);
        void AddGame(Game game);
        void DeleteGame(int gameId);
    }
}
