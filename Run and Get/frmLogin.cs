using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Run_and_Get
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnRegistrarSe_Click(object sender, EventArgs e)
        {
            frmRegistro registro = new frmRegistro();
            Visible = false;
            registro.ShowDialog();
            Visible = true;
        }
    }
}
