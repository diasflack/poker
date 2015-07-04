using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    class Game
    {
        private Deck _gameDeck = new Deck();
        private int _gameBank = 0;
        private List<Player> _playersList = new List<Player>();
        private int _playersCount = 0;
        private int _activePlayerIndex = 0;
        private string _currentGameStage = "Bets";

        private const int DEFAULT_PLAYERS_NUMBER = 2;
        private const string DEFAULT_PLAYERS_NAME = "Player";
        private const int DEFAULT_PLAYER_HAND_COUNT = 5;
        private const int MIN_BET = 10;

        private int i;

        public Game()
        {
            this.initGame();
        }

        public void initGame() {
            _currentGameStage = "Bets";

            this.FillPlayers();
            this.DealCards();
        }

        #region PlayersMethods

        public void FillPlayers(int playersNumber = DEFAULT_PLAYERS_NUMBER)
        {
            
            for (i = 0;i < playersNumber;i++)
            {
                this.AddPlayer();
            }
        }

        public void AddPlayer(string playersName = DEFAULT_PLAYERS_NAME)
        {
            Player newPlayer = new Player(playersName);
            _playersList.Add(newPlayer);
            _playersCount = _playersList.Count;
        }

        public void DealCards()
        {
            for (i = 0; i < DEFAULT_PLAYER_HAND_COUNT; i++)
            {
                foreach (Player player in _playersList)
                {
                    player.TakeCard(_gameDeck.PullCard());
                }
            }
        }

        public string ShowPlayerCards(int playerIndex)
        {
            return _playersList[playerIndex].ShowCards();
        }

        public int ShowPlayerBalance(int playerIndex)
        {
            return _playersList[playerIndex].balance;
        }

        public int activePlayerIndex
        {
            get { return _activePlayerIndex; }
        }

        #endregion

        #region StageMethods
        public void NextPlayer()
        {
            this._activePlayerIndex++;

            if (this._activePlayerIndex < this._playersCount)
            {
                if (_playersList[_activePlayerIndex].disabled)
                {
                    this.NextPlayer();
                }
            }
            else
            {
                this.NextGameStage();
            }
        }

        public void NextGameStage()
        {
            this._activePlayerIndex = 0;
        }

        public string currentGameStage
        {
            get { return _currentGameStage; }
        }

        #endregion

        #region Bet Stage Methods
        public void SetPlayerBet(int bet) {
            _playersList[_activePlayerIndex].SetBet(bet);
        }

        public void PlayerActionBet(string action, int bet = 0)
        {
            switch (action)
            {
                case "Raise":
                    this.SetPlayerBet(bet);
                    break;
                case "Check":
                    break;
                case "Fold":
                    this._playersList[_activePlayerIndex].disabled = true;
                    break;
            }

            this.NextPlayer();
        }

        public void CalcGameBank()
        {
            _gameBank = 0;

            foreach(Player player in _playersList) {
                this._gameBank += player.currentBet;
            }
        }

        public int gameBank
        {
            get 
            {
                this.CalcGameBank();
                return this._gameBank; 
            }
        }

        #endregion
    }
}
