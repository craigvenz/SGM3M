using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sgm3m1.Classes
{
    public class Board
    {
        private Extents _size;
        private Tile[,] data;

        public Board(int w, int h)
        {
            _size.Width = w;
            _size.Height = h;
            data = new Tile[w, h]();
        }

        public Extents Size { get; private set; }
    }
}
