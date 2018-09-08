using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace GameOfLife
{
    public class CellTests
    {
        [Test]
        public void Cell_IsAlive()
        {
            var cell = new Cell
            {
                IsAlive = true
            };

            var result = cell.IsAlive;

            Assert.That(result, Is.True);
        }
    }

    public class Cell
    {
        public bool IsAlive;
    }
}
