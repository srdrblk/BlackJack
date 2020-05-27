using Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Interfaces
{
    public interface IPlayerRepository
    {
        Player AddNewPlayer();
        Player CreateCasinoPlayer();
        Player AddCard(Guid guid, Card card);
        List<Player> GetPlayers();
        void RemovePlayers();
        void ClearPlayers();
        void ClosePlayer(int CasinoPoint, Guid Id);
    }
}
