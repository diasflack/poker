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
            this.betLabel = new System.Windows.Forms.Label();
            this.Player1Cards = new System.Windows.Forms.Label();
            this.Player2Cards = new System.Windows.Forms.Label();
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
            // betLabel
            // 
            this.betLabel.AutoSize = true;
            this.betLabel.Location = new System.Drawing.Point(235, 201);
            this.betLabel.Name = "betLabel";
            this.betLabel.Size = new System.Drawing.Size(23, 13);
            this.betLabel.TabIndex = 1;
            this.betLabel.Text = "Bet";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 456);
            this.Controls.Add(this.Player2Cards);
            this.Controls.Add(this.Player1Cards);
            this.Controls.Add(this.betLabel);
            this.Controls.Add(this.newGameButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.Label betLabel;
        private System.Windows.Forms.Label Player1Cards;
        private System.Windows.Forms.Label Player2Cards;
    }
}

