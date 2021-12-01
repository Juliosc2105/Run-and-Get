
namespace Run_and_Get
{
    partial class frmJogo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnTeste = new System.Windows.Forms.Panel();
            this.lblTituVidas = new System.Windows.Forms.Label();
            this.lblEnergia = new System.Windows.Forms.Label();
            this.lblTituEnergia = new System.Windows.Forms.Label();
            this.lblPontos = new System.Windows.Forms.Label();
            this.lblTituPontos = new System.Windows.Forms.Label();
            this.lblVidas = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblDistY = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblDistX = new System.Windows.Forms.Label();
            this.lblTicks = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbxJogador = new System.Windows.Forms.PictureBox();
            this.lblValorTicks = new System.Windows.Forms.Label();
            this.pgbEnergia = new System.Windows.Forms.ProgressBar();
            this.btnTeste.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxJogador)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTeste
            // 
            this.btnTeste.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnTeste.Controls.Add(this.pgbEnergia);
            this.btnTeste.Controls.Add(this.lblTituVidas);
            this.btnTeste.Controls.Add(this.lblEnergia);
            this.btnTeste.Controls.Add(this.lblTituEnergia);
            this.btnTeste.Controls.Add(this.lblPontos);
            this.btnTeste.Controls.Add(this.lblTituPontos);
            this.btnTeste.Controls.Add(this.lblVidas);
            this.btnTeste.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTeste.Location = new System.Drawing.Point(0, 0);
            this.btnTeste.Name = "btnTeste";
            this.btnTeste.Size = new System.Drawing.Size(900, 100);
            this.btnTeste.TabIndex = 0;
            // 
            // lblTituVidas
            // 
            this.lblTituVidas.AutoSize = true;
            this.lblTituVidas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituVidas.ForeColor = System.Drawing.Color.White;
            this.lblTituVidas.Location = new System.Drawing.Point(307, 22);
            this.lblTituVidas.Name = "lblTituVidas";
            this.lblTituVidas.Size = new System.Drawing.Size(61, 22);
            this.lblTituVidas.TabIndex = 8;
            this.lblTituVidas.Text = "Vidas";
            this.lblTituVidas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEnergia
            // 
            this.lblEnergia.AutoSize = true;
            this.lblEnergia.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnergia.ForeColor = System.Drawing.Color.White;
            this.lblEnergia.Location = new System.Drawing.Point(578, 46);
            this.lblEnergia.Name = "lblEnergia";
            this.lblEnergia.Size = new System.Drawing.Size(21, 22);
            this.lblEnergia.TabIndex = 7;
            this.lblEnergia.Text = "0";
            this.lblEnergia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTituEnergia
            // 
            this.lblTituEnergia.AutoSize = true;
            this.lblTituEnergia.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituEnergia.ForeColor = System.Drawing.Color.White;
            this.lblTituEnergia.Location = new System.Drawing.Point(550, 22);
            this.lblTituEnergia.Name = "lblTituEnergia";
            this.lblTituEnergia.Size = new System.Drawing.Size(81, 22);
            this.lblTituEnergia.TabIndex = 6;
            this.lblTituEnergia.Text = "Energia";
            this.lblTituEnergia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPontos
            // 
            this.lblPontos.AutoSize = true;
            this.lblPontos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPontos.ForeColor = System.Drawing.Color.White;
            this.lblPontos.Location = new System.Drawing.Point(438, 44);
            this.lblPontos.Name = "lblPontos";
            this.lblPontos.Size = new System.Drawing.Size(41, 43);
            this.lblPontos.TabIndex = 5;
            this.lblPontos.Text = "0";
            this.lblPontos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTituPontos
            // 
            this.lblTituPontos.AutoSize = true;
            this.lblTituPontos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituPontos.ForeColor = System.Drawing.Color.White;
            this.lblTituPontos.Location = new System.Drawing.Point(397, 9);
            this.lblTituPontos.Name = "lblTituPontos";
            this.lblTituPontos.Size = new System.Drawing.Size(131, 32);
            this.lblTituPontos.TabIndex = 4;
            this.lblTituPontos.Text = "PONTOS";
            this.lblTituPontos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVidas
            // 
            this.lblVidas.AutoSize = true;
            this.lblVidas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVidas.ForeColor = System.Drawing.Color.White;
            this.lblVidas.Location = new System.Drawing.Point(330, 44);
            this.lblVidas.Name = "lblVidas";
            this.lblVidas.Size = new System.Drawing.Size(22, 24);
            this.lblVidas.TabIndex = 3;
            this.lblVidas.Text = "0";
            this.lblVidas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.ForeColor = System.Drawing.Color.White;
            this.lblY.Location = new System.Drawing.Point(862, 124);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(35, 13);
            this.lblY.TabIndex = 5;
            this.lblY.Text = "label6";
            this.lblY.Visible = false;
            // 
            // lblDistY
            // 
            this.lblDistY.AutoSize = true;
            this.lblDistY.ForeColor = System.Drawing.Color.White;
            this.lblDistY.Location = new System.Drawing.Point(792, 124);
            this.lblDistY.Name = "lblDistY";
            this.lblDistY.Size = new System.Drawing.Size(64, 13);
            this.lblDistY.TabIndex = 4;
            this.lblDistY.Text = "Distância Y:";
            this.lblDistY.Visible = false;
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.ForeColor = System.Drawing.Color.White;
            this.lblX.Location = new System.Drawing.Point(862, 103);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(35, 13);
            this.lblX.TabIndex = 2;
            this.lblX.Text = "label3";
            this.lblX.Visible = false;
            // 
            // lblDistX
            // 
            this.lblDistX.AutoSize = true;
            this.lblDistX.ForeColor = System.Drawing.Color.White;
            this.lblDistX.Location = new System.Drawing.Point(792, 103);
            this.lblDistX.Name = "lblDistX";
            this.lblDistX.Size = new System.Drawing.Size(64, 13);
            this.lblDistX.TabIndex = 1;
            this.lblDistX.Text = "Distância X:";
            this.lblDistX.Visible = false;
            // 
            // lblTicks
            // 
            this.lblTicks.AutoSize = true;
            this.lblTicks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblTicks.ForeColor = System.Drawing.Color.White;
            this.lblTicks.Location = new System.Drawing.Point(862, 146);
            this.lblTicks.Name = "lblTicks";
            this.lblTicks.Size = new System.Drawing.Size(33, 13);
            this.lblTicks.TabIndex = 0;
            this.lblTicks.Text = "Vidas";
            this.lblTicks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTicks.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pbxJogador
            // 
            this.pbxJogador.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pbxJogador.Location = new System.Drawing.Point(290, 300);
            this.pbxJogador.Name = "pbxJogador";
            this.pbxJogador.Size = new System.Drawing.Size(10, 10);
            this.pbxJogador.TabIndex = 1;
            this.pbxJogador.TabStop = false;
            // 
            // lblValorTicks
            // 
            this.lblValorTicks.AutoSize = true;
            this.lblValorTicks.ForeColor = System.Drawing.Color.White;
            this.lblValorTicks.Location = new System.Drawing.Point(817, 146);
            this.lblValorTicks.Name = "lblValorTicks";
            this.lblValorTicks.Size = new System.Drawing.Size(39, 13);
            this.lblValorTicks.TabIndex = 6;
            this.lblValorTicks.Text = "Ticks: ";
            this.lblValorTicks.Visible = false;
            // 
            // pgbEnergia
            // 
            this.pgbEnergia.Location = new System.Drawing.Point(12, 87);
            this.pgbEnergia.Maximum = 200;
            this.pgbEnergia.Name = "pgbEnergia";
            this.pgbEnergia.Size = new System.Drawing.Size(876, 10);
            this.pgbEnergia.TabIndex = 9;
            this.pgbEnergia.Value = 100;
            // 
            // frmJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.lblValorTicks);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.pbxJogador);
            this.Controls.Add(this.lblDistY);
            this.Controls.Add(this.btnTeste);
            this.Controls.Add(this.lblDistX);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.lblTicks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmJogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmJogo";
            this.Load += new System.EventHandler(this.frmJogo_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmJogo_KeyDown);
            this.btnTeste.ResumeLayout(false);
            this.btnTeste.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxJogador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel btnTeste;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblDistY;
        private System.Windows.Forms.Label lblVidas;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblDistX;
        private System.Windows.Forms.Label lblTicks;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pbxJogador;
        private System.Windows.Forms.Label lblEnergia;
        private System.Windows.Forms.Label lblTituEnergia;
        private System.Windows.Forms.Label lblPontos;
        private System.Windows.Forms.Label lblTituPontos;
        private System.Windows.Forms.Label lblTituVidas;
        private System.Windows.Forms.Label lblValorTicks;
        private System.Windows.Forms.ProgressBar pgbEnergia;
    }
}