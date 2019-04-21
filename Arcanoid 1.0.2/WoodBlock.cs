using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Arcanoid
{
    class WoodBlock : Block
    {
        public WoodBlock (int x, int y, int width, int height) : base (x, y,  width, height)
        {
            Health = 1;
        }
        public override void Draw(Graphics Gr)
        {
            SolidBrush brush = new SolidBrush(Color.Brown);
            Image image = Properties.Resources.Wood;
            Rectangle rect = new Rectangle(Position.X, Position.Y, Width, Height);
            Gr.DrawImage(image, rect);
           
        }
    }
}
