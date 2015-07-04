using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    class Player
    {
        private Hand _hand = new Hand();
        private int _currentBet = 0;
        private int _balance = 0;
        private bool _disabled = false;

        private string _name;
        private const int DEFAULT_BALANCE = 1000;

        public Player(string name)
        {
            this._balance = DEFAULT_BALANCE;
            this._name = name;
        }

        public void TakeCard(Card card) {
            this._hand.TakeCard(card);
        }

        public string ShowCards()
        {
            return this._hand.ToString();
        }

        public void SetBet(int bet)
        {
            this._currentBet += bet;
            this._balance -= bet;
        }

        public void ClearBet()
        {
            this._currentBet = 0;
        }

        public int balance
        {
            get { return this.balance; }
        }

        public bool disabled
        {
            get { return this._disabled; }
            set { this._disabled = value; }
        }
        
    }
}
