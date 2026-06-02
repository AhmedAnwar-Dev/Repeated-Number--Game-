using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repeated_Numbers
{
    public partial class frmStartGame : Form
    {
        public frmStartGame()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (nudRounds.Value == 0)
            {
                MessageBox.Show
                (
                    "Chosse From 1 to 10", 
                    "Wrong",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            else
            {
                Form frmGame = new frmGame(Convert.ToByte(nudRounds.Value));
                frmGame.ShowDialog();
                nudRounds.Value = 0;
            }
        }


    }
}
