using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arcanoid
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Bitmap myBitmap;
        Graphics gr;
        Game game;
        

        public Form2(Settings settings)
        {
            InitializeComponent();
            game = new Game(settings);
            this.Width = settings.FormWidth;
            this.Height = settings.FormHeight;
            
            pictureBox1.Width = this.Width;
            pictureBox1.Height = this.Height;
            myBitmap = new Bitmap(Width, Height);
            gr = Graphics.FromImage(myBitmap);
            game.Win += WinGame;
            game.Lose += LoseGame;
        }

        private void LoseGame()
        {
            this.Dispose();
            MessageBox.Show("Потрачено!");
        }
        private void WinGame()
        {
            this.Dispose();
            MessageBox.Show("ПОБЕДА");
        }
        
        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                timer.Enabled = true;
                game.OnSpaceKey();
            }
            if (e.KeyCode == Keys.Right)
            {
                game.OnRightKey();
            }
            if (e.KeyCode == Keys.Left)
            {
                game.OnLeftKey();
            }
            
        }

        private void timer_Tick(object sender, EventArgs e)
        {

            game.ProcessFrame();
            game.DrawFrame(gr);
            pictureBox1.Image = myBitmap;

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            game.DrawFrame(gr);
            pictureBox1.Image = myBitmap;
        }

        
       

        
    }
}
