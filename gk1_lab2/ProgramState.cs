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
        Lamp lamp = new Lamp(Color.White, new vec3(500, 400, 100));
        private vec3 textureColor;
        Bitmap texture, bumpMap;


        public int PosX { get; set; }
        public int PosY { get; set; }
        public double Time { get; set; }
        internal Triangle Triangle2 { get; set; }
        internal Triangle Triangle1 { get; set; }
        internal Vertex MovedVertex { get; set; }
        internal Lamp Lamp { get => lamp; set => lamp = value; }

        public Bitmap BumpMap { get => bumpMap; set
            {
                bumpMap = value;
                parent.bumpMapPictureBox.Image = value;
                fillBumpMapPixels(value);
            } }

        public Bitmap Texture { get => texture; set
            {
                texture = value;
                parent.texturePictureBox.Image = value;
                fillTexturePixels(value);
            } }

        internal Color LightColor { get => parent.lightColorBox.BackColor; set 
                {
                Lamp.Color = value;
                parent.lightColorBox.BackColor = value;
            } }

        internal vec3 TextureColor { get => textureColor; set
            {
                textureColor = value;
                parent.constColorPictureBox.BackColor = Color.FromArgb(value.toARGB());
            } }

        internal vec3[,] TexturePixels { get; set; }
        internal vec3[,] BumpMapPixels { get; set; }
        internal bool IsLightConst { get => Lamp.IsConst; set => Lamp.IsConst = value; }

        internal IEnumerable<Vertex> getVertices() => 
            Triangle1.Vertices.Concat(Triangle2.Vertices);



        public ProgramState(MainWindow parent)
        {
            this.parent = parent;
            TextureColor = Color.White;
            TexturePixels = new vec3[parent.pictureBox1.Width, parent.pictureBox1.Height];
            BumpMapPixels = new vec3[parent.pictureBox1.Width, parent.pictureBox1.Height];
            setDefaultTriangles();
            BumpMap = new Bitmap("brick_normalmap.png");
            Texture = new Bitmap("texture.bmp");
        }
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
        void fillTexturePixels(Bitmap texture)
        {
            int width = TexturePixels.GetLength(0);
            int heigth = TexturePixels.GetLength(1);
            for (int i = 0; i < width; i++)
                for (int j = 0; j < heigth; j++)
                    TexturePixels[i, j] = texture.GetPixel(i % texture.Width, j % texture.Height);
        }
        void fillBumpMapPixels(Bitmap bumpMap)
        {
            int width = BumpMapPixels.GetLength(0);
            int heigth = BumpMapPixels.GetLength(1);
            for (int i = 0; i < width; i++)
                for (int j = 0; j < heigth; j++)
                {
                    BumpMapPixels[i, j] = bumpMap.GetPixel(i % bumpMap.Width, j % bumpMap.Height);
                    BumpMapPixels[i, j].convertToBumpMap();
                }
        }
    }
}
