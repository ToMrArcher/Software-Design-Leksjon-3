using System;
using System.Collections.Generic;

namespace Blackjack
{
    public static class Shuffle
    {
        private static Random _rng = new Random();

        public static void ShuffleList<T>(IList<T> list)  
        {
            var n = list.Count;  
            while (n > 1) {  
                n--;  
                var k = _rng.Next(n + 1);  
                (list[k], list[n]) = (list[n], list[k]);
            }  
        }
    }
}