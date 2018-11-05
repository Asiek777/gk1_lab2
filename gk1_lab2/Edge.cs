using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gk1_lab2
{
    class Edge
    {
        Vertex v1, v2;

        public Edge(Vertex v1, Vertex v2)
        {
            V1 = v1;
            V2 = v2;
        }

        internal Vertex V1 { get => v1; set => v1 = value; }
        internal Vertex V2 { get => v2; set => v2 = value; }
        internal bool containV(Vertex v) => 
            v1 == v || v2 == v;
        internal int xFromY(int y)
        {
            double part = (V1.Y - y) / (double)(V1.Y - V2.Y);
            return (int)(V1.X + (part*(V2.X - V1.X)));
        }
    }
}
