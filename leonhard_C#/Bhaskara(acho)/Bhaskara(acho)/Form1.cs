using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bhaskara_acho_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double raizneg, raizpos, delta;

            delta = Math.Pow(double.Parse(inputB.Text), 2) + (4 * double.Parse(inputA.Text) * double.Parse(inputC.Text));
            lblDelta.Text = delta.ToString();

            raizpos = (-1 * double.Parse(inputB.Text)) + Math.Sqrt(delta);
            raizneg = (-1 * double.Parse(inputB.Text)) - Math.Sqrt(delta);


        }
    }
}
