using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _35_2_kim_lab_1
{
    public partial class Form1 : Form
    {
        private double[] _inputPixels = new double[15] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public Form1()
        {
            InitializeComponent();
        }



        private void Change_State(Button b, int index)
        {
            if (b.BackColor==Color.Black)
            {
                b.BackColor = Color.White;
                _inputPixels[index] = 0;
            }
            else
            if(b.BackColor==Color.White)
            {
                b.BackColor = Color.Black;
                _inputPixels[index] = 1;
            }
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Change_State(button1, 0);
            label1.Text = _inputPixels[0].ToString();
        }
    }
}
