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
        Bitmap bitmap;
        ProgramState s = new ProgramState();

        public MainWindow()
        {
            InitializeComponent();
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            s.setDefaultTriangles();
        }



        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            bitmap = (Bitmap) pictureBox1.Image;
            Graphics.FromImage(bitmap).Clear(pictureBox1.BackColor);
            drawTriangle(e, s.Triangle1);
            drawTriangle(e, s.Triangle2);

        }

        private void drawTriangle(PaintEventArgs e, Triangle t)
        {
            for (int i = 0; i < t.Vertices.Length; i++)
            {
                drawVertex(e, t.Vertices[i]);
                drawLine(e, t.Vertices[i], t.Vertices[(i + 1) % 3]);
            }
            fillTriangle(t.Vertices);
        }

        private void fillTriangle(Vertex[] vertices)
        {
            List<(int height, int ind)> sortVert = new List<(int height, int ind)>(vertices.Length);
            for (int i = 0; i < vertices.Length; i++)
                sortVert.Add((vertices[i].Y, i));
            sortVert.Sort((a, b) => a.height - b.height);
            List <Edge> edges = new List<Edge>();
            List<int> cuts;
           // int j = sortVert[0].height;
            bool[] vertUsed = new bool[vertices.Length];
            for (int i = 0; i < sortVert.Count - 1; i++)
            {
                addNewVertexToEdges(vertices, sortVert, edges, vertUsed, i);
                for (int j = sortVert[i].height; j < sortVert[i + 1].height; j++)
                {
                    cuts = new List<int>();
                    foreach (Edge e in edges)
                        cuts.Add(e.xFromY(j));
                    cuts.Sort();
                    for (int k = 0; k < cuts.Count; k += 2)
                        drawLine(j, cuts[k], cuts[k + 1]);
                }
            }
            return;
        }

        private static void addNewVertexToEdges(Vertex[] vertices, List<(int height, int ind)> sortVert, List<Edge> edges, bool[] vertUsed, int i)
        {
            int vInd = sortVert[i].ind;
            int vIndNext = (vInd + vertices.Length - 1) % vertices.Length;
            int vIndLast = (vInd + 1) % vertices.Length;
            vertUsed[vInd] = true;
            edges.RemoveAll((e) => e.containV(vertices[vInd]));
            if (!vertUsed[vIndLast])
                edges.Add(new Edge(vertices[vIndLast], vertices[vInd]));
            if (!vertUsed[vIndNext])
                edges.Add(new Edge(vertices[vInd], vertices[vIndNext]));
        }

        private void drawLine(int y, int x1, int x2)
        {
            if (y > 0 && y < pictureBox1.Height)
            {
                if (x1 < 0)
                    x1 = 0;
                if (x2 >= pictureBox1.Width)
                    x2 = pictureBox1.Width - 1;
                for (int i = x1; i <= x2; i++)
                    bitmap.SetPixel(i, y, Color.Red);
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
