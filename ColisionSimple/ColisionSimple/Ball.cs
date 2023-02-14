using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColisionSimple
{
    internal class Ball
    {

        public int x;
        public int y;
        public int velx;
        public int vely;
        public Point speed;
        public Color color;



        public Ball()
        {
            Random rdan = new Random();

            this.x = rdan.Next(3, 300);
            this.y = rdan.Next(3, 300);
            this.velx = rdan.Next(3, 10);
            this.vely = rdan.Next(3, 10);
            this.color = Color.Black;

        }

        public void Update()
        {
            x += velx;
            y += vely;
        }
    }
}
