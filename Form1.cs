namespace meet1winform
{
    public partial class Form1 : Form
    {
        private int max = 2000;
        private int min = 1;
        private int attempts;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for playing our game!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Application.Exit();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            string gameRules = "Welcome to the Number Guessing Game!\n\n" +
                              "In this game, you think of a number between 1 and 2000, and the computer will try to guess it using a binary search algorithm.\n\n" +
                              "You'll respond to the computer's guesses with 'Yes' if the guessed number is correct, 'No, higher' if the number is higher, or 'No, smaller' if the number is smaller.\n\n" +
                              "The game continues until the computer successfully guesses your number or you start a new game.\n\n" +
                              "Have fun and enjoy the game!";

            MessageBox.Show(gameRules, "Game Rules", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Think of a number between 1 and 2000, and press 'Yes' to start the game.", "Number Guess Game", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                attempts = 0;
                PlayGame(min, max);
            }
            else
            {
                // Ничего не делаем, игра не началась
            }
        }

        private void PlayGame(int min, int max)
        {
            int guess = (min + max) / 2; // Вычисляем среднее значение

            attempts++;

            DialogResult result = MessageBox.Show($"Is the guessed number: {guess}?\n\nYes - Number Guessed\nNo - Number is Higher\nCancel - Number is Smaller", "Number Guess Game", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show($"The program guessed your number ({guess}) in {attempts} attempts. Do you want to play again?", "Number Guess Game", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            else if (result == DialogResult.No)
            {
                PlayGame(guess + 1, max); // Число больше
            }
            else if (result == DialogResult.Cancel)
            { 
                PlayGame(min, guess - 1); // Число меньше
            }
        }

    }
}