using System;
using System.Collections.Generic;

namespace Blackjack
{
    public class Deck
    {
        private List<Card> _cards;
        private int _length;

        public int Length
        {
            get => _length;
            set => _length = value;
        }

        public List<Card> Cards
        {
            get => _cards;
            set => _cards = value;
        }
        
        public Deck()
        {
            _cards = new List<Card>();
            Restock();
        }

        public void Restock()
        {
            for (var i = 1; i <= 13; i++)
            {
                for (var j = 0; j < 4; j++)
                {
                    _cards.Add((Card) i);
                }
            }

            _length = 52;
        }

        public void Shuffle()
        {
            Blackjack.Shuffle.ShuffleList(_cards);
        }

        public void PrintDeck()
        {
            for (int i = 0; i < _length; i++)
            {
                Console.WriteLine(_cards[i]);
            }
        }
    }
}