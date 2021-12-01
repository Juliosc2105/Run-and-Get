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

        //iniciando o inimigo1
        private PictureBox inimigo1 = new PictureBox();
        private PictureBox inimigo2 = new PictureBox();
        
        //iniciando o ponto
        private PictureBox ponto = new PictureBox();

        //posição do jogador
        int xJogador;
        int yJogador;

        //posição dos inimigos
        int xInimigo1, xInimigo2;
        int yInimigo1, yInimigo2;
        //velocidade dos inimigos
        float velocidadeInimigo1, velocidadeInimigo2;

        //posição do ponto
        int xPonto;
        int yPonto;

        //marcadores
        int vidas = 3;
        int pontos = 0;
        int energia;
        bool perdeu = false;

        public frmJogo(string login)
        {
            InitializeComponent();

            this.login = login;
        }

        private void timer1_Tick(object sender, EventArgs e) //timer
        {
            MoverPersonagem(direcao);
            IAinimigo1(ciclos);
            if (pontos >= 1000)
            {
                IAinimigo2(ciclos);
            }
            Colisoes();

            lblVidas.Text = vidas.ToString();
            lblPontos.Text = pontos.ToString();
            lblEnergia.Text = energia.ToString();

            if (ciclos%2==0 && energia > 0)
            {
                energia--;
                pgbEnergia.Value = energia;
            }
            ciclos++;
            if(ciclos >= 100)
            {
                ciclos = 0;
            }

            if (timer1.Interval >= 25)
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

            energia = aleatorio.Next(100, 200);

            //propriedades do inimigo1
            inimigo1.Size = new Size(10, 10);
            inimigo1.Location = new Point(200, 200);
            inimigo1.BackColor = Color.Red;
            this.Controls.Add(inimigo1);

            //propriedades do inimigo2
            inimigo2.Size = new Size(10, 10);
            inimigo2.Location = new Point(400, 400);
            inimigo2.BackColor = Color.Red;
            this.Controls.Add(inimigo2);
            inimigo2.Enabled = false;
            inimigo2.Visible = false;

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
            if (ciclos%2 == 0)
            {
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

        }

        public void IAinimigo1(int ciclos)
        {
            if ((Math.Sqrt((Math.Pow((Math.Abs(xInimigo1-xJogador)), 2))+(Math.Pow((Math.Abs(yInimigo1-yJogador)), 2)))) >= 150)
                //sqrt((x0-x1)^2 + (y0 - y1)^2)
            {
                velocidadeInimigo1 = 1;
            }
            else
            {
                velocidadeInimigo1 = 3;
            }
            if (ciclos%velocidadeInimigo1 == 0)
            {
                xInimigo1 = inimigo1.Location.X;
                yInimigo1 = inimigo1.Location.Y;
                if (Math.Abs(xInimigo1-xJogador) > Math.Abs(yInimigo1-yJogador))
                {
                    if ((xInimigo1 - xJogador) > 0)
                    {
                        inimigo1.Location = new Point(xInimigo1 - 10, yInimigo1);
                    }
                    else
                    {
                        inimigo1.Location = new Point(xInimigo1 + 10, yInimigo1);
                    }
                }
                else
                {
                    if ((yInimigo1 - yJogador) > 0)
                    {
                        inimigo1.Location = new Point(xInimigo1, yInimigo1 - 10);
                    }
                    else
                    {
                        inimigo1.Location = new Point(xInimigo1, yInimigo1 + 10);
                    }
                }
            }
        }

        public void IAinimigo2(int ciclos)
        {
            if ((Math.Sqrt((Math.Pow((Math.Abs(xInimigo2 - xJogador)), 2)) + (Math.Pow((Math.Abs(yInimigo2 - yJogador)), 2)))) >= 150)
            //sqrt((x0-x1)^2 + (y0 - y1)^2)
            {
                velocidadeInimigo2 = 2;
            }
            else
            {
                velocidadeInimigo2 = 4;
            }
            if (ciclos % velocidadeInimigo2 == 0)
            {
                xInimigo2 = inimigo2.Location.X;
                yInimigo2 = inimigo2.Location.Y;
                if (Math.Abs(xInimigo2 - xJogador) > Math.Abs(yInimigo2 - yJogador))
                {
                    if ((xInimigo2 - xJogador) > 0)
                    {
                        inimigo2.Location = new Point(xInimigo2 - 10, yInimigo2);
                    }
                    else
                    {
                        inimigo2.Location = new Point(xInimigo2 + 10, yInimigo2);
                    }
                }
                else
                {
                    if ((yInimigo2 - yJogador) > 0)
                    {
                        inimigo2.Location = new Point(xInimigo2, yInimigo2 - 10);
                    }
                    else
                    {
                        inimigo2.Location = new Point(xInimigo2, yInimigo2 + 10);
                    }
                }
            }
        }


        public void Colisoes()
        {
            var aleatorio = new Random();

            if (((xInimigo1 == xJogador && yInimigo1 == yJogador) || (energia <= 0) || (xInimigo2 == xJogador && yInimigo2 == yJogador)) && vidas > 1)
            {
                energia = aleatorio.Next(100, 200);
                vidas--;
            }
            else if (((xInimigo1 == xJogador && yInimigo1 == yJogador) || (energia <= 0) && (vidas == 1) || (xInimigo2 == xJogador && yInimigo2 == yJogador)) 
                && (perdeu == false))
            {
                perdeu = true;
                vidas--;
                MessageBox.Show("Você perdeu!");
                frmFimDeJogo Fim = new frmFimDeJogo(login, pontos);
                Visible = false;
                Fim.ShowDialog();
                Close();
            }


            if (xPonto == xJogador && yPonto == yJogador)
            {
                ponto.Location = new Point((aleatorio.Next(1, 88)) * 10, (aleatorio.Next(11, 58)) * 10);
                pontos += aleatorio.Next(50, 90);
                energia = aleatorio.Next(100, 200);
                xPonto = ponto.Location.X;
                yPonto = ponto.Location.Y;
                if (pontos >= 1000)
                {
                    inimigo2.Enabled = true;
                    inimigo2.Visible = true;
                }
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
