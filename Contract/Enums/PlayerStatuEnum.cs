using Contract.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contract.Enums
{
    public enum PlayerStatuEnum
    {
        [Description("Winner")]
        Winner = 1,
        [Description("Loser")]
        Loser = 2,
        [Description("BlackJack")]
        BlackJack = 3,
        [Description("Still In Game")]
        InGame = 4,
        [Description("Pay Back")]
        PayBack = 5,
        [Description("On Deal")]
        OnDeal = 6
    }
}
