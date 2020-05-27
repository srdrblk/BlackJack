using Contract.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contract.Enums
{
    public enum SymboEnum
    {
        [Color("Red")]
        [Sign("♡")]
        [Description("hearts")]
        Hearts = 1,
        [Color("Red")]
        [Sign("♢")]
        [Description("diams")]
        Tiles = 2,
        [Color("Black")]
        [Sign("♣")]
        [Description("clubs")]
        Clovers = 3,
        [Color("Black")]
        [Sign("♠")]
        [Description("spades")]
        Pikes = 4



    }
}
