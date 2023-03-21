namespace ProjetoAEd1
{
    partial class Jogo
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
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.cha = new System.Windows.Forms.Button();
            this.cafe = new System.Windows.Forms.Button();
            this.donut = new System.Windows.Forms.Button();
            this.rocambole = new System.Windows.Forms.Button();
            this.panqueca = new System.Windows.Forms.Button();
            this.bolo = new System.Windows.Forms.Button();
            this.fim = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textoTimer = new System.Windows.Forms.TextBox();
            this.textoPedido = new System.Windows.Forms.TextBox();
            this.textPontuacao = new System.Windows.Forms.TextBox();
            this.textProximos = new System.Windows.Forms.TextBox();
            this.desistir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // cha
            // 
            this.cha.BackColor = System.Drawing.Color.Transparent;
            this.cha.BackgroundImage = global::ProjetoAEd1.Properties.Resources.botao_cha;
            this.cha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cha.FlatAppearance.BorderSize = 0;
            this.cha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cha.Location = new System.Drawing.Point(252, 124);
            this.cha.Name = "cha";
            this.cha.Size = new System.Drawing.Size(86, 85);
            this.cha.TabIndex = 0;
            this.cha.UseVisualStyleBackColor = false;
            this.cha.Click += new System.EventHandler(this.cha_Click);
            // 
            // cafe
            // 
            this.cafe.BackColor = System.Drawing.Color.Transparent;
            this.cafe.BackgroundImage = global::ProjetoAEd1.Properties.Resources.botao_cafe;
            this.cafe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cafe.FlatAppearance.BorderSize = 0;
            this.cafe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cafe.Location = new System.Drawing.Point(346, 124);
            this.cafe.Name = "cafe";
            this.cafe.Size = new System.Drawing.Size(86, 85);
            this.cafe.TabIndex = 1;
            this.cafe.UseVisualStyleBackColor = false;
            this.cafe.Click += new System.EventHandler(this.cafe_Click);
            // 
            // donut
            // 
            this.donut.BackColor = System.Drawing.Color.Transparent;
            this.donut.BackgroundImage = global::ProjetoAEd1.Properties.Resources.botao_donut;
            this.donut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.donut.FlatAppearance.BorderSize = 0;
            this.donut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.donut.Location = new System.Drawing.Point(438, 124);
            this.donut.Name = "donut";
            this.donut.Size = new System.Drawing.Size(86, 85);
            this.donut.TabIndex = 2;
            this.donut.UseVisualStyleBackColor = false;
            this.donut.Click += new System.EventHandler(this.donut_Click);
            // 
            // rocambole
            // 
            this.rocambole.BackColor = System.Drawing.Color.Transparent;
            this.rocambole.BackgroundImage = global::ProjetoAEd1.Properties.Resources.botao_rocambole;
            this.rocambole.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rocambole.FlatAppearance.BorderSize = 0;
            this.rocambole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rocambole.Location = new System.Drawing.Point(529, 124);
            this.rocambole.Name = "rocambole";
            this.rocambole.Size = new System.Drawing.Size(86, 85);
            this.rocambole.TabIndex = 3;
            this.rocambole.UseVisualStyleBackColor = false;
            this.rocambole.Click += new System.EventHandler(this.rocambole_Click);
            // 
            // panqueca
            // 
            this.panqueca.BackColor = System.Drawing.Color.Transparent;
            this.panqueca.BackgroundImage = global::ProjetoAEd1.Properties.Resources.panqueca;
            this.panqueca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panqueca.FlatAppearance.BorderSize = 0;
            this.panqueca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.panqueca.Location = new System.Drawing.Point(621, 124);
            this.panqueca.Name = "panqueca";
            this.panqueca.Size = new System.Drawing.Size(86, 85);
            this.panqueca.TabIndex = 4;
            this.panqueca.UseVisualStyleBackColor = false;
            this.panqueca.Click += new System.EventHandler(this.panqueca_Click);
            // 
            // bolo
            // 
            this.bolo.BackColor = System.Drawing.Color.Transparent;
            this.bolo.BackgroundImage = global::ProjetoAEd1.Properties.Resources.botao_bolo;
            this.bolo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bolo.FlatAppearance.BorderSize = 0;
            this.bolo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bolo.Location = new System.Drawing.Point(710, 124);
            this.bolo.Name = "bolo";
            this.bolo.Size = new System.Drawing.Size(86, 85);
            this.bolo.TabIndex = 5;
            this.bolo.UseVisualStyleBackColor = false;
            this.bolo.Click += new System.EventHandler(this.bolo_Click);
            // 
            // fim
            // 
            this.fim.BackColor = System.Drawing.Color.Transparent;
            this.fim.BackgroundImage = global::ProjetoAEd1.Properties.Resources.botao_fim;
            this.fim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fim.FlatAppearance.BorderSize = 0;
            this.fim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fim.Location = new System.Drawing.Point(902, 394);
            this.fim.Name = "fim";
            this.fim.Size = new System.Drawing.Size(85, 41);
            this.fim.TabIndex = 6;
            this.fim.UseVisualStyleBackColor = false;
            this.fim.Click += new System.EventHandler(this.fim_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.Enabled = false;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(711, 422);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(86, 85);
            this.button6.TabIndex = 12;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Enabled = false;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(622, 422);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(86, 85);
            this.button5.TabIndex = 11;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Enabled = false;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(530, 422);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 85);
            this.button4.TabIndex = 10;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Enabled = false;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(439, 422);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 85);
            this.button3.TabIndex = 9;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Enabled = false;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(347, 422);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 85);
            this.button2.TabIndex = 8;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(253, 422);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 85);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textoTimer
            // 
            this.textoTimer.BackColor = System.Drawing.Color.Salmon;
            this.textoTimer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textoTimer.Cursor = System.Windows.Forms.Cursors.Default;
            this.textoTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoTimer.Location = new System.Drawing.Point(57, 128);
            this.textoTimer.Margin = new System.Windows.Forms.Padding(0);
            this.textoTimer.Name = "textoTimer";
            this.textoTimer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textoTimer.Size = new System.Drawing.Size(138, 20);
            this.textoTimer.TabIndex = 13;
            this.textoTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textoTimer.TextChanged += new System.EventHandler(this.textoTimer_TextChanged);
            // 
            // textoPedido
            // 
            this.textoPedido.BackColor = System.Drawing.Color.White;
            this.textoPedido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textoPedido.Cursor = System.Windows.Forms.Cursors.Default;
            this.textoPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoPedido.Location = new System.Drawing.Point(835, 145);
            this.textoPedido.Margin = new System.Windows.Forms.Padding(0);
            this.textoPedido.Multiline = true;
            this.textoPedido.Name = "textoPedido";
            this.textoPedido.ReadOnly = true;
            this.textoPedido.ShortcutsEnabled = false;
            this.textoPedido.Size = new System.Drawing.Size(138, 246);
            this.textoPedido.TabIndex = 14;
            this.textoPedido.TextChanged += new System.EventHandler(this.textoPedido_TextChanged);
            // 
            // textPontuacao
            // 
            this.textPontuacao.BackColor = System.Drawing.Color.Salmon;
            this.textPontuacao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPontuacao.Cursor = System.Windows.Forms.Cursors.Default;
            this.textPontuacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPontuacao.Location = new System.Drawing.Point(17, 173);
            this.textPontuacao.Margin = new System.Windows.Forms.Padding(0);
            this.textPontuacao.Name = "textPontuacao";
            this.textPontuacao.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textPontuacao.Size = new System.Drawing.Size(138, 20);
            this.textPontuacao.TabIndex = 15;
            this.textPontuacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textPontuacao.TextChanged += new System.EventHandler(this.textPontuacao_TextChanged);
            // 
            // textProximos
            // 
            this.textProximos.BackColor = System.Drawing.Color.Salmon;
            this.textProximos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textProximos.Cursor = System.Windows.Forms.Cursors.Default;
            this.textProximos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textProximos.Location = new System.Drawing.Point(825, 478);
            this.textProximos.Margin = new System.Windows.Forms.Padding(0);
            this.textProximos.Name = "textProximos";
            this.textProximos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textProximos.Size = new System.Drawing.Size(162, 17);
            this.textProximos.TabIndex = 16;
            this.textProximos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textProximos.TextChanged += new System.EventHandler(this.textProximos_TextChanged);
            // 
            // desistir
            // 
            this.desistir.BackColor = System.Drawing.Color.Transparent;
            this.desistir.BackgroundImage = global::ProjetoAEd1.Properties.Resources.desistir;
            this.desistir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.desistir.FlatAppearance.BorderSize = 0;
            this.desistir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.desistir.Location = new System.Drawing.Point(811, 511);
            this.desistir.Name = "desistir";
            this.desistir.Size = new System.Drawing.Size(103, 39);
            this.desistir.TabIndex = 17;
            this.desistir.UseVisualStyleBackColor = false;
            this.desistir.Click += new System.EventHandler(this.desistir_Click);
            // 
            // Jogo
            // 
            this.AcceptButton = this.fim;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoAEd1.Properties.Resources.jogo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1006, 591);
            this.Controls.Add(this.desistir);
            this.Controls.Add(this.textProximos);
            this.Controls.Add(this.textPontuacao);
            this.Controls.Add(this.textoPedido);
            this.Controls.Add(this.textoTimer);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fim);
            this.Controls.Add(this.bolo);
            this.Controls.Add(this.panqueca);
            this.Controls.Add(this.rocambole);
            this.Controls.Add(this.donut);
            this.Controls.Add(this.cafe);
            this.Controls.Add(this.cha);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Jogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button cha;
        private System.Windows.Forms.Button cafe;
        private System.Windows.Forms.Button donut;
        private System.Windows.Forms.Button rocambole;
        private System.Windows.Forms.Button panqueca;
        private System.Windows.Forms.Button bolo;
        private System.Windows.Forms.Button fim;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textoTimer;
        private System.Windows.Forms.TextBox textoPedido;
        private System.Windows.Forms.TextBox textPontuacao;
        private System.Windows.Forms.TextBox textProximos;
        private System.Windows.Forms.Button desistir;
    }
}