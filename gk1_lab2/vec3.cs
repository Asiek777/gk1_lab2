using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gk1_lab2
{
    struct vec3
    {
        public double x, y, z;

        public vec3(double x, double y, double z, bool normalizeIt = false)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            if (normalizeIt)
                normalizeVector();
        }
        public vec3(Color color)
        {
            x = (double)color.R / 255;
            y = (double)color.G / 255;
            z = (double)color.B / 255;

        }
        double lenght() => 
            Math.Sqrt(x * x + y * y + z * z);
        void normalizeVector()
        {
            double len = lenght();
            x /= len;
            y /= len;
            z /= len;
        }
        public int toARGB()
        {
            if (x > 1 || y > 1 || z > 1)
                throw new InvalidOperationException("It's not a color Vector");
            return ((byte)(x * 255)) << 16 | ((byte)(y * 255)) << 8 
                | ((byte)(z * 255)) | 255 << 24;
        }
        public static double operator *(vec3 v1, vec3 v2) => 
            v1.x * v2.x + v1.y * v2.y + v1.z * v2.z;
        public static vec3 operator *(vec3 v, double a) =>
            new vec3(v.x * a, v.y * a, v.z * a);
        public static vec3 operator *(double a, vec3 v) =>
            new vec3(v.x * a, v.y * a, v.z * a);
    }
}
