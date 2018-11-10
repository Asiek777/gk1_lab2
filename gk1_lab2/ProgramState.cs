using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gk1_lab2
{
    class ProgramState
    {
        private MainWindow parent;
        private Triangle triangle1;
        private Triangle triangle2;
        int posX, posY;
        Vertex movedVertex;
        Lamp lamp = new Lamp(Color.White, new vec3(500, 400, 100));
        Bitmap bumpBitmap;

        public ProgramState(MainWindow parent)
        {
            this.parent = parent;
        }

        public int PosX { get => posX; set => posX = value; }
        public int PosY { get => posY; set => posY = value; }
        internal Triangle Triangle2 { get => triangle2; set => triangle2 = value; }
        internal Triangle Triangle1 { get => triangle1; set => triangle1 = value; }
        internal Vertex MovedVertex { get => movedVertex; set => movedVertex = value; }
        internal Lamp Lamp { get => lamp; set => lamp = value; }
        public Bitmap BumpBitmap { get => bumpBitmap; set => bumpBitmap = value; }
        internal Color LightColor { get => parent.lightColorBox.BackColor; set 
                {
                Lamp.Color = value;
                parent.lightColorBox.BackColor = value;
            } }

        internal void setDefaultTriangles()
        {
            Triangle1 = new Triangle(
                 new Vertex(100, 100),
                 new Vertex(100, 200),
                 new Vertex(200, 100)
            );
            Triangle2 = new Triangle(
                 new Vertex(400, 100),
                 new Vertex(400, 400),
                 new Vertex(300, 200)
            );
        }
        internal IEnumerable<Vertex> getVertices() => 
            Triangle1.Vertices.Concat(Triangle2.Vertices);
    }
}
