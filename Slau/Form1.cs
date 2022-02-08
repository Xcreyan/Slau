using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slau
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            double x1_1 = Convert.ToDouble(textBox1.Text);
            double x1_2 = Convert.ToDouble(textBox2.Text);
            double x1_3 = Convert.ToDouble(textBox3.Text);
            double x1_0 = Convert.ToDouble(textBox4.Text);
            double x2_1 = Convert.ToDouble(textBox5.Text);
            double x2_2 = Convert.ToDouble(textBox6.Text);
            double x2_3 = Convert.ToDouble(textBox7.Text);
            double x2_0 = Convert.ToDouble(textBox8.Text);
            double x3_1 = Convert.ToDouble(textBox9.Text);
            double x3_2 = Convert.ToDouble(textBox10.Text);
            double x3_3 = Convert.ToDouble(textBox11.Text);
            double x3_0 = Convert.ToDouble(textBox12.Text);
            double u1_1 = Math.Sqrt(x1_1);
            double u1_2 = x1_2 / u1_1;
            double u1_3 = x1_3 / u1_1;
            double u2_2 = Math.Sqrt(x2_2-Math.Pow(u1_2,2));
            double u2_3 = (x2_3-u1_2*u1_3)/u2_2;
            double u3_3 = Math.Sqrt(x3_3-Math.Pow(u1_3,2)-Math.Pow(u2_3,2));
            double _u1_1 = u1_1;
            double _u2_1 = u1_2;
            double _u3_1 = u1_3;
            double _u2_2 = u2_2;
            double _u3_2 = u2_3;
            double _u3_3 = u3_3;
            double x1 = _u1_1 * x1_0;
            double x2 = _u2_1 * x2_0 + _u2_2 * x2_0;
            double x3 = _u3_1 * x3_0 + _u3_2 * x3_0 + _u3_3 * x3_0;
            double u1 = u1_1 * x1 + u1_2 * x1 + u1_3 * x1;
            double u2 = u2_2 * x2 + u2_3 * x2;
            double u3 = u3_3 * x3;
            listBox1.Items.Add($"x1={x1}");
            listBox1.Items.Add($"x2={x2}");
            listBox1.Items.Add($"x3={x3}");
        }
    }
}
