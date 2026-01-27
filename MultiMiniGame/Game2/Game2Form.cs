using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MultiMiniGame.Game2
{
    public partial class Game2Form : Form
    {
        public Game2Form()
        {
            InitializeComponent();
        }

        private void Game2Form_Load(object sender, EventArgs e)
        {
            btnA.Text = " A.  " + btnA.Text;
            btnB.Text = " B.  " + btnB.Text;
            btnC.Text = " C.  " + btnC.Text;
            btnD.Text = " D.  " + btnD.Text;
        }

        private void btnA_Click(object sender, EventArgs e)
        {

        }
    }
}
