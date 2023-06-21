using System;
using System.Windows.Forms;

namespace GuessNumberGame
{
    public partial class MainForm : Form
    {
        private int targetNumber;
        private bool isPlayer1Winner;
        private bool isPlayer2Winner;

        public MainForm()
        {
            InitializeComponent();
            StartNewGame();
        }

        private void StartNewGame()
        {
            Random random = new Random();
            targetNumber = random.Next(1, 7);
            isPlayer1Winner = false;
            isPlayer2Winner = false;

            player1Label.Text = "Игрок 1";
            player2Label.Text = "Игрок 2";
            guessPlayer1TextBox.Text = string.Empty;
            guessPlayer2TextBox.Text = string.Empty;
            resultLabel.Text = "Угадайте число от 1 до 6";
        }

        private void CheckGuesses()
        {
            int guessPlayer1 = Convert.ToInt32(guessPlayer1TextBox.Text);
            int guessPlayer2 = Convert.ToInt32(guessPlayer2TextBox.Text);

            if (guessPlayer1 == targetNumber)
            {
                isPlayer1Winner = true;
            }

            if (guessPlayer2 == targetNumber)
            {
                isPlayer2Winner = true;
            }

            if (isPlayer1Winner && isPlayer2Winner)
            {
                resultLabel.Text = $"Ничья! Оба игрока угадали число {targetNumber}.";
            }
            else if (isPlayer1Winner)
            {
                resultLabel.Text = $"{player1Label.Text}, вы угадали число {targetNumber}. {player1Label.Text}, выигрываете!";
            }
            else if (isPlayer2Winner)
            {
                resultLabel.Text = $"{player2Label.Text}, вы угадали число {targetNumber}. {player2Label.Text}, выигрываете!";
            }
            else
            {
                resultLabel.Text = "Никто не угадал число. Попробуйте еще раз!";
            }
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            StartNewGame();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            CheckGuesses();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
