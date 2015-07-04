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

        private void checkButton_Click(object sender, EventArgs e)
        {
            game.PlayerActionBet("Check");

            this.ReloadView();
        }

        private void raiseButton_Click(object sender, EventArgs e)
        {
            try
            {
                int bet = (int)betInput.Value;
                game.PlayerActionBet("Raise", bet);
                betInput.Value = 0;
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
            bankLabel.Text = game.gameBank.ToString();

            Player1Cards.Text = game.ShowPlayerCards(0);
            Player2Cards.Text = game.ShowPlayerCards(1);

            player1BalanceLabel.Text = game.ShowPlayerBalance(0).ToString();
            player2BalanceLabel.Text = game.ShowPlayerBalance(1).ToString();
        }
    }
}
