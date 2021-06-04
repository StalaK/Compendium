using System;
using System.Collections.Generic;
using System.Linq;
using Compendium.Common.Models;
using Compendium.Repository;
using Compendium.Repository.Models;

namespace Compendium.Services
{
    public class GameService : IGameService
    {
        private readonly IGameRepository _gameRepository;

        public GameService(IGameRepository gameRepository)
        {
            _gameRepository = gameRepository;
        }

        public List<GameVm> GetGames()
        {
            var games = _gameRepository.GetGames();

            var gameVm = new List<GameVm>();

            games.ToList().ForEach(g =>
            {
                gameVm.Add(new GameVm
                {
                    Id = g.Id,
                    Title = g.Title,
                    Publisher = g.Publisher,
                    Genre = g.Genre,
                    Console = g.Console,
                    Format = g.Format,
                    LocalMultiplayer = g.LocalMultiplayer,
                    DateAdded = g.DateAdded,
                    DateUpdated = g.DateUpdated,
                    DateDeleted = g.DateDeleted,
                    UserAdded = g.UserAdded
                });
            });

            return gameVm;
        }

        public GameVm GetGame(int id)
        {
            var game = _gameRepository.GetGame(id);

            var gameVm = new GameVm
            {
                Id = game.Id,
                Title = game.Title,
                Publisher = game.Publisher,
                Genre = game.Genre,
                Console = game.Console,
                Format = game.Format,
                LocalMultiplayer = game.LocalMultiplayer,
                DateAdded = game.DateAdded,
                DateUpdated = game.DateUpdated,
                DateDeleted = game.DateDeleted,
                UserAdded = game.UserAdded
            };

            return gameVm;
        }

        public void AddGame(NewGameModel model)
        {
            var game = new Game
            {
                Title = model.Title,
                Publisher = model.Publisher,
                Genre = model.Genre,
                Console = model.Console,
                Format = model.Format,
                LocalMultiplayer = model.LocalMultiplayer,
                DateAdded = DateTime.Now,

            };

            _gameRepository.AddGame(game);
        }

        public void DeleteGame(int id)
        {
            _gameRepository.DeleteGame(id);
        }
    }
}
