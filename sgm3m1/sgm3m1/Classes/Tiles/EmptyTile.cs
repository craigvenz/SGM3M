using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sgm3m1.Classes
{
    public class EmptyTile : Tile
    {

        public TileTypes Type
        {
            get { return TileTypes.Empty; }
        }
    }
}
