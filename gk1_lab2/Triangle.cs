using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gk1_lab2
{
    class Triangle
    {
        Vertex[] vertices = new Vertex[3];

        public Triangle(Vertex v1, Vertex v2, Vertex v3)
        {
            Vertices[0] = v1;
            Vertices[1] = v2;
            Vertices[2] = v3;
        }

        internal Vertex[] Vertices { get => vertices; set => vertices = value; }
    }
}
