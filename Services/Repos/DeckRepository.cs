using Contract.Enums;
using Models.Entities;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repos
{
    public class DeckRepository : IDeckRepository
    {
        private List<Card> CardList;
        private readonly int SymboCount= 4;
        private readonly int ValueCount = 13;
        private readonly int CardCount = 52;
        private  int CurrentCardCount = 0;
        public DeckRepository()
        {
            CardList = MixDesk();
        }
        private List<Card> GetDeck()
        {
            List<Card> cardList = new List<Card>();
            for (int i = 1; i <= SymboCount; i++)
            {
                for (int j = 1; j <= ValueCount; j++)
                {
                    Card card = new Card();
                    card.Id = (i - 1) * ValueCount + ValueCount;
                    card.Symbol = (SymboEnum)i;
                    card.Value = (ValueEnum)j;
                    card.Point = new List<int>();
                    if (j==1)
                    {
                        card.Point.Add(1);
                        card.Point.Add(11);
                    }
                    else if(j>=10)
                    {
                        card.Point.Add(10);
                    }
                    else
                    {
                        card.Point.Add(j);
                    }
                    cardList.Add(card);
                }
            }
            CurrentCardCount = cardList.Count();
            return cardList;
        }
        private List<Card> MixDesk()
        {
            Random random = new Random();
            var min = 1;
          
            
            var deck = GetDeck().ToArray();
            for (int i = 0; i < CardCount - 1; i++)
            {
                var randomIndex = random.Next(min, CardCount);
                var temp = deck[randomIndex];
                deck[randomIndex] = deck[i];
                deck[i] = temp;
            }
            return new List<Card>(deck);
        }

        public void ResetDesk()
        {
            CardList = MixDesk();
            
         
        }
        public Card GetCard()
        {
            if (CurrentCardCount==0)
            {
                ResetDesk();
            }
            var card = CardList.First();
            CardList.Remove(card);
            CurrentCardCount--;
            return card;
        }
    }
}
