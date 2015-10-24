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
        private int _currentRoundBet = 0;
        private List<Player> _playersList = new List<Player>();
        private int _playersCount = 0;
        private int _activePlayerIndex = 0;
        private int _activePlayerIterator = 0;
        private string _currentGameStage = "Bets";
        private int _currentGameStageIndex = 0; 

        private const int DEFAULT_PLAYERS_NUMBER = 2;
        private const string DEFAULT_PLAYERS_NAME = "Player";
        private const int DEFAULT_PLAYER_HAND_COUNT = 5;
        private const int MIN_BET = 10;
        private readonly string[] GAME_STAGES = { "Bets", "Change cards", "Bets", "Open cards" };

        private int i;

        public Game()
        {
            this.initGame();
        }

        public void initGame() {
            this.FillPlayers();
            this.initRound();
        }

        public void initRound()
        {
            this._currentGameStage = "Bets";
            this._currentGameStageIndex = 0;
            this._gameBank = 0;
            this._currentRoundBet = 0;
            this._activePlayerIndex = 0;
            this._playersCount = _playersList.Count;

            this.ClearPlayers();
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

        private void AddPlayer(string playersName = DEFAULT_PLAYERS_NAME)
        {
            Player newPlayer = new Player(playersName);
            _playersList.Add(newPlayer);
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

        public void ClearPlayers()
        {
            foreach (Player player in _playersList)
            {
                player.ClearBet();
                player.ClearHand();
                player.ClearDisabled();
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

        //_activePlayerIndex iterator
        private bool NextActivePlayerIndex()
        {
            for (_activePlayerIterator = _activePlayerIndex; ++_activePlayerIterator < _playersCount; )
            {
                if (!_playersList[_activePlayerIterator].disabled)
                {
                    _activePlayerIndex = _activePlayerIterator;
                    return true;
                }
            }
            _activePlayerIndex = 0;
            _activePlayerIterator = 0;
            return false;
        }

        #endregion

        #region StageMethods
        public void NextPlayer()
        {
            if (this._playersCount == 1)
            {
                this.GameEnd();
            }
            else if (!this.NextActivePlayerIndex())
            {
                this.NextGameStage();
            }

        }

        public void NextGameStage()
        {
            switch(_currentGameStage)
            {
                case "Bets":
                    if (this.currentRoundBet == 0)
                    {
                        _currentGameStage = GAME_STAGES[++_currentGameStageIndex];
                    }
                    break;
                case "Change cards":
                    _currentGameStage = GAME_STAGES[++_currentGameStageIndex];
                    break;
            }

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
                case "Bet":
                    this.currentRoundBet = bet; 
                    if (bet != 0)
                    {
                        this.SetPlayerBet(bet);
                    }
                    break;
                case "Fold":
                    this._playersList[_activePlayerIndex].disabled = true;
                    _playersCount--;
                    break;
            }

            this.NextPlayer();
        }

        public int GetMinBet()
        {
            return currentRoundBet;
        }

        public void CalcGameBank()
        {
            _gameBank = 0;

            foreach(Player player in _playersList) {
                this._gameBank += player.currentBet;
            }
        }

        private int currentRoundBet
        {
            get
            {
                if (this._currentRoundBet == 0)
                {
                    return MIN_BET;
                }

                if (this._currentRoundBet - this._playersList[_activePlayerIndex].currentBet < 0)
                {
                    throw new Exception("Bet is unacceptable");
                }

                return this._currentRoundBet - this._playersList[_activePlayerIndex].currentBet;
            }

            set
            {
                    this._currentRoundBet = this._playersList[_activePlayerIndex].currentBet + value;
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

        #region Switch cards Stage Methods
        
        public void changePlayerCards(int[] checkedIndices)
        {
            foreach(int cardIndex in checkedIndices)
            {
                _playersList[_activePlayerIndex].SwapCard(cardIndex, _gameDeck.PullCard());
            }

            this.NextPlayer();
        }
       
        #endregion

        #region GameEnd Methods

        private void GameEnd()
        {
            initRound();
        }

        #endregion
    }
}
