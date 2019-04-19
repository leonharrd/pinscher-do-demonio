using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Retangulo
{
    public partial class title : Form
    {
        public title()
        {
            InitializeComponent();
        }

        private void bttnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bttnLimpar_Click(object sender, EventArgs e)
        {
            txtComp.Text = "";
            txtLarg.Text = "";
            txtArea.Text = "";
            txtPerimetro.Text = "";
        }

        private void bttnCalcular_Click(object sender, EventArgs e)
        {
            double area, perimetro;

            area = double.Parse(txtComp.Text) * double.Parse(txtLarg.Text);
            perimetro = 2 * double.Parse(txtComp.Text) + 2 * double.Parse(txtLarg.Text);
            txtArea.Text = Convert.ToString(area);
            txtPerimetro.Text = Convert.ToString(perimetro);
        }
    }
}
