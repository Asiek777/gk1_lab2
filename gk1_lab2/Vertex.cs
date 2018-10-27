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

        public static double calcDistance(Vertex v1, Vertex v2)
            => Math.Sqrt((double)((v1.X - v2.X) * (v1.X - v2.X) + (v1.Y - v2.Y) * (v1.Y - v2.Y)));

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
    }
}
