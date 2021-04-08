using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace KlasaKap
{
    class Kap
    {
        private Point o;
        private Color boja;
        private SolidBrush cetka;
        private int a;

        public Kap( Point o, SolidBrush cetka , int a)
        {
            this.o = o;
            this.cetka = cetka;
            this.a = a;
        }

        public void Crtaj(Graphics g)
        {
            Point[] trougao = { new Point(o.X - a, o.Y), new Point(o.X + a, o.Y), new Point(o.X, o.Y - 2 * a) };
            g.FillPolygon(cetka, trougao);
            Rectangle rectangle = new Rectangle(o.X - a, o.Y - a, 2 * a, 2 * a);
            g.FillPie(cetka, rectangle, 0, 180);
        }

        public void Pomeri(int dx, int dy)
        {
            o.X += dx;
            o.Y += dy;
        }

    }
}
