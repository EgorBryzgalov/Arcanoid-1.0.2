using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Arcanoid
{
    public class Block : ICollision
    {   public Point Position {get; set;}
        private int health;
        public int Health 
        {
            get 
            {
                return health;
            }
            set
            {
                if (value<0) 
                    health = 0;
                else 
                    health = value;
            }
        }

        public int Width { get; set; }
        public int Height { get; set; }
        
        public void GetHit()
        {
            Health-=1;
        }

        public Block()
            {

            }
      
        public Block(int x, int y, int width, int height)
        {
            Position = new Point (x, y);
            Width = width;
            Height = height;
        }
        public CExtends GetExtends()
        {
            CExtends ext = new CExtends(Position.X, Position.Y, Width, Height);
            return ext;
        }

        public virtual void Draw(Graphics Gr)
        {
            SolidBrush brush = new SolidBrush(Color.Black);
            Gr.FillRectangle(brush, new Rectangle(Position.X, Position.Y, Width, Height));
        }
        
               

    }
}
