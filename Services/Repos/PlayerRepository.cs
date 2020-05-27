using Contract.Enums;
using Models.Entities;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository.Repos
{
    public class PlayerRepository : IPlayerRepository
    {
        private List<Player> PlayerList;
        public PlayerRepository()
        {
            PlayerList = new List<Player>();
        }

        public Player AddNewPlayer()
        {

            Player player = new Player();
            player.Id = Guid.NewGuid();
            player.PlayerType = PlayerTypeEnum.Guest;
            player.PlayerCards = new List<Card>();
            PlayerList.Add(player);

            return player;
        }
        public List<Player> GetPlayers()
        {
            return PlayerList;
        }
        public Player CreateCasinoPlayer()
        {
            Player player = new Player();
            player.Id = Guid.NewGuid();
            player.PlayerType = PlayerTypeEnum.Casino;

            PlayerList.Add(player);

            return player;
        }
        public Player AddCard(Guid guid, Card card)
        {
            var player = PlayerList.Where(p => p.Id == guid).FirstOrDefault();
            if (player != null)
            {
                player.PlayerCards.Add(card);
            }

            return player;
        }
        public void RemovePlayers()
        {
            PlayerList = new List<Player>();
        }
        public void ClearPlayers()
        {
            foreach (var item in PlayerList)
            {
                item.PlayerCards = new List<Card>();
                item.PlayerSecondStatuEnum = PlayerStatuEnum.InGame;
            }
        }
        public void ClosePlayer(int CasinoPoint, Guid Id)
        {
            var player = PlayerList.Where(p => p.Id == Id).FirstOrDefault();
            if (player.PlayerSecondStatuEnum == PlayerStatuEnum.InGame)
            {
           
                if (player.Point < CasinoPoint && CasinoPoint<=21)
                {
                    player.PlayerSecondStatuEnum = PlayerStatuEnum.Loser;
                }
                else
                {
                    player.PlayerSecondStatuEnum = PlayerStatuEnum.Winner;

                }
            }
        }

    }
}
