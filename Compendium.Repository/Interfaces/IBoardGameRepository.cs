using System.Collections.Generic;
using Compendium.Repository.Models;

namespace Compendium.Repository
{
    public interface IBoardGameRepository
    {
        IEnumerable<BoardGame> GetBoardGames();
        BoardGame GetBoardGame(int boardGameId);
        void AddBoardGame(BoardGame boardGame);
    }
}
