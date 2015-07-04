using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    class Deck
    {
        private List<Card> _cardsList = new List<Card>();
        private int _deckLength = 0;
        private int _currentCardIndex = 0;
        private const int DEFAULT_DECK_LENGTH = 52;

        public Deck()
        {
            this.CreateDeck();   
        }

        public void CreateDeck()
        {
            this.FillDeck(DEFAULT_DECK_LENGTH);
            this.ShuffleDeck();
        }

        public void FillDeck(int deckSize)
        {
            foreach (SUIT suit in Enum.GetValues(typeof(SUIT)))
            {
                foreach (RANK rank in Enum.GetValues(typeof(RANK)))
                {
                    _cardsList.Add(new Card(suit, rank));
                    _deckLength++;
                }
            }
        }

        public void ShuffleDeck()
        {
            Random rng = new Random();
            int n = _deckLength;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Card value = _cardsList[k];
                _cardsList[k] = _cardsList[n];
                _cardsList[n] = value;
            }  
        }

        public Card PullCard()
        {
            if (_deckLength < 0)
            {
                this.CreateDeck();
            }

            Card card = _cardsList[_currentCardIndex];
            _currentCardIndex++;
            _deckLength--;
            return card;
        }

    }
}
