using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poker
{
    public partial class Form1 : Form
    {
        Game game;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            game = new Game();

            this.ReloadView();

        }

        private void foldButton_Click(object sender, EventArgs e)
        {
            game.PlayerActionBet("Fold");

            this.ReloadView();
        }

        private void raiseButton_Click(object sender, EventArgs e)
        {
            try
            {
                int bet = (int)betInput.Value;
                game.PlayerActionBet("Bet", bet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.ReloadView();
            }
        }

        private void ReloadView()
        {
            activePlayerIndex.Text = game.activePlayerIndex.ToString();
            currentGameStage.Text = game.currentGameStage;
            bankLabel.Text = game.gameBank.ToString();

            Player1Cards.Text = game.ShowPlayerCards(0);
            Player2Cards.Text = game.ShowPlayerCards(1);

            player1BalanceLabel.Text = game.ShowPlayerBalance(0).ToString();
            player2BalanceLabel.Text = game.ShowPlayerBalance(1).ToString();

            this.ControlsView();
        }

        private void ControlsView()
        {
            if (game.currentGameStage == "Bets")
            {
                betsPanel.Visible = true;
                changeCardPanel.Visible = false;

                betInput.Minimum = game.GetMinBet();
                betInput.Value = game.GetMinBet();
            }
            else if (game.currentGameStage == "Change cards")
            {
                betsPanel.Visible = false;
                changeCardPanel.Visible = true;
            }
            else
            {

            }
        }
    }
}
