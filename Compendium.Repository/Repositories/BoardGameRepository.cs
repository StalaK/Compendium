using System;
using System.Collections.Generic;
using System.Linq;
using Compendium.Repository.Models;

namespace Compendium.Repository
{
    public class BoardGameRepository : IBoardGameRepository
    {
        private readonly CompendiumContext _context;

        public BoardGameRepository(CompendiumContext context)
        {
            _context = context;
        }

        public IEnumerable<BoardGame> GetBoardGames()
        {
            var boardGames = _context.BoardGames.Where(b => !b.DateDeleted.HasValue);
            return boardGames;
        }

        public BoardGame GetBoardGame(int boardGameId)
        {
            var boardGame = _context.BoardGames.FirstOrDefault(b => b.Id == boardGameId);
            return boardGame;
        }

        public void AddBoardGame(BoardGame boardGame)
        {
            _context.BoardGames.Add(boardGame);
        }

        public void DeleteBoardGame(int boardGameId)
        {
            var boardGame = _context.BoardGames.FirstOrDefault(b => b.Id == boardGameId);
            boardGame.DateDeleted ??= DateTime.Now;

            _context.BoardGames.Update(boardGame);
        }
    }
}
