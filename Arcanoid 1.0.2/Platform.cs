using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Arcanoid
{
    class Platform : ICollision
    {//написать методы движения и отрисовки(учесть границы формы)
        public int PosX { get; set; }
        public int PosY { get; private set; }
        public int Width { get; set; }
        public int Height { get; set; }
        int Speed { get; set; }

        public Platform()
        {

        }
        public Platform (int x, int y, int width, int height, int speed)
        {
            PosX = x;
            PosY = y;
            Width = width;
            Height = height;
            Speed = speed;

        }

       
        public CExtends GetExtends()
        {
            CExtends ext = new CExtends(PosX, PosY, Width, Height);
            return ext;
        }
        public void MoveRight()
        {
           PosX += Speed;
        }
        public void MoveLeft()
        {
           PosX -= Speed;
        }
        public void Draw(Graphics Gr)
        {
            SolidBrush brush = new SolidBrush(Color.Blue);
            Gr.FillRectangle(brush, new Rectangle(PosX, PosY, Width, Height));
        }

                
    }
}
