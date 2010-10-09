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
            _size = new Extents();
            Size.Width = w;
            Size.Height = h;
            data = new Tile[w, h];
        }

        // encapsulation violation
        public Tile[,] Data
        {
            get
            {
                return data;
            }
        }
        
        // Violation of SRP?
        public static Board CreateEmptyBoard(int w, int h)
        {
            Board b = new Board(w, h);
            for (int x = 0; x < b.Size.Width; x++)
                for (int y = 0; y < b.Size.Height; y++)
                	b.data[x,y]=new EmptyTile();
            return b;
        }

        // encapsulation violation?
        public Extents Size
        {
            get
            {
                return _size;
            }
            set
            {
                _size = value;
            }
        }


    }
}
