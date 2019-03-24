using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Arcanoid
{
    public class CExtends
    {// описывает размеры графического объекта и определяет столкновения
        public int LeftX { get; set; }
        public int RightX { get; set; }
        public int UpperY { get; set; }
        public int BottomY { get; set; }

        public CExtends()
        {

        }
        public CExtends(int X, int Y, int Width, int Heigh)
        {
            LeftX = X;
            UpperY = Y;
            RightX = X + Width;
            BottomY = Y + Heigh;
        }
        
    }
}
