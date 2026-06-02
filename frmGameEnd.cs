using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repeated_Numbers_UI
{
    public partial class frmGameEnd : Form
    {
        private byte _Correct;
        private byte _Wrong;
        private byte _Rounds;
        public frmGameEnd(byte Correct, byte Wrong, byte Rounds)
        {
            InitializeComponent();
            _Correct = Correct;
            _Wrong = Wrong;
            _Rounds = Rounds;
        }
        private void Passed()
        {
            lblIsPassed.ForeColor = Color.Green;
            lblIsPassed.Text = "Passed";
        }
        private void Failed()
        {
            lblIsPassed.ForeColor = Color.Red;
            lblIsPassed.Text = "Failed";
        }
        private void frmGameEnd_Load(object sender, EventArgs e)
        {
            lblWrong.Text = _Wrong.ToString();
            lblCorrect.Text = _Correct.ToString();
            lblRounds.Text = _Rounds.ToString();

            if (_Correct > _Wrong)
            {
                Passed();
            }
            else
            {
                Failed();
            }
        }

        private void btnResetGame_Click(object sender, EventArgs e)
        {
            Form frmGame = new frmStartGame();
            List<Form> OpenForms = new List<Form>(Application.OpenForms.Cast<Form>());

            foreach (Form f in OpenForms)
            {
                if (f is frmStartGame)
                {
                    f.Show();
                }
                else
                {
                    f.Close();
                }
            }
        }
    }
}
