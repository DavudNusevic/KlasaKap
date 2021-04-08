using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlasaKap
{
    public partial class Form1 : Form
    {
        private int a;
        private Point o;
        private SolidBrush cetka;
        private Kap kap;
        private int dy;
        private Rectangle r1, r2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
            a = 5;
            dy = 5;
            o.X = ClientRectangle.Width / 2;
            o.Y = 2 * a;
            cetka = new SolidBrush(Color.Aqua);
            kap = new Kap(o, cetka, a);
            r1 = new Rectangle(ClientRectangle.Width / 2 -  (int)(3.5 * a), ClientRectangle.Height - 10 * a, 7 * a, 10 * a);
            r2 = new Rectangle(ClientRectangle.Width / 2 - (int) (1.5*a), ClientRectangle.Height - 12 * a, 3 * a, 2 * a);
            timer1.Start();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            kap.Crtaj(e.Graphics);
            e.Graphics.FillRectangle(new SolidBrush(Color.Brown), r1);
            e.Graphics.FillRectangle(new SolidBrush(Color.Brown), r2);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            kap.Pomeri(0, dy);
            Refresh();
        }
    }
}
