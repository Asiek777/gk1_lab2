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

        public Triangle(Vertex[] vertices)
        {
            Vertices = vertices;
        }

        internal Vertex[] Vertices { get => vertices; set => vertices = value; }
    }
}
