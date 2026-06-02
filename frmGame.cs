using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repeated_Number_Logic;

namespace Repeated_Numbers_UI
{
    public partial class frmGame : Form
    {
        // Start Game Varibale

        //Connects business logic with the UI
        private clsRepteadNumber _GameRep;

        // This list stores all buttons used by the user to guess the repeated number
        private List<Button> _numberButtons = new List<Button>();

        //A reusable random number generator to be called from anywhere
        private Random _rnd = new Random();

        // End Game Varibale

        public frmGame(byte Rounds)
        {
            InitializeComponent();
            // Store all number buttons into the _numberButtons list
            _LoadNumberButtonsIntoList();

            //Initializes the class and sets the total rounds the player wants to play
            _GameRep = new clsRepteadNumber(Rounds);
        }

        // Start Game Function
        private void _LoadNumberButtonsIntoList()
        {
            foreach (Control control in this.Controls)
            {
                // This condition is added because each button is linked to its buttonNumber via the Tag property
                if (control is Button btn && control.Tag?.ToString()  == "buttonNumber")
                {
                    // Add All Button On List
                    _numberButtons.Add(btn);
                }
            }
        }
        private List<byte> _PopulateButtonsWithRandomNumbers()
        {
            // Populate buttons with random numbers to bind the UI to the game logic
            List<byte> EachNumberInButton = new List<byte>();

            foreach (Button btn in _numberButtons)
            {
                // Create a random number for each button
                byte RandomNumber = Convert.ToByte(_rnd.Next(0, 9));

                btn.Text = RandomNumber.ToString();

                EachNumberInButton.Add(RandomNumber);
            }

            return EachNumberInButton;
        }
        private void _InitializeRound()
        {
            // SetupNewRound logic is implemented in clsRepteadNumber
            _GameRep.SetupNewRound(_PopulateButtonsWithRandomNumbers());

            // Display the number the user must find
            btnNumberRepeat.Text = _GameRep.targetNumber.ToString();

            // Update the UI with the current round and total rounds
            btnRoundNumber.Text = "Round\n" + _GameRep.currentRound + " \\ " + _GameRep.totalRounds.ToString();
        } // Called each round to refresh the button numbers, target number and related UI
        private void _ApplyWrongAnswerStyle()
        {
            lblIsCorrect.ForeColor = Color.Red;
            lblIsCorrect.Text = "Wrong?";
            lblIsCorrect.Visible = true;
        } // Show that the current or previous answer was wrong
        private void _ApplyCorrectAnswerStyle()
        {
            lblIsCorrect.ForeColor = Color.Green;
            lblIsCorrect.Text = "Correct!";
            lblIsCorrect.Visible = true;
        } // Show that the current or previous answer was correct
        private void _ApplyTimedOutStyle()
        {
            lblIsCorrect.ForeColor = Color.Yellow;
            lblIsCorrect.Text = "Timed Out!";
            lblIsCorrect.Visible = true;
        } // Show that the current or previous answer was Timed Out
        private void _GameEnd()
        {
            Form frmGameEnd = new frmGameEnd(_GameRep.correctAnswersCount, _GameRep.wrongAnswersCount, _GameRep.totalRounds);
            frmGameEnd.ShowDialog();
        } // Open the end-game form and pass the final results
        // End Game Function

        // Start Event Controls
        private void tmrTime_Tick(object sender, EventArgs e)
        {
            // Timer value shown to the user
            lblRoundTime.Text = _GameRep.timerCountdown.ToString();

            if (_GameRep.timerCountdown == 0)
            {
                _GameRep.RegisterTimeOut();
                _ApplyTimedOutStyle();
                _InitializeRound();
            }
            // If the game is over after a timeout reset, stop the timer and end the game
            if (_GameRep.IsGameOver && _GameRep.timerCountdown == 10)
            {
                tmrTime.Enabled = false;
                _GameEnd();
            }
            _GameRep.timerCountdown--;
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Read the user's final answer and convert it to byte for comparison
            byte UserAnswer = Convert.ToByte(mtbNumberRepeted.Text);
            bool IsAnswerTrue = _GameRep.SubmitAnswer(UserAnswer);

            // If the user submitted an empty value, show an error message
            if (string.IsNullOrEmpty(mtbNumberRepeted.Text))
            {
                MessageBox.Show
                (
                    "Please Enter Number From 1 To 9",
                    "Number Wrong",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

            else if (IsAnswerTrue)
            {
                _ApplyCorrectAnswerStyle();
            }

            else
            {
                _ApplyWrongAnswerStyle();
            }
            if (_GameRep.IsGameOver)
            {
                tmrTime.Enabled = false;
                _GameEnd();
                return;
            }

            _InitializeRound();
            // Clearing and focusing the input improves UX by making it easier for the user to enter the next value
            mtbNumberRepeted.Clear();
            mtbNumberRepeted.Focus();
        }
        private void frmGame_Load(object sender, EventArgs e)
        {
            mtbNumberRepeted.Focus();

            // Start the timer when the form is created
            tmrTime.Enabled = true;
            
            // Initialize the first round on form load
            _InitializeRound();
        }
        // End Event Controls

    }
}