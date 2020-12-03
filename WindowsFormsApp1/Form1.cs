using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a;
            double L;
            double s = Math.Sqrt(3);
            double S;
            if (!String.IsNullOrEmpty(textBox1.Text))
            {
                a = int.Parse(textBox1.Text);
                a = a / 3;
                textBox1.Clear();
                L = (a * s) / 2;
                S = 0.5 * (a * L);
                label2.Text = $"Площа: {(float)S} см^2";
            }
        }
    }
}
