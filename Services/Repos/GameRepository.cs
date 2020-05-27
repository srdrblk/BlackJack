using Models.Entities;
using Contract.Enums;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository.Repos
{
    public class GameRepository : IGameRepository
    {
        IPlayerRepository playerRepository;
        IDeckRepository deckRepository;
        private GameStatuEnum gameStatuEnum;
        private readonly int CriticPointForCasino = 16;
    
        public GameRepository(IPlayerRepository _playerRepository, IDeckRepository _deckRepository)
        {
            playerRepository = _playerRepository;
            deckRepository = _deckRepository;
            gameStatuEnum = GameStatuEnum.Played;
        }
        public List<Player> CreateGame()
        {
            if (gameStatuEnum == GameStatuEnum.Played)
            {
                playerRepository.CreateCasinoPlayer();
                playerRepository.AddNewPlayer();
                gameStatuEnum = GameStatuEnum.IsPlayed;
                DealingCards();
            }
            return playerRepository.GetPlayers();
        }
        public Player AddCard(Guid guid)
        {
            var nextCard = deckRepository.GetCard();
            return playerRepository.AddCard(guid, nextCard);
        }
        public Player AddPlayer()
        {
            return playerRepository.AddNewPlayer();
        }
        public List<Player> GetPlayers()
        {
            return playerRepository.GetPlayers();
        }

        public void RestartGame()
        {
            if (gameStatuEnum == GameStatuEnum.IsPlayed)
            {
                playerRepository.ClearPlayers();

                DealingCards();
            }
        }
        public void DealingCards()
        {

            var players = playerRepository.GetPlayers();
         
            foreach (var item in players)
            {
                var card = deckRepository.GetCard();
                playerRepository.AddCard(item.Id, card);
            }
            foreach (var item in players)
            {
                var card = deckRepository.GetCard();
                playerRepository.AddCard(item.Id, card);
            }

            var casino = players.Where(p => p.PlayerType == PlayerTypeEnum.Casino).FirstOrDefault();
            while (casino.Point<= CriticPointForCasino)
            {
                var card = deckRepository.GetCard();
                playerRepository.AddCard(casino.Id, card);
            }
          
        }
        public void CloseGame()
        {
            playerRepository.RemovePlayers();
            gameStatuEnum = GameStatuEnum.Played;
        }

        public void ClosePlayer(Guid Id)
        {
            var players = playerRepository.GetPlayers();
            var casino = players.Where(p => p.PlayerType == PlayerTypeEnum.Casino).FirstOrDefault();
            playerRepository.ClosePlayer(casino.Point,Id);
        }
    }
}