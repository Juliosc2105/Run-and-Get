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
    public partial class frmCapa : Form
    {
        public frmCapa()
        {
            InitializeComponent();
        }
        int aux = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            aux++;
            if (Opacity > 0 && aux > 100)
            {
                Opacity -= 0.02;
            }
            else if (aux > 100)
            {
                Close();
            }
        }
    }
}
