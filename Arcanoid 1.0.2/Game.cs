using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Arcanoid
{
    class Game
    {
        private List<Block> blocks;
        private Platform platform;
        private Bullet bullet;
        private int Speed { get; set; }
        private int FormWidth { get; set; }
        private int FormHeight { get; set; }
        private bool GameStarted { get; set; }
    

        public Game()
        {

        }

        public Game(Settings set)
        {
            FormWidth = set.FormWidth;
            FormHeight = set.FormHeight;
            Speed = set.Speed;
            platform = new Platform(set.FormWidth/2-2*set.GetBlockSize(), set.FormHeight-set.GetBlockSize()/2-50, set.GetBlockSize()*4, set.GetBlockSize()/2, Speed*4);
            bullet = new Bullet(platform.PosX + platform.Width / 2 - set.GetBlockSize() / 4, platform.PosY - set.GetBlockSize() / 2, set.GetBlockSize() / 2, set.GetBlockSize() / 2);
            blocks = new List<Block>();
            for (int i = 0; i < 3; i++)
            {
                for (int m = 0; m < set.GetBlocksRow(); m++)
                {

                    int index = i * set.GetBlocksRow() + m;
                    int X = 3 + m * (set.GetBlockSize() + 3);
                    int Y = 3 + i * (set.GetBlockSize() + 3);
                    blocks.Add(new Block(X, Y, set.GetBlockSize(), set.GetBlockSize()));

                }
            }
        }
        public void CheckBorder(Bullet bul)
        {
            CExtends extends = bul.GetExtends();
            
            if ((extends.LeftX <= 0)||(extends.RightX>=FormWidth-15)) bullet.InvertXSpeed();
            if (extends.UpperY <= 0) bullet.InvertYSpeed();

        }
        
        public bool CheckFault ()
        {
            CExtends extends = bullet.GetExtends();
            if (extends.UpperY >= FormHeight)
            {
                Lose();
                return true;
            }
            else return false;
        }
        public void CheckPlatfrom()
        {
            if (CExtends.IsIntersected(bullet.GetExtends(), platform.GetExtends()))
            {
               if (GameStarted) bullet.InvertYSpeed();
            }
        }
        public bool CheckCollision(Block block)
        {

            if (CExtends.IsIntersected(block.GetExtends(), bullet.GetExtends()))
            {
                CExtends BlockExtends = block.GetExtends();
                CExtends BulletExtends = bullet.GetExtends();
                Point bulpt = BulletExtends.Center;
                Point blockpt = BlockExtends.Center;
                int dx = blockpt.X - (bulpt.X - bullet.SpeedX);
                int dy = blockpt.Y - (bulpt.Y - bullet.SpeedY);
                float tga = 1;
                try
                {
                    tga = Math.Abs(dx) / Math.Abs(dy);
                }
                catch (DivideByZeroException)
                {

                }

                if (tga >= 1)
                {
                    bullet.InvertXSpeed();
                }
                //   if (tga==1)
                // {
                //     if (bul.XSpeedCorrected == false) bul.SpeedX = -bul.SpeedX;
                //    bul.XSpeedCorrected = true;
                //       if (bul.YSpeedCorrected == false) bul.SpeedY = -bul.SpeedY;
                //       bul.YSpeedCorrected = true;
                //    }
                if (tga < 1)
                {
                    bullet.InvertYSpeed();
                }
                return true;
            }
            else return false;
            
        }
        public delegate void Container();
        public event Container Win;
        public event Container Lose;
        public void ProcessFrame()
        {
            CheckBorder(bullet);
            CheckFault();
            CheckPlatfrom();
            bullet.Move();
            int index=0;
            bool allowdelete = false;
            foreach (Block b in blocks)
            {
                                
                if (CheckCollision(b))
                {
                    index = blocks.IndexOf(b);
                    allowdelete = true;                                     
                }
            }
            try
            {
               if (allowdelete) blocks.RemoveAt(index);
                allowdelete = false;
            }
            catch (IndexOutOfRangeException)
            {
                Win();
            }
        }
        public void OnRightKey()
        {
            if (platform.GetExtends().RightX <= FormWidth) { platform.MoveRight(); }
        }
        public void OnLeftKey()
        {
            if (platform.GetExtends().LeftX>=0) { platform.MoveLeft(); }
        }
        public void OnSpaceKey()
        {
            if (GameStarted == false)
            {
                bullet.Start(Speed);
                bullet.Move();
            }
            GameStarted = true;
        }
        public void DrawFrame(Graphics gr)
        {
            gr.Clear(Color.White);
            foreach (Block b in blocks)
            {
                b.Draw(gr);
            }
            platform.Draw(gr);
            bullet.Draw(gr);
        }
            
        

    }
}
