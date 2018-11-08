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
        }

        public vec3 Color { get => color; set => color = value; }
        internal vec3 Location { get => loc; set => loc = value; }
        internal vec3 normalizedVectorFrom(double x, double y) => 
            new vec3(loc.x - x, loc.y - y, loc.z, true);

    }
}
