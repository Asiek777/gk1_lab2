using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gk1_lab2
{
    class Vertex
    {
        int x, y;

        public Vertex(int x, int y)
        {
            X = x;
            Y = y;
        }

        public double calcDistance(int x2, int y2)
            => Math.Sqrt((double)((x - x2) * (x - x2) + (y - y2) * (y - y2)));

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
    }
}
