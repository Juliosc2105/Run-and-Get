
namespace Run_and_Get
{
    partial class frmFimDeJogo
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblPontuacao = new System.Windows.Forms.Label();
            this.lblSubTitulo = new System.Windows.Forms.Label();
            this.btnJogarNov = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(8, 30);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(307, 55);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Fim do Jogo";
            // 
            // lblPontuacao
            // 
            this.lblPontuacao.AutoSize = true;
            this.lblPontuacao.Font = new System.Drawing.Font("Arial Rounded MT Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPontuacao.ForeColor = System.Drawing.Color.White;
            this.lblPontuacao.Location = new System.Drawing.Point(71, 211);
            this.lblPontuacao.Name = "lblPontuacao";
            this.lblPontuacao.Size = new System.Drawing.Size(184, 75);
            this.lblPontuacao.TabIndex = 1;
            this.lblPontuacao.Text = "0000";
            this.lblPontuacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubTitulo
            // 
            this.lblSubTitulo.AutoSize = true;
            this.lblSubTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitulo.ForeColor = System.Drawing.Color.White;
            this.lblSubTitulo.Location = new System.Drawing.Point(52, 165);
            this.lblSubTitulo.Name = "lblSubTitulo";
            this.lblSubTitulo.Size = new System.Drawing.Size(226, 28);
            this.lblSubTitulo.TabIndex = 2;
            this.lblSubTitulo.Text = "Sua pontuação foi:";
            // 
            // btnJogarNov
            // 
            this.btnJogarNov.CausesValidation = false;
            this.btnJogarNov.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnJogarNov.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.btnJogarNov.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJogarNov.Location = new System.Drawing.Point(172, 393);
            this.btnJogarNov.Name = "btnJogarNov";
            this.btnJogarNov.Size = new System.Drawing.Size(139, 45);
            this.btnJogarNov.TabIndex = 3;
            this.btnJogarNov.Text = "Jogar Novamente ";
            this.btnJogarNov.UseVisualStyleBackColor = true;
            this.btnJogarNov.Click += new System.EventHandler(this.btnJogarNov_Click);
            // 
            // btnSair
            // 
            this.btnSair.CausesValidation = false;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.btnSair.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(12, 393);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(139, 45);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmFimDeJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(323, 450);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnJogarNov);
            this.Controls.Add(this.lblSubTitulo);
            this.Controls.Add(this.lblPontuacao);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFimDeJogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFimDeJogo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblPontuacao;
        private System.Windows.Forms.Label lblSubTitulo;
        private System.Windows.Forms.Button btnJogarNov;
        private System.Windows.Forms.Button btnSair;
    }
}