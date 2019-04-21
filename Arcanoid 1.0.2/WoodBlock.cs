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
        public Image Texture { get; set; }
        public WoodBlock (int x, int y, int width, int height) : base (x, y,  width, height)
        {
            Health = 1;
            Texture = Properties.Resources.Wood;
        }
        public override void Draw(Graphics Gr)
        {
                        
            Rectangle rect = new Rectangle(Position.X, Position.Y, Width, Height);
            Gr.DrawImage(Texture, rect);
           
        }
    }
}
