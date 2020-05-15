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
            button2.Left += 4;
            button2.Top += 2;
            if (button2.Right >= this.ClientSize.Width || button2.Bottom >= this.ClientSize.Height)
            {
                button2.Location = new Point(x, y);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button2.Top += 6;
            if (button2.Bottom >= this.ClientSize.Height)
            {
                button2.Location = new Point(x, y);
            }
        }
    }
}
