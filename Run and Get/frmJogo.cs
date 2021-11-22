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
    public partial class frmJogo : Form
    {

        //login
        string login;

        //contagem de cilos do clock
        int ciclos = 0;

        //auxilidor para direção em que o personagem está se movendo
        int direcao;

        //iniciando o inimigo
        private PictureBox inimigo = new PictureBox();
        
        //iniciando o ponto
        private PictureBox ponto = new PictureBox();

        //posição do jogador
        int xJogador;
        int yJogador;

        //posição do inimigo
        int xInimigo;
        int yInimigo;

        //posição do ponto
        int xPonto;
        int yPonto;

        //marcadores
        int vidas = 3;
        int pontos = 0;
        int energia;

        public frmJogo(string login)
        {
            InitializeComponent();

            this.login = login;
        }

        private void timer1_Tick(object sender, EventArgs e) //timer
        {
            MoverPersonagem(direcao);
            IAinimigo(ciclos);
            Colisoes();

            lblVidas.Text = vidas.ToString();
            lblPontos.Text = pontos.ToString();
            lblEnergia.Text = energia.ToString();

            energia--;
            ciclos++;
            if(ciclos >= 100)
            {
                ciclos = 0;
            }

            if (timer1.Interval >= 50)
            {
                timer1.Interval -= 1;
                lblTicks.Text = timer1.Interval.ToString();
            }
        }

        private void frmJogo_KeyDown(object sender, KeyEventArgs e) //coletar imput do usuário
        {
            int d = e.KeyValue;
            if ((d >= 37 && d <= 40) || ( d == 65 || d == 87 || d == 68 || d == 83))
            {
                this.direcao = d;
            }
        } 

        private void frmJogo_Load(object sender, EventArgs e) //Predefinições do jogo
        {
            Adm();
            var aleatorio = new Random();

            energia = aleatorio.Next(300, 600);

            //propriedades do inimigo
            inimigo.Size = new Size(10, 10);
            inimigo.Location = new Point(200, 200);
            inimigo.BackColor = Color.Red;
            this.Controls.Add(inimigo);

            //propriedades do ponto
            ponto.Size = new Size(10, 10);
            ponto.Location = new Point((aleatorio.Next(1,88))*10, (aleatorio.Next(11,58))*10);
            ponto.BackColor = Color.Green;
            this.Controls.Add(ponto);

            xPonto = ponto.Location.X;
            yPonto = ponto.Location.Y;
        }

        public void MoverPersonagem(int direcao)
        {
            xJogador = pbxJogador.Location.X;
            lblX.Text = xJogador.ToString();
            yJogador = pbxJogador.Location.Y;
            lblY.Text = yJogador.ToString();

            if (direcao == 65 || direcao == 37 && xJogador >= 20)
            {
                pbxJogador.Location = new Point(xJogador - 10, yJogador);
            }

            if (direcao == 68 || direcao == 39 && xJogador <= 870)
            {
                pbxJogador.Location = new Point(xJogador + 10, yJogador);
            }

            if (direcao == 87 || direcao == 38 && yJogador >= 120)
            {
                pbxJogador.Location = new Point(xJogador, yJogador - 10);
            }

            if (direcao == 83 || direcao == 40 && yJogador <= 570)
            {
                pbxJogador.Location = new Point(xJogador, yJogador + 10);
            }
        }

        public void IAinimigo(int dificuldade)
        {
            if (dificuldade%2 == 0)
            {
                xInimigo = inimigo.Location.X;
                yInimigo = inimigo.Location.Y;
                if (Math.Abs(xInimigo-xJogador) > Math.Abs(yInimigo-yJogador))
                {
                    if ((xInimigo - xJogador) > 0)
                    {
                        inimigo.Location = new Point(xInimigo - 10, yInimigo);
                    }
                    else
                    {
                        inimigo.Location = new Point(xInimigo + 10, yInimigo);
                    }
                }
                else
                {
                    if ((yInimigo - yJogador) > 0)
                    {
                        inimigo.Location = new Point(xInimigo, yInimigo - 10);
                    }
                    else
                    {
                        inimigo.Location = new Point(xInimigo, yInimigo + 10);
                    }
                }
            }
        }

        public void Colisoes()
        {
            var aleatorio = new Random();

            if (((xInimigo == xJogador && yInimigo == yJogador) || (energia < 0)) && vidas > 1)
            {
                energia = aleatorio.Next(300, 600);
                vidas--;
            }
            else if (xInimigo == xJogador && yInimigo == yJogador && vidas == 1)
            {
                vidas--;
                MessageBox.Show("Você perdeu!");
                /////////////////////////////////////////NOVA TELA///////////////////////////
            }


            if (xPonto == xJogador && yPonto == yJogador)
            {
                ponto.Location = new Point((aleatorio.Next(1, 88)) * 10, (aleatorio.Next(11, 58)) * 10);
                pontos += aleatorio.Next(50, 90);
                energia = aleatorio.Next(300, 600);
                xPonto = ponto.Location.X;
                yPonto = ponto.Location.Y;
            }
        }

        public void Adm()
        {
            if (login == "123")
            {
                lblDistX.Visible = true;
                lblDistY.Visible = true;
                lblX.Visible = true;
                lblY.Visible = true;
                lblTicks.Visible = true;
                lblValorTicks.Visible = true;
            }
        }
    }

}
