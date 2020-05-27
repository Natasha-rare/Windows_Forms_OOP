using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Фоновая_6
{
    public partial class Form1 : Form
    {
        int x, y;

        public Form1()
        {
            InitializeComponent();
            y = button2.Top;
            x = button2.Left;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button2.Right >= this.ClientSize.Width || button2.Bottom >= this.ClientSize.Height)
            {
                button2.Location = new Point(x, y);
            }
            button2.Left += Math.Min(4, this.ClientSize.Width - button2.Right);
            button2.Top += Math.Min(2, this.ClientSize.Height - button2.Top);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button2.Bottom >= this.ClientSize.Height)
            {
                button2.Location = new Point(x, y);
            }
            button2.Top += Math.Min(6, this.ClientSize.Height - button2.Top);
            
        }
    }
}
