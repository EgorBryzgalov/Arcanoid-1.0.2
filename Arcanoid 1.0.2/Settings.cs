using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arcanoid
{
    public class Settings
    {
        public int Speed { get; set; }
        public int BlocksQuantity { get; set; }
        public int FormWidth { get; set; }
        public int FormHeight { get; set; }

        public Settings()
        {
            FormWidth = 1000;
            FormHeight = 600;
            Speed = 50;
            BlocksQuantity = 60;
        }

        //данный конструктор используется для создания объекта settings и передачи его игровой форме
        public Settings(int speed)
        {
            FormWidth = 1000;
            FormHeight = 600;
            BlocksQuantity = 60;
            Speed = speed;
        }

        public int GetBlockSize()
        {
            int size = (FormWidth-2*3-(GetBlocksRow()-1)*3 )/ (GetBlocksRow());
            return size;
        }

        public int GetBlocksRow()
        {
            return BlocksQuantity / 3;
        }
    }
}
