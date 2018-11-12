using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gk1_lab2
{
    class Lamp
    {
        vec3 loc;
        vec3 color;

        public Lamp(Color color, vec3 location)
        {
            Color = new vec3(color);
            Location = location;
            IsConst = false;
        }

        public vec3 Color { get => color; set => color = value; }
        public bool IsConst { get; set; }
        internal vec3 Location { get => loc; set => loc = value; }
        internal vec3 normalizedVectorFrom(double x, double y)
        {
            if (IsConst)
                return new vec3(0, 0, 1);
            else
                return new vec3(loc.x - x, loc.y - y, loc.z, true);
        }

    }
}
