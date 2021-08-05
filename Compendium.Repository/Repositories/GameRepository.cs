using System;
using System.Collections.Generic;
using System.Linq;
using Compendium.Repository.Models;

namespace Compendium.Repository
{
    public class GameRepository : IGameRepository
    {
        private readonly CompendiumContext _context;

        public GameRepository(CompendiumContext context)
        {
            _context = context;
        }

        public IEnumerable<Game> GetGames()
        {
            var games = _context.Games.Where(b => !b.DateDeleted.HasValue);
            return games;
        }

        public Game GetGame(int id)
        {
            var game = _context.Games.FirstOrDefault(b => b.Id == id);
            return game;
        }

        public void AddGame(Game game)
        {
            _context.Games.Add(game);
        }

        public void DeleteGame(int id)
        {
            var game = _context.Games.FirstOrDefault(b => b.Id == id);
            game.DateDeleted ??= DateTime.Now;

            _context.Games.Update(game);
        }
    }
}
