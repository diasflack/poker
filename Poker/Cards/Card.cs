using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    public enum SUIT { Diamonds, Hearts, Clubs, Spades }
    public enum RANK
    {
        Ace, Two, Three, Four, Five, Six, Seven, Eight,
        Nine, Ten, Jack, Queen, King
    }

    class Card
    {
        private SUIT _suit;
        private RANK _rank;

        public Card(SUIT suit, RANK rank)
        {
            this._suit = suit;
            this._rank = rank;
        }

        public SUIT suit {
            get { return this._suit; }
        }

        public RANK rank
        {
            get { return this._rank; }
        }

    }
}
