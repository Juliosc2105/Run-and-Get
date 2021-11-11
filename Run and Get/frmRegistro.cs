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
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void btnSenha_Click(object sender, EventArgs e)
        {
            if (btnSenha.Text == "Mostrar")
            {
                txtSenha.UseSystemPasswordChar = false;
                btnSenha.Text = "Ocultar";
            }
            else
            {
                txtSenha.UseSystemPasswordChar = true;
                btnSenha.Text = "Mostrar";
            }

        }

        private void btnConfSenha_Click(object sender, EventArgs e)
        {
            if (btnConfSenha.Text == "Mostrar")
            {
                txtConfSenha.UseSystemPasswordChar = false;
                btnConfSenha.Text = "Ocultar";
            }
            else
            {
                txtConfSenha.UseSystemPasswordChar = true;
                btnConfSenha.Text = "Mostrar";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRegistar_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text != "" && txtSenha.Text != "" && txtConfSenha.Text != "")
            {
                if (txtSenha.Text == txtConfSenha.Text)
                {
                    if (rbtTermos.Checked)
                    {
                        //BDD
                    }
                    else
                    {
                        MessageBox.Show("Concorde com os termos",
                        "Informação",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("As senhas não são iguais",
                        "Informação",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos",
                "Informação",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }
    }
}
