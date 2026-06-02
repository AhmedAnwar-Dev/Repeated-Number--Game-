using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repeated_Number;


namespace Repeated_Numbers
{
    public partial class frmGame : Form
    {
        clsRepteadNumber GameRep;
        private byte _targetNumber = 0;
        public byte _totalRounds = 0;
        private byte _timerCountdown = 10;
        private byte _currentRound = 0;
        private byte _targetNumberCount = 0;
        private byte _correctAnswersCount = 0;
        private byte _wrongAnswersCount = 0;
        List<Button> _numberButtons = new List<Button>(25);
        Random rnd = new Random();

        private void _LoadNumberButtonsIntoList()
        {
            foreach (Control control in this.Controls)
            {
                if (control is Button btn && control.Tag?.ToString()  == "buttonNumber")
                {
                    _numberButtons.Add(btn);
                }
            }
        }
        private void _PopulateButtonsWithRandomNumbers()
        {
            foreach (Button btn in _numberButtons)
            {
                btn.Text = rnd.Next(0, 9).ToString();
            }
        }
        private byte _PickRandomTargetNumber()
        {
            return Convert.ToByte(_numberButtons[rnd.Next(0, 24)].Text);
        }
        private void _InitializeRound()
        {
            _PopulateButtonsWithRandomNumbers();
            _targetNumber = _PickRandomTargetNumber();
            _CalculateTargetNumberRepetitions();
            btnNumberRepeat.Text = _targetNumber.ToString();
            btnRoundNumber.Text = "Round\n" + _currentRound + " \\ " + _totalRounds.ToString();
        }
        private void _CalculateTargetNumberRepetitions()
        {
            byte count = 0;


            foreach (Button btn in _numberButtons)
            {
                byte number = Convert.ToByte(btn.Text); ;
                if (number == _targetNumber)
                    count++;
            }
            _targetNumberCount = count;
        }
        private void _ApplyWrongAnswerStyle()
        {
            lblIsCorrect.ForeColor = Color.Red;
            lblIsCorrect.Text = "Wrong?";
            lblIsCorrect.Visible = true;
        }
        private void _ApplyCorrectAnswerStyle()
        {
            lblIsCorrect.ForeColor = Color.Green;
            lblIsCorrect.Text = "Correct!";
            lblIsCorrect.Visible = true;
        }
        private void _GameEnd()
        {
            Form frmGameEnd = new frmGameEnd(_correctAnswersCount, _wrongAnswersCount, _totalRounds);
            frmGameEnd.ShowDialog();
        }
        public frmGame(byte Rounds)
        {
            InitializeComponent();
            _totalRounds = Rounds;
            _LoadNumberButtonsIntoList();
            GameRep = new clsRepteadNumber(Rounds);
        }

        private void tmrTime_Tick(object sender, EventArgs e)
        {
            lblRoundTime.Text = _timerCountdown.ToString();

            if (_timerCountdown == 0)
            {
                _currentRound++;
                _timerCountdown = 10;
                _wrongAnswersCount++;
                _ApplyWrongAnswerStyle();
                _InitializeRound();
            }
            if (_currentRound == _totalRounds && _timerCountdown == 10)
            {
                tmrTime.Enabled = false;
                _GameEnd();
            }
                _timerCountdown--;
        }
        private void frmGame_Load(object sender, EventArgs e)
        {
            mtbNumberRepeted.Focus();
            tmrTime.Enabled = true;
            _InitializeRound();
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
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
            else if (_targetNumberCount == Convert.ToByte(mtbNumberRepeted.Text))
            {
                _ApplyCorrectAnswerStyle();
                _timerCountdown = 10;
                _currentRound++;
                _correctAnswersCount++;
            }
            else
            {
                _ApplyWrongAnswerStyle();
                _timerCountdown = 10;
                _currentRound++;
                _wrongAnswersCount++;
            }

            _InitializeRound();
            mtbNumberRepeted.Clear();
            mtbNumberRepeted.Focus();

            if (_currentRound == _totalRounds)
            {
                tmrTime.Enabled = false;
                _GameEnd();
                return;
            }
        }
    }
}