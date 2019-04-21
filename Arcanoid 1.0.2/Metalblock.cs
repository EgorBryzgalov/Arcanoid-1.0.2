using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Arcanoid
{
    public class MetalBlock : Block
    {
        public Image Texture { get; set; }

        public MetalBlock(int x, int y, int width, int height) : base(x, y, width, height)
        {
            Health = 2;
            Texture = Properties.Resources.Metal;

        }

        public override void Draw(Graphics gr)
        {
                      
            Rectangle rect = new Rectangle(Position.X, Position.Y, Width, Height);
            gr.DrawImage(Texture, rect);
        }
    }
}
