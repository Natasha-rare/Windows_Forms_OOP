using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практика_17
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }


        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Do_Click(object sender, EventArgs e)
        {
            if (ToTen.Checked)
            {
                Result.Text = Convert.ToString(Convertion.Convert_To_Ten(Convert.ToInt32(Binary.Text)));
            }
            else if (ToEight.Checked)
            {
                Result.Text = Convert.ToString(Convertion.Convert_To_Eight(Convert.ToInt32(Binary.Text)));
            }
            else if (ToSixteen.Checked)
            {
                Result.Text = Convert.ToString(Convertion.Convert_To_Sixteen(Convert.ToInt32(Binary.Text)));
            }
        }
    }
}
