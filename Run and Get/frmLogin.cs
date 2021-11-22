using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace Run_and_Get
{
    public partial class frmLogin : Form
    {

        MySqlConnection conexao = new MySqlConnection(
            "Persist Security Info = False;" + //não pedir usuário e senha para conectar
            "server = localhost;" + //Local onde está o banco de dados
            "database =run_and_get;" + //nome do banco de dados
            "uid=root;" + //usuario do banco de dados
            "pwd="
            );

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnRegistrarSe_Click(object sender, EventArgs e)
        {
            frmRegistro registro = new frmRegistro();
            Visible = false;
            registro.ShowDialog();
            txtLogin.Text = null;
            txtSenha.Text = null;
            txtLogin.Focus();
            Visible = true;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            var senhaCorreta = "";

            if (txtLogin.Text != "" && txtSenha.Text != "")
            {
                string login = txtLogin.Text;
                try
                {
                    conexao.Open();
                    if (conexao.State == ConnectionState.Open)
                    {
                        MySqlCommand comandoSQL = conexao.CreateCommand();
                        comandoSQL.CommandText = "SELECT login, senha FROM login WHERE login ='"+txtLogin.Text+"'";
                        comandoSQL.Connection = conexao;

                        MySqlDataReader dados = comandoSQL.ExecuteReader();
                        dados.Read();
                        senhaCorreta = dados["senha"].ToString();
                    }
                    conexao.Close();
                    conexao.Dispose();
                }
                catch (Exception)
                {
                    conexao.Close();
                    conexao.Dispose();
                    MessageBox.Show
                        ("Login incorreto",
                        "Informação",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                }

                if (senhaCorreta == txtSenha.Text)
                {
                    MessageBox.Show("AEEEEE MALANDRO, ACERTOU!",
                        "Informação",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    frmJogo jogo = new frmJogo(txtLogin.Text);
                    Visible = false;
                    jogo.ShowDialog();
                    Visible = true;
                }
                else
                {
                    MessageBox.Show("ERROU, ERROU FEIO, ERROU RUDE \n" +
                        "Sua senha é: " + senhaCorreta,
                        "Informação",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
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
