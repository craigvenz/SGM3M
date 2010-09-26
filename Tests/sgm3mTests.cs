using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            Assert.Equal(b.Size.Width, 10);
            Assert.Equal(b.Size.Height, 10);
        }

    }
}
