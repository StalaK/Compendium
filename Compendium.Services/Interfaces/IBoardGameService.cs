using System.Collections.Generic;
using Compendium.Common.Models;

namespace Compendium.Services
{
    public interface IBoardGameService
    {
        List<BoardGameVm> GetBoardGames();
        BoardGameVm GetBoardGame(int boardGameId);
        void AddBoardGame(NewBoardGameModel model);
    }
}
