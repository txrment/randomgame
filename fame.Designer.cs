namespace GuessNumberGame
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.player1Label = new System.Windows.Forms.Label();
            this.player2Label = new System.Windows.Forms.Label();
            this.guessPlayer1TextBox = new System.Windows.Forms.TextBox();
            this.guessPlayer2TextBox = new System.Windows.Forms.TextBox();
            this.newGameButton = new System.Windows.Forms.Button();
            this.checkButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // player1Label
            // 
            this.player1Label.AutoSize = true;
            this.player1Label.Location = new System.Drawing.Point(30, 30);
            this.player1Label.Name = "player1Label";
            this.player1Label.Size = new System.Drawing.Size(53, 15);
            this.player1Label.TabIndex = 0;
            this.player1Label.Text = "Игрок 1:";
            // 
            // player2Label
            // 
            this.player2Label.AutoSize = true;
            this.player2Label.Location = new System.Drawing.Point(30, 60);
            this.player2Label.Name = "player2Label";
            this.player2Label.Size = new System.Drawing.Size(53, 15);
            this.player2Label.TabIndex = 1;
            this.player2Label.Text = "Игрок 2:";
            // 
            // guessPlayer1TextBox
            // 
            this.guessPlayer1TextBox.Location = new System.Drawing.Point(100, 27);
            this.guessPlayer1TextBox.Name = "guessPlayer1TextBox";
            this.guessPlayer1TextBox.Size = new System.Drawing.Size(100, 23);
            this.guessPlayer1TextBox.TabIndex = 2;
            // 
            // guessPlayer2TextBox
            // 
            this.guessPlayer2TextBox.Location = new System.Drawing.Point(100, 57);
            this.guessPlayer2TextBox.Name = "guessPlayer2TextBox";
            this.guessPlayer2TextBox.Size = new System.Drawing.Size(100, 23);
            this.guessPlayer2TextBox.TabIndex = 3;
            // 
            // newGameButton
            // 
            this.newGameButton.Location = new System.Drawing.Point(33, 100);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(100, 23);
            this.newGameButton.TabIndex = 4;
            this.newGameButton.Text = "Новая игра";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(136, 100);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(100, 23);
            this.checkButton.TabIndex = 5;
            this.checkButton.Text = "Проверить";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(30, 150);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 15);
            this.resultLabel.TabIndex = 6;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 200);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.newGameButton);
            this.Controls.Add(this.guessPlayer2TextBox);
            this.Controls.Add(this.guessPlayer1TextBox);
            this.Controls.Add(this.player2Label);
            this.Controls.Add(this.player1Label);
            this.Name = "MainForm";
            this.Text = "Угадай число";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label player1Label;
        private System.Windows.Forms.Label player2Label;
        private System.Windows.Forms.TextBox guessPlayer1TextBox;
        private System.Windows.Forms.TextBox guessPlayer2TextBox;
        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Label resultLabel;
    }
}


