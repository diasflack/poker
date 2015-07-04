using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    class Hand
    {
        private List<Card> _cardsList = new List<Card>();
        private int _handLength = 0;

        public Hand()
        {

        }

        public void TakeCard(Card card)
        {
            _handLength++;
            this._cardsList.Add(card);
        }

        public void ThrowCard(int cardIndex)
        {
            _handLength--;
            this._cardsList.RemoveAt(cardIndex);
        }

        public void SwapCards(int thrownCardIndex, Card takenCard)
        {
            this.ThrowCard(thrownCardIndex);
            this.TakeCard(takenCard);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Card card in _cardsList)
            {
                sb.Append(card.suit);
                sb.Append(" ");
                sb.Append(card.rank);
                sb.Append(", ");
            }
            return sb.ToString();
        }

    }
}
