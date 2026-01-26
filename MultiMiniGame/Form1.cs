using System.Media;
using System.Runtime.InteropServices.Marshalling;

namespace MultiMiniGame
{
    using MultiMiniGame.Game1;
    using MultiMiniGame.Game2;
    using MultiMiniGame.Game3;

    public partial class Form1 : Form
    {
        
        SoundPlayer bg;
        public Form1()
        {
            InitializeComponent();
        }    
        private void Form1_Load(object sender, EventArgs e)
        {
            bg = new SoundPlayer(@"Sounds\soundtrack.wav");
            bg.PlayLooping();
        }

        private void btnGame1_Click(object sender, EventArgs e)
        {
            bg.Stop();
            Game1Form game1 = new Game1Form();
            game1.Show();
        }

        private void btnGame2_Click(object sender, EventArgs e)
        {
            bg.Stop();
            Game2Form game2 = new Game2Form();
            game2.Show();
        }

        private void btnGame3_Click(object sender, EventArgs e)
        {
            bg.Stop();
            Game3Form game3 = new Game3Form();
            game3.Show();
        }
    }
}
