using System.Media;
using System.Runtime.InteropServices.Marshalling;

namespace MultiMiniGame
{
    using MultiMiniGame.Game1;
    using MultiMiniGame.Game2;
    using MultiMiniGame.Game3;
    using MultiMiniGame.Game4;

    public partial class Form1 : Form
    {

        SoundPlayer bg;
        public Form1()
        {
            InitializeComponent();
            this.Text = "MENU: Multi Min Game";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lbWelcome.Parent = picBackGround;
            lbWelcome.BackColor = Color.Transparent;

            bg = new SoundPlayer(@"Sounds\soundtrack.wav");
            bg.PlayLooping();
        }

        private void btnGame1_Click(object sender, EventArgs e)
        {
            bg.Stop();
            Game1Form game1 = new Game1Form();
            game1.Show();
            this.Hide();
        }

        private void btnGame2_Click(object sender, EventArgs e)
        {
            bg.Stop();
            Game2Form game2 = new Game2Form();
            game2.Show();
            this.Hide();
        }

        private void btnGame3_Click(object sender, EventArgs e)
        {
            bg.Stop();
            Game3Form game3 = new Game3Form();
            game3.Show();
            this.Hide();
        }

        private void btnGame4_Click(object sender, EventArgs e)
        {
            bg.Stop();
            Game4.Game4Form game4 = new Game4.Game4Form();
            game4.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            bg.Stop();
            this.Close();
        }
    }
}
