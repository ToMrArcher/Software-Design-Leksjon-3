using System.Collections.Generic;

namespace Blackjack
{
    public abstract class Player
    {
        private List<Card> hand;
        
        

        public abstract bool HitOrStay();
    }
}