using Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Interfaces
{
    public interface IGameRepository
    {
        List<Player> CreateGame();

        Player AddCard(Guid guid);

        Player AddPlayer();

        List<Player> GetPlayers();

        void DealingCards();

        void RestartGame();

        void CloseGame();

        void ClosePlayer(Guid Id);


    }
}
