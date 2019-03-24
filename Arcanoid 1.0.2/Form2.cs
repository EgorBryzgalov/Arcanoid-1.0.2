using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arcanoid_1._0._2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Bitmap myBitmap;
        Graphics gr;
        Platform platform;
        Bullet bullet;

        Settings GameSettings;
        List<Block> blocks = new List<Block>();

        public Form2(Settings settings)
        {
            InitializeComponent();
            this.Width = settings.FormWidth;
            this.Height = settings.FormHeight;
            GameSettings = settings;
            
            for (int i = 0; i < 3; i++)
            {
                for (int m = 0; m < GameSettings.GetBlocksRow(); m++)
                {
                    
                    int index = i * GameSettings.GetBlocksRow() + m;
                    int X = 3 + m * (GameSettings.GetBlockSize() + 3);
                    int Y = 3 + i * (GameSettings.GetBlockSize() + 3);
                    blocks.Add(new Block(X,Y, settings));
                    
                }
            }
            platform = new Platform(settings);
            bullet = new Bullet(settings);
            pictureBox1.Width = this.Width-10;
            pictureBox1.Height = this.Height-30;
            myBitmap = new Bitmap(Width, Height);
            gr = Graphics.FromImage(myBitmap);
            


        }
        bool GameStarted = false;
        
        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Space)&&(GameStarted==false))
            {
                timer.Enabled = true;
                GameStarted = true;
                bullet.Start();
            }
            if (e.KeyCode == Keys.Right)
            {
                platform.MoveRight();
            }
            switch (e.KeyCode)
            {
                case (Keys.Right): platform.MoveRight(); break;
                case (Keys.Left): platform.MoveLeft(); break;
            }
            Invalidate();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Invalidate();
            gr.Clear(Color.White);
            platform.Draw(gr);
            
            bullet.Move();
            bullet.Draw(gr);
            bullet.CheckBorder();
            
            if ((bullet.CheckFault(platform.CheckCollision(ref bullet)))==true)
            {
                this.Dispose();
                MessageBox.Show("ПОТРАЧЕНО");
            }
            int index = 0;
            bool collision = false;
            foreach (Block b in blocks)
            {
                if (b.CheckCollision(ref bullet) == true)
                {
                    collision = true;
                    index = blocks.IndexOf(b);
                }
                b.Draw(gr);
            }
            try
            {
                if (collision == true) blocks.RemoveAt(index);
            }
            catch (IndexOutOfRangeException)
            {
                this.Dispose();
                MessageBox.Show("ПОБЕДА");
            }
            pictureBox1.Image = myBitmap;

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            platform.Draw(gr);
            bullet.Draw(gr);
            foreach (Block b in blocks)
            {
                b.Draw(gr);
            }
            pictureBox1.Image = myBitmap;
        }

        

        private void Form2_Paint(object sender, PaintEventArgs e)
        {

            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
