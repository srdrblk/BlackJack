using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.Extensions
{
    public static class PlayerExtension
    {
        public static int CalculatePoint(this Player player)
        {
            int sum = 0;
            int blackJack = 21;
            var singlePointCards = player.PlayerCards.Where(pc => pc.Point.Count == 1);

            if (singlePointCards.Any())
            {
                sum = singlePointCards.Sum(spc => spc.Point.FirstOrDefault());
            }
            var multiPointCards = player.PlayerCards.Where(pc => pc.Point.Count > 1); //As
            if (multiPointCards.Any())
            {
                foreach (var item in multiPointCards)
                {
                    if (item.Point.Max() + sum <= blackJack)
                    {
                        sum += item.Point.Max();
                    }
                    else
                    {
                        sum += item.Point.Min();
                    }
                }
               
            }

            return sum;
        }

    }
}
