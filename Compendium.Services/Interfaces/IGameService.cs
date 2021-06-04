using System.Collections.Generic;
using Compendium.Common.Models;

namespace Compendium.Services
{
    public interface IGameService
    {
        public List<GameVm> GetGames();
        GameVm GetGame(int id);
        void AddGame(NewGameModel model);
        void DeleteGame(int id);
    }
}
