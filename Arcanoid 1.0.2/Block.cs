using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Arcanoid
{
    public class Block : ICollision
    {   
        public int PosX { get; set; }
        public int PosY { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        

        public Block()
            {

            }
      
        public Block(int x, int y, int width, int height)
        {
            PosX = x;
            PosY = y;
            Width = width;
            Height = height;
        }
        public CExtends GetExtends()
        {
            CExtends ext = new CExtends(PosX, PosY, Width, Height);
            return ext;
        }

        public void Draw(Graphics Gr)
        {
            SolidBrush brush = new SolidBrush(Color.Black);
            Gr.FillRectangle(brush, new Rectangle(PosX, PosY, Width, Height));
        }
        
               

    }
}
