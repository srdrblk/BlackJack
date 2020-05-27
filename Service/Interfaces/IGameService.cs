using Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Interfaces
{
    public interface IGameService
    {
        List<Player> CreateGame();

        Player AddCard(Guid guid);

        Player AddPlayer();

        List<Player> GetPlayers();

        void CloseGame();
        void RestartGame();

        void ClosePlayer(Guid Id);
    }
}
