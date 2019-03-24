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
        private int Speed;

        public Game()
        {

        }

        public Game(Settings set)
        {
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

    }
}
