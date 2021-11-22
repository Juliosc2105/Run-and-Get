using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

using MySql.Data.MySqlClient;

namespace Run_and_Get
{
    public partial class frmRegistro : Form
    {

        MySqlConnection conexao = new MySqlConnection(
            "Persist Security Info = False;" + //não pedir usuário e senha para conectar
            "server = localhost;" + //Local onde está o banco de dados
            "database =run_and_get;" + //nome do banco de dados
            "uid=root;" + //usuario do banco de dados
            "pwd="
            );

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
                        try
                        {
                            conexao.Open();
                            if (conexao.State == ConnectionState.Open)
                            {
                                MySqlCommand comandoSQL = conexao.CreateCommand();

                                comandoSQL.CommandText = "INSERT INTO login" +
                                    "(login, nome, senha, email, dia, mes, ano)" +
                                    "VALUES" +
                                    "('" + txtLogin.Text + "','" + txtNome.Text + "','" + txtSenha.Text + "','" + 
                                    txtEmail.Text + "','" + cbxDia.Text + "','" + cbxMes.Text + "','" + cbxAno.Text + "')";
                                comandoSQL.Connection = conexao;
                                comandoSQL.ExecuteNonQuery();
                                conexao.Close();
                                Close();
                            }
                        }
                        catch (Exception Erro)
                        {

                            MessageBox.Show
                                ("Houve um erro na inserção do novo registro no banco de dados: \n\n" + Erro.ToString(),
                                "Informação de Erro!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                                );
                        }
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
