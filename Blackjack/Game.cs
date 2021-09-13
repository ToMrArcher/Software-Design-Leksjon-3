using System;

namespace Blackjack
{
    public class Game
    {
        public static void StartGame()
        {
            var deck = new Deck();
            deck.Shuffle();
            deck.PrintDeck();
        }
    }
}