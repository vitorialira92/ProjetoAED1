namespace ProjetoAEd1
{
    partial class Intro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Intro));
            this.jogar = new System.Windows.Forms.Button();
            this.musica = new System.Windows.Forms.Button();
            this.nomeJogador = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // jogar
            // 
            this.jogar.BackColor = System.Drawing.Color.Transparent;
            this.jogar.BackgroundImage = global::ProjetoAEd1.Properties.Resources.jogar_intro;
            this.jogar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.jogar.FlatAppearance.BorderSize = 0;
            this.jogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jogar.ForeColor = System.Drawing.Color.Transparent;
            this.jogar.Location = new System.Drawing.Point(787, 508);
            this.jogar.Name = "jogar";
            this.jogar.Size = new System.Drawing.Size(143, 52);
            this.jogar.TabIndex = 0;
            this.jogar.UseVisualStyleBackColor = false;
            this.jogar.Click += new System.EventHandler(this.button1_Click);
            // 
            // musica
            // 
            this.musica.BackColor = System.Drawing.Color.Transparent;
            this.musica.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("musica.BackgroundImage")));
            this.musica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.musica.FlatAppearance.BorderSize = 0;
            this.musica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.musica.Location = new System.Drawing.Point(932, 41);
            this.musica.Name = "musica";
            this.musica.Size = new System.Drawing.Size(66, 70);
            this.musica.TabIndex = 1;
            this.musica.UseVisualStyleBackColor = false;
            this.musica.Click += new System.EventHandler(this.musica_Click);
            // 
            // nomeJogador
            // 
            this.nomeJogador.Location = new System.Drawing.Point(425, 523);
            this.nomeJogador.Name = "nomeJogador";
            this.nomeJogador.Size = new System.Drawing.Size(294, 22);
            this.nomeJogador.TabIndex = 2;
            this.nomeJogador.TextChanged += new System.EventHandler(this.nomeJogador_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::ProjetoAEd1.Properties.Resources.seta;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(20, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 55);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::ProjetoAEd1.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(314, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(426, 121);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Intro
            // 
            this.AcceptButton = this.jogar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::ProjetoAEd1.Properties.Resources.intro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1006, 591);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nomeJogador);
            this.Controls.Add(this.musica);
            this.Controls.Add(this.jogar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Intro";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button jogar;
        private System.Windows.Forms.Button musica;
        private System.Windows.Forms.TextBox nomeJogador;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}