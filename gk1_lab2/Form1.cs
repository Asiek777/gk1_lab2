using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gk1_lab2
{
    public partial class MainWindow : Form
    {
        const int pointSize = 5;
        ProgramState s = new ProgramState();

        public MainWindow()
        {
            InitializeComponent();
            s.setDefaultTriangles();
        }



        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            drawTriangle(e, s.Triangle1);
            drawTriangle(e, s.Triangle2);
            
        }

        private static void drawTriangle(PaintEventArgs e, Triangle t)
        {
            for (int i = 0; i < t.Vertices.Length; i++)
            {
                drawVertex(e, t.Vertices[i]);
                drawLine(e, t.Vertices[i], t.Vertices[(i + 1) % 3]);
            }

        }

        private static void drawLine(PaintEventArgs e,  Vertex v1, Vertex v2)
        {
            e.Graphics.DrawLine(new Pen(Color.Black, 1), v1.X,
                 v1.Y, v2.X, v2.Y);
        }

        private static void drawVertex(PaintEventArgs e, Vertex v)
        {
            Rectangle circle = new Rectangle(v.X - pointSize,
                                v.Y - pointSize, 2 * pointSize, 2 * pointSize);
            e.Graphics.FillEllipse(Brushes.Black, circle);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Vertex v = (s.getVertices().OrderBy(vert => vert.calcDistance(e.X, e.Y)).First());
            if (v.calcDistance(e.X, e.Y) < 7)
            {
                s.MovedVertex = v;
                s.PosX = e.X;
                s.PosY = e.Y;
                pictureBox1.MouseMove += moveVertex;
            }
        }

        private void moveVertex(object sender, MouseEventArgs e)
        {
            Vertex v = s.MovedVertex;
            v.X += e.X - s.PosX;
            v.Y += e.Y - s.PosY;
            pictureBox1.Refresh();
            s.PosX = e.X;
            s.PosY = e.Y;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox1.MouseMove -= moveVertex;
        }
    }
}
