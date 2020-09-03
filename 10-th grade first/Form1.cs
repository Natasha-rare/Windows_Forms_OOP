using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_th_grade_first
{
    public partial class Form1 : Form
    {
        bool Painted = false;
        Point[] points = { new Point(), new Point(), new Point() };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (Painted)
            {
                if (points[0].Y > 0)
                    points[0].Y -= 8;
                else Painted = false;

                points[1].X -= 5;
                points[1].Y += 5;

                points[2].Y += 5;
                points[2].X += 5;
            }

            e.Graphics.FillPolygon(new SolidBrush(Color.BlueViolet), points);
        }

        private void DRAW_Click(object sender, EventArgs e)
            {
                if (!Painted)
                {
                    points[0] = new Point(ClientRectangle.Width / 2, ClientRectangle.Height / 2 - 35);
                    points[1] = new Point(ClientRectangle.Width / 2 - 35, ClientRectangle.Height / 2);
                    points[2] = new Point(ClientRectangle.Width / 2 + 35, ClientRectangle.Height / 2);
                }

                Painted = true;
            this.Invalidate();
        }

    }
}
