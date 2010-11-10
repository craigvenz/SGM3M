using System;
using Xunit;
using sgm3m1.Classes;

namespace Tests
{
    public class sgm3mTests
    {
        [Fact]
        public void TilesTest()
        {
            
        }
        [Fact]
        public void BoardTest()
        {
            Board b = new Board(10, 10);
            Assert.Equal(10,b.Size.Width);
            Assert.Equal(10,b.Size.Height);
        }
        [Fact]
        public void GeneratorTest()
        {
            Board b = new Board(10, 10);
            BoardGenerator bg = new BoardGenerator();
            bg.Generate(b);
            for (int y = 0; y < b.Size.Height; y++)
            {
                Console.Write("|");
                for (int x = 0; x < b.Size.Width; x++)
                {
                    string s;
                    switch (b.DataAt(x,y).Type)
                    {
                    	case TileTypes.Empty:
                            s=" ";
                    		break;
                        default:
                            s = b.DataAt(x, y).Type.ToString().Substring(0, 1);
                            break;
                    }
                    Console.Write(s);
                }
                Console.WriteLine("|");
            }
        }
    }
}
