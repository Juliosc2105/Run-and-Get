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
    public partial class frmFimDeJogo : Form
    {
        string login;
        int pontuacao;
        public frmFimDeJogo(string login, int pontuacao)
        {
            this.login = login;
            this.pontuacao = pontuacao;


            InitializeComponent();
            lblPontuacao.Text = this.pontuacao.ToString();
        }

        private void btnJogarNov_Click(object sender, EventArgs e)
        {
            frmJogo Jogo = new frmJogo(login);
            Visible = false;
            Jogo.ShowDialog();
            Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
