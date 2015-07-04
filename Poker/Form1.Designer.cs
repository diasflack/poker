namespace Poker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.newGameButton = new System.Windows.Forms.Button();
            this.bankLabel = new System.Windows.Forms.Label();
            this.Player1Cards = new System.Windows.Forms.Label();
            this.Player2Cards = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.activePlayerIndex = new System.Windows.Forms.Label();
            this.raiseButton = new System.Windows.Forms.Button();
            this.checkButton = new System.Windows.Forms.Button();
            this.foldButton = new System.Windows.Forms.Button();
            this.betInput = new System.Windows.Forms.NumericUpDown();
            this.player1BalanceLabel = new System.Windows.Forms.Label();
            this.player2BalanceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.betInput)).BeginInit();
            this.SuspendLayout();
            // 
            // newGameButton
            // 
            this.newGameButton.Location = new System.Drawing.Point(26, 12);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(75, 23);
            this.newGameButton.TabIndex = 0;
            this.newGameButton.Text = "New Game";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // bankLabel
            // 
            this.bankLabel.AutoSize = true;
            this.bankLabel.Location = new System.Drawing.Point(235, 201);
            this.bankLabel.Name = "bankLabel";
            this.bankLabel.Size = new System.Drawing.Size(23, 13);
            this.bankLabel.TabIndex = 1;
            this.bankLabel.Text = "Bet";
            // 
            // Player1Cards
            // 
            this.Player1Cards.AutoSize = true;
            this.Player1Cards.Location = new System.Drawing.Point(29, 129);
            this.Player1Cards.Name = "Player1Cards";
            this.Player1Cards.Size = new System.Drawing.Size(72, 13);
            this.Player1Cards.TabIndex = 2;
            this.Player1Cards.Text = "Player1 Cards";
            // 
            // Player2Cards
            // 
            this.Player2Cards.AutoSize = true;
            this.Player2Cards.Location = new System.Drawing.Point(29, 269);
            this.Player2Cards.Name = "Player2Cards";
            this.Player2Cards.Size = new System.Drawing.Size(75, 13);
            this.Player2Cards.TabIndex = 3;
            this.Player2Cards.Text = "Player 2 Cards";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Active Player Index";
            // 
            // activePlayerIndex
            // 
            this.activePlayerIndex.AutoSize = true;
            this.activePlayerIndex.Location = new System.Drawing.Point(160, 335);
            this.activePlayerIndex.Name = "activePlayerIndex";
            this.activePlayerIndex.Size = new System.Drawing.Size(98, 13);
            this.activePlayerIndex.TabIndex = 5;
            this.activePlayerIndex.Text = "Active Player Index";
            // 
            // raiseButton
            // 
            this.raiseButton.Location = new System.Drawing.Point(32, 421);
            this.raiseButton.Name = "raiseButton";
            this.raiseButton.Size = new System.Drawing.Size(75, 23);
            this.raiseButton.TabIndex = 6;
            this.raiseButton.Text = "Raise";
            this.raiseButton.UseVisualStyleBackColor = true;
            this.raiseButton.Click += new System.EventHandler(this.raiseButton_Click);
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(163, 421);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(75, 23);
            this.checkButton.TabIndex = 7;
            this.checkButton.Text = "Check";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // foldButton
            // 
            this.foldButton.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.foldButton.Location = new System.Drawing.Point(298, 421);
            this.foldButton.Name = "foldButton";
            this.foldButton.Size = new System.Drawing.Size(75, 23);
            this.foldButton.TabIndex = 8;
            this.foldButton.TabStop = false;
            this.foldButton.Text = "Fold";
            this.foldButton.UseVisualStyleBackColor = true;
            this.foldButton.Click += new System.EventHandler(this.foldButton_Click);
            // 
            // betInput
            // 
            this.betInput.Location = new System.Drawing.Point(32, 395);
            this.betInput.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.betInput.Name = "betInput";
            this.betInput.Size = new System.Drawing.Size(75, 20);
            this.betInput.TabIndex = 10;
            // 
            // player1BalanceLabel
            // 
            this.player1BalanceLabel.AutoSize = true;
            this.player1BalanceLabel.Location = new System.Drawing.Point(407, 129);
            this.player1BalanceLabel.Name = "player1BalanceLabel";
            this.player1BalanceLabel.Size = new System.Drawing.Size(84, 13);
            this.player1BalanceLabel.TabIndex = 11;
            this.player1BalanceLabel.Text = "Player1 Balance";
            // 
            // player2BalanceLabel
            // 
            this.player2BalanceLabel.AutoSize = true;
            this.player2BalanceLabel.Location = new System.Drawing.Point(407, 269);
            this.player2BalanceLabel.Name = "player2BalanceLabel";
            this.player2BalanceLabel.Size = new System.Drawing.Size(84, 13);
            this.player2BalanceLabel.TabIndex = 12;
            this.player2BalanceLabel.Text = "Player2 Balance";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 456);
            this.Controls.Add(this.player2BalanceLabel);
            this.Controls.Add(this.player1BalanceLabel);
            this.Controls.Add(this.betInput);
            this.Controls.Add(this.foldButton);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.raiseButton);
            this.Controls.Add(this.activePlayerIndex);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Player2Cards);
            this.Controls.Add(this.Player1Cards);
            this.Controls.Add(this.bankLabel);
            this.Controls.Add(this.newGameButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.betInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.Label bankLabel;
        private System.Windows.Forms.Label Player1Cards;
        private System.Windows.Forms.Label Player2Cards;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label activePlayerIndex;
        private System.Windows.Forms.Button raiseButton;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Button foldButton;
        private System.Windows.Forms.NumericUpDown betInput;
        private System.Windows.Forms.Label player1BalanceLabel;
        private System.Windows.Forms.Label player2BalanceLabel;
    }
}

