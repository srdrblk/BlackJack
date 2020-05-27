using Models.Entities;
using Repository.Interfaces;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public class GameService : IGameService
    {
        IGameRepository gameRepository;
        public GameService(IGameRepository _gameRepository)
        {
            gameRepository = _gameRepository;
        }
        public List<Player> CreateGame()
        {
           return gameRepository.CreateGame();
        }
        public Player AddCard(Guid guid)
        {
            return gameRepository.AddCard(guid);
        }
        public Player AddPlayer()
        {
            return gameRepository.AddPlayer();
        }
        public List<Player> GetPlayers()
        {
            return gameRepository.GetPlayers();
        }

        public void RestartGame()
        {
            gameRepository.RestartGame();
        }

        public void CloseGame()
        {
            gameRepository.CloseGame();
        }

        public void ClosePlayer(Guid Id)
        {
            gameRepository.ClosePlayer(Id);
        }
    }
}
