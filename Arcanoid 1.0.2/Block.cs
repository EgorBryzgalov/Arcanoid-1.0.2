using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Arcanoid
{
    public class Block
    {   
        public int PosX { get; set; }
        public int PosY { get; set; }
        Settings BlockSettings { get; set; }

        public Block()
            {

            }
      
        public Block(int x, int y, Settings set)
        {
            PosX = x;
            PosY = y;
            BlockSettings = set;
        }

        public void Draw(Graphics Gr)
        {
            SolidBrush brush = new SolidBrush(Color.Black);
            Gr.FillRectangle(brush, new Rectangle(PosX, PosY, BlockSettings.GetBlockSize(), BlockSettings.GetBlockSize()));
        }
        
        public bool CheckCollision(ref Bullet bul)
        {
            if ((bul.PosX >= (PosX - BlockSettings.GetBlockSize()/2)) && (bul.PosX <= (PosX + BlockSettings.GetBlockSize()/2)))
            {
                if ((bul.PosY <= (PosY + BlockSettings.GetBlockSize())) && (bul.PosY >= (PosY - BlockSettings.GetBlockSize())))
                {
                    Point bulpt = bul.GetCenter();
                    Point blockpt = this.GetCenter();
                    int dx = blockpt.X - (bulpt.X-bul.SpeedX);
                    int dy = blockpt.Y - (bulpt.Y-bul.SpeedY);
                    float tga=1;
                    try
                    {
                        tga = Math.Abs(dx) / Math.Abs(dy);
                    }
                    catch (DivideByZeroException)
                    {

                    }
                    
                    if (tga>=1)
                    {
                       if (bul.XSpeedCorrected==false) bul.SpeedX = -bul.SpeedX;
                        bul.XSpeedCorrected = true;
                    }
                 //   if (tga==1)
                   // {
                   //     if (bul.XSpeedCorrected == false) bul.SpeedX = -bul.SpeedX;
                    //    bul.XSpeedCorrected = true;
                 //       if (bul.YSpeedCorrected == false) bul.SpeedY = -bul.SpeedY;
                 //       bul.YSpeedCorrected = true;
                //    }
                    if (tga <1)
                    {
                        if (bul.YSpeedCorrected == false) bul.SpeedY = -bul.SpeedY;
                        bul.YSpeedCorrected = true;
                    }
                    return true;
                }
                else return false;
            }
            else return false;
        }


        public Point GetCenter()
        {
            Point center = new Point();
            center.X = PosX + BlockSettings.GetBlockSize() / 2;
            center.Y = PosY + BlockSettings.GetBlockSize() / 2;
            return center;
        }

    }
}
