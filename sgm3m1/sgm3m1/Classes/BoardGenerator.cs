using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sgm3m1.Classes
{
    public class BoardGenerator
    {
        private Random _random;

        public BoardGenerator() : this(new Random())
        {
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
            {
                for (int y = 0; y < target.Size.Height; y++)
                {
                    Tile z=null;
                    switch ((TileTypes)_random.Next((int)TileTypes.Normal, (int)TileTypes.Special))
                    {
                    	case TileTypes.Normal:
                            z = (Tile)new NormalTile();
                    		break;
                        case TileTypes.Special:
                            z=(Tile)new SpecialTile();
                            break;
                    }
                    target.SetDataAt(x,y, z);
                }
            }                        
        }
    }
}
