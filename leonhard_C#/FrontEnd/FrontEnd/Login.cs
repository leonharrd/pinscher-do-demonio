using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEnd
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            Principal mainmenu = new Principal();
            Hide();
            mainmenu.ShowDialog();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
