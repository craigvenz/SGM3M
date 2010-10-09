using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sgm3m1.Classes
{
    class BoardGenerator
    {
        private Random _random;

        public BoardGenerator()
        {
            BoardGenerator(new Random());
        }
        public BoardGenerator(Random x) 
        {
            _random = x;
        }
        public BoardGenerator(int seed)
        {
            _random = new Random(seed);
        }
        // candidate for strategy pattern
        public void Generate(Board target)
        {
            for (int x = 0; x < target.Size.Width; x++)
                for (int y = 0; y < target.Size.Height; y++)
                {
                    Tile z;
                    switch ((TileTypes)_random.Next(TileTypes.Normal, TileTypes.Special))
                    {
                    	case TileTypes.Normal:
                    		z=new NormalTile();
                    		break;
                        case TileTypes.Special:
                            z=new SpecialTile();
                            break;
                    }
                    target.Data[x,y] = z;
                }
            }                        
        }
    }
}
