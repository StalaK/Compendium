using System;
using System.Collections.Generic;
using System.Linq;
using Compendium.Common.Models;
using Compendium.Repository;
using Compendium.Repository.Models;

namespace Compendium.Services
{
    public class BoardGameService : IBoardGameService
    {
        private readonly IBoardGameRepository _boardGameRepository;

        public BoardGameService(IBoardGameRepository boardGameRepository)
        {
            _boardGameRepository = boardGameRepository;
        }

        public List<BoardGameVm> GetBoardGames()
        {
            var boardGames = _boardGameRepository.GetBoardGames();

            var boardGameVm = new List<BoardGameVm>();

            boardGames.ToList().ForEach(b =>
            {
                boardGameVm.Add(new BoardGameVm
                {
                    Id = b.Id,
                    Name = b.Name,
                    Publisher = b.Publisher,
                    MinGameLength = b.MinGameLength.GetValueOrDefault(0),
                    MaxGameLength = b.MaxGameLength.GetValueOrDefault(0),
                    Genre = b.Genre
                });
            });

            return boardGameVm;
        }

        public BoardGameVm GetBoardGame(int boardGameId)
        {
            var boardGme = _boardGameRepository.GetBoardGame(boardGameId);

            var boardGameVm = new BoardGameVm
            {
                Id = boardGme.Id,
                Name = boardGme.Name,
                Publisher = boardGme.Publisher,
                MinGameLength = boardGme.MinGameLength.GetValueOrDefault(0),
                MaxGameLength = boardGme.MaxGameLength.GetValueOrDefault(0),
                Genre = boardGme.Genre
            };

            return boardGameVm;
        }

        public void AddBoardGame(NewBoardGameModel model)
        {
            var boardGame = new BoardGame
            {
                Name = model.Name,
                Publisher = model.Publisher,
                Genre = model.Genre,
                MinGameLength = model.MinGameLength,
                MaxGameLength = model.MaxGameLength,
                MinNoOfPlayers = model.MinNoOfPlayers,
                MaxNoOfPlayers = model.MaxNoOfPlayers,
                DateAdded = DateTime.Now
            };

            _boardGameRepository.AddBoardGame(boardGame);
        }

        public void DeleteBoardGame(int boardGameId)
        {
            _boardGameRepository.DeleteBoardGame(boardGameId);
        }
    }
}
