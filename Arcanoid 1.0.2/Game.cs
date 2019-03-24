using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arcanoid
{
    class Game
    {
        private List<Block> blocks;
        private Platform platform;
        private Bullet bullet;
        private int Speed { get; set; }
        private int FormWidth { get; set; }
        private int FormHeight { get; set; }
    

        public Game()
        {

        }

        public Game(Settings set)
        {
            FormWidth = set.FormWidth;
            FormHeight = set.FormHeight;
            Speed = set.Speed;
            platform = new Platform(set.FormWidth/2-2*set.GetBlockSize(), set.FormHeight-set.GetBlockSize()/2-3, set.GetBlockSize()*4, set.GetBlockSize()/2);
            bullet = new Bullet(platform.PosX + platform.Width / 2 - set.GetBlockSize() / 4, platform.PosY + set.GetBlockSize() / 2, set.GetBlockSize() / 2, set.GetBlockSize() / 2);
            for (int i = 0; i < 3; i++)
            {
                for (int m = 0; m < set.GetBlocksRow(); m++)
                {

                    int index = i * set.GetBlocksRow() + m;
                    int X = 3 + m * (set.GetBlockSize() + 3);
                    int Y = 3 + i * (set.GetBlockSize() + 3);
                    blocks.Add(new Block(X, Y, set.GetBlockSize(), set.GetBlockSize()));

                }
            }
        }
        public void CheckBorder(Bullet bul)
        {
            CExtends extends = bul.GetExtends();
            if ((extends.LeftX <= 0)||(extends.RightX>=FormWidth)) bullet.InvertXSpeed();
            if (extends.UpperY <= 0) bullet.InvertYSpeed();

        }
        public bool CheckFault (Bullet bul)
        {
            CExtends extends = bul.GetExtends();
            if (extends.UpperY >= FormHeight) return true;
                else return false;
        }
        public void CheckCollision(Block block, Bullet bul)
        {
            
        }

    }
}
