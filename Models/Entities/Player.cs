using Contract.Enums;
using Models.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Entities
{
    public class Player
    {

        public Guid Id { get; set; }
        public List<Card> PlayerCards { get; set; } = new List<Card>();
        public int Point
        {
            get
            {
                return this.CalculatePoint();
            }
        }
        public PlayerTypeEnum PlayerType { get; set; }
        public PlayerStatuEnum PlayerStatuEnum
        {
            get
            {
                PlayerStatuEnum playerStatuEnum;
                if (Point > 21)
                {
                    playerStatuEnum = PlayerStatuEnum.Loser;
                    PlayerSecondStatuEnum = PlayerStatuEnum.Loser;
                }
                else if (Point == 21 && PlayerCards.Count == 2)
                {
                    playerStatuEnum = PlayerStatuEnum.BlackJack;
                    PlayerSecondStatuEnum = PlayerStatuEnum.BlackJack;
                }
                else if (Point == 21 && PlayerCards.Count > 2)
                {
                    playerStatuEnum = PlayerStatuEnum.Winner;
                    PlayerSecondStatuEnum = PlayerStatuEnum.Winner;
                }
                else
                {
                    playerStatuEnum = PlayerStatuEnum.InGame;
                }


                return playerStatuEnum;
            }

        }
        public PlayerStatuEnum PlayerSecondStatuEnum { get; set; } = PlayerStatuEnum.InGame;
    }
}
