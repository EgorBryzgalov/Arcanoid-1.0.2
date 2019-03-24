using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Arcanoid_1._0._2
{
    class Platform
    {//написать методы движения и отрисовки(учесть границы формы)
        public int PosX { get; set; }
        public int PosY { get; private set; }
        Settings PlatformSettings { get; set; }
        public int Width { get; set; } = 150;
        public int Heigh { get; set; } = 20;
        int Speed { get; set; }

        public Platform(Settings set)
        {
            PlatformSettings = set;
            PosY = set.FormHeight - Heigh-3-50;
            PosX = set.FormWidth / 2 - Width / 2;
            Width = 150;
            Heigh = 20;
            Speed = set.Speed*4;
            
        }

        public void MoveRight()
        {
           if (PosX<=PlatformSettings.FormWidth-Width) PosX += Speed;
        }
        public void MoveLeft()
        {
           if (PosX>=0) PosX -= Speed;
        }
        public void Draw(Graphics Gr)
        {
            SolidBrush brush = new SolidBrush(Color.Blue);
            Gr.FillRectangle(brush, new Rectangle(PosX, PosY, Width, Heigh));
        }

        public bool CheckCollision(ref Bullet bul)
        {
            if ((bul.PosX >= PosX-bul.Width) && (bul.PosX <= (PosX + Width)) && (bul.PosY >= (PosY - bul.Heigh)))
            {
                bul.SpeedY = -bul.SpeedY;
                return true;
            }
            else return false;
        }


    }
}
