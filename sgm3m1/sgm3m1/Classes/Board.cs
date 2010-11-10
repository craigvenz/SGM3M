using System;

namespace sgm3m1.Classes
{
    public class Board
    {
        private Extents _size;
        private Tile[,] _data;

        public Board(int w, int h)
        {
            _size = new Extents();
            Size.Width = w;
            Size.Height = h;
            _data = new Tile[w, h];
        }

        // encapsulation violation
        public Tile DataAt(int x,int y)
        {
            //throw if out of range
            return _data[x, y];
        }

        public void SetDataAt(int x,int y,Tile t)
        {
            _data[x, y] = t;
        }
        
        // Violation of SRP?
        public static Board CreateEmptyBoard(int w, int h)
        {
            Board b = new Board(w, h);
            for (int x = 0; x < b.Size.Width; x++)
                for (int y = 0; y < b.Size.Height; y++)
                	b._data[x,y]=(Tile)new EmptyTile();
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
