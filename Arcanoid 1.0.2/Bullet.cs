using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Arcanoid
{
    public class Bullet : ICollision
    {
        public int PosX { get; set; }
        public int PosY { get; set; }
        public int SpeedX { get; set; }
        public int SpeedY { get; set; }
        Settings BulletSettings { get; set; }
        public bool XSpeedCorrected { get; set; }
        public bool YSpeedCorrected { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public Bullet(int x, int y, int width, int height)
        {
            PosX = x;
            PosY = y;
            Width = width;
            Height = height;
        }

        public Bullet(Settings set)
        {
            BulletSettings = set;
            SpeedY = 0;
            SpeedX = 0;
            Width = set.GetBlockSize() / 2;
            Height = set.GetBlockSize() / 2;
            PosY = set.FormHeight - 20 - 3 - Height-50; ;
            PosX = set.FormWidth / 2 - Width/2;
        }
        public CExtends GetExtends()
        {
            CExtends ext = new CExtends(PosX, PosY, Width, Height);
            return ext;
        }
        public void Start(int speed)
        {
            SpeedX = speed;
            SpeedY = -speed;
        }
        public void Move()
        {
            PosX += SpeedX;
            PosY += SpeedY;
            XSpeedCorrected = false;
            YSpeedCorrected = false;
        }
        public void InvertXSpeed()
        {
            SpeedX = -SpeedX;
        }
        public void InvertYSpeed()
        {
            SpeedY = -SpeedY;
        }
        
        
        public void Draw(Graphics Gr)
        {
            SolidBrush brush = new SolidBrush(Color.Blue);
            Gr.FillRectangle(brush, new Rectangle(this.PosX, this.PosY, Width, Height));
        }
        

    }

}
