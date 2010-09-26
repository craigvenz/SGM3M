using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sgm3m1.Classes
{
    public struct Extents
    {
        public int Width { get; set; }
        public int Height { get; set; }
    }
    public class Board
    {
        public Extents Size { get; private set; }
        Tile[,] data;

        public Board(int w, int h)
        {
            Size.Width = w;
            Size.Height = h;
        }
    }
}
