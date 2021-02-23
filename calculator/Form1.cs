using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            double final_result = Convert.ToDouble(Input1.Text) + Convert.ToDouble(Input2.Text);

            Result.Text = final_result.ToString();
        }

        private void subbutton_Click(object sender, EventArgs e)
        {
            double final_result = Convert.ToDouble(Input1.Text) - Convert.ToDouble(Input2.Text);

            Result.Text = final_result.ToString();
        }

        private void dividebutton_Click(object sender, EventArgs e)
        {
            double final_result = Convert.ToDouble(Input1.Text) / Convert.ToDouble(Input2.Text);

            Result.Text = final_result.ToString();
        }

        private void multiolicationbutton_Click(object sender, EventArgs e)
        {
            double final_result = Convert.ToDouble(Input1.Text) * Convert.ToDouble(Input2.Text);

            Result.Text = final_result.ToString();
        }

        private void resetbutton_Click(object sender, EventArgs e)
        {
            Input1.Clear();
            Input2.Clear();
            Result.Clear();

        }
    }
}
