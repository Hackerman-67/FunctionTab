using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGR1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int M = Convert.ToInt32(textBox1.Text);
            double x_left = Convert.ToDouble(textBox2.Text);
            double x_right = Convert.ToDouble(textBox3.Text);
            double A = Convert.ToDouble(textBox4.Text);
            double step = (x_right - x_left) / (M - 1);
            double this_x = x_left;
            double y = 0;
            int counter = 0;
            for (int i = 0; i < M; i++)
            {
                if (A != 0 && counter < 10)
                {
                    if (this_x < 0) y = (8 * A * A * A) / (Math.Pow(this_x, 2) + 4 * A * A);
                    if (this_x > 0) y = A * (Math.Exp(this_x / A) + Math.Exp(-this_x / A));
                    label8.Text += Convert.ToString(this_x);
                    label8.Text += "\n";
                    label1.Text += Convert.ToString(Math.Round(y,1));
                    label1.Text += "\n";
                    this_x += step;
                    this_x = Math.Round(this_x, 2);
                    counter += 1;
                }
                else if (A != 0)
                {
                    label12.Text = "x";
                    label10.Text = "y";
                    label9.BorderStyle = BorderStyle.FixedSingle;
                    label10.BorderStyle = BorderStyle.FixedSingle;
                    label11.BorderStyle = BorderStyle.FixedSingle;
                    label12.BorderStyle = BorderStyle.FixedSingle;
                    if (this_x < 0) y = (8 * A * A * A) / (Math.Pow(this_x, 2) + 4 * A * A);
                    if (this_x > 0) y = A * (Math.Exp(this_x / A) + Math.Exp(-this_x / A));
                    label11.Text += Convert.ToString(this_x);
                    label11.Text += "\n";
                    label9.Text += Convert.ToString(Math.Round(y, 1));
                    label9.Text += "\n";
                    this_x += step;
                    this_x = Math.Round(this_x, 2);
                    counter += 1;
                }
                if (A == 0 && counter < 10)
                {
                    label8.Text += Convert.ToString(this_x);
                    label8.Text += "\n";
                    label1.Text += "-";
                    label1.Text += "\n";
                    this_x += step;
                    this_x = Math.Round(this_x, 2);
                    counter += 1;
                }
                if (A == 0 && counter >= 10 && counter < 20)
                {
                    label12.Text = "x";
                    label10.Text = "y";
                    label9.BorderStyle = BorderStyle.FixedSingle;
                    label10.BorderStyle = BorderStyle.FixedSingle;
                    label11.BorderStyle = BorderStyle.FixedSingle;
                    label12.BorderStyle = BorderStyle.FixedSingle;
                    label11.Text += Convert.ToString(this_x);
                    label11.Text += "\n";
                    label9.Text += "-";
                    label9.Text += "\n";
                    this_x += step;
                    this_x = Math.Round(this_x, 2);
                    counter += 1;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label9.Text = "";
            label10.Text = "";
            label11.Text = "";
            label12.Text = "";
            label8.Text = "";
            label1.Text = "";
            label9.BorderStyle = BorderStyle.None;
            label10.BorderStyle = BorderStyle.None;
            label11.BorderStyle = BorderStyle.None;
            label12.BorderStyle = BorderStyle.None;
        }

    }
}
