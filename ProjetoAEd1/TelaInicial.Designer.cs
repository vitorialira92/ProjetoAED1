using System.Windows.Forms;

namespace ProjetoAEd1
{
    partial class TelaInicial
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicial));
            this.play = new System.Windows.Forms.Button();
            this.scoreboard = new System.Windows.Forms.Button();
            this.sair = new System.Windows.Forms.Button();
            this.musica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // play
            // 
            this.play.BackColor = System.Drawing.Color.Transparent;
            this.play.BackgroundImage = global::ProjetoAEd1.Properties.Resources.botao_play;
            resources.ApplyResources(this.play, "play");
            this.play.FlatAppearance.BorderSize = 0;
            this.play.ForeColor = System.Drawing.Color.Transparent;
            this.play.Name = "play";
            this.play.UseVisualStyleBackColor = false;
            this.play.Click += new System.EventHandler(this.button1_Click);
            // 
            // scoreboard
            // 
            this.scoreboard.BackColor = System.Drawing.Color.Transparent;
            this.scoreboard.BackgroundImage = global::ProjetoAEd1.Properties.Resources.botao_scoreboard;
            resources.ApplyResources(this.scoreboard, "scoreboard");
            this.scoreboard.FlatAppearance.BorderSize = 0;
            this.scoreboard.ForeColor = System.Drawing.Color.Transparent;
            this.scoreboard.Name = "scoreboard";
            this.scoreboard.UseVisualStyleBackColor = false;
            this.scoreboard.Click += new System.EventHandler(this.button2_Click);
            // 
            // sair
            // 
            this.sair.BackColor = System.Drawing.Color.Transparent;
            this.sair.BackgroundImage = global::ProjetoAEd1.Properties.Resources.botao_sair;
            resources.ApplyResources(this.sair, "sair");
            this.sair.FlatAppearance.BorderSize = 0;
            this.sair.ForeColor = System.Drawing.Color.Transparent;
            this.sair.Name = "sair";
            this.sair.UseVisualStyleBackColor = false;
            this.sair.Click += new System.EventHandler(this.button3_Click);
            // 
            // musica
            // 
            this.musica.BackColor = System.Drawing.Color.Transparent;
            this.musica.BackgroundImage = global::ProjetoAEd1.Properties.Resources.botao_musica;
            resources.ApplyResources(this.musica, "musica");
            this.musica.FlatAppearance.BorderSize = 0;
            this.musica.ForeColor = System.Drawing.Color.Transparent;
            this.musica.Name = "musica";
            this.musica.UseVisualStyleBackColor = false;
            this.musica.Click += new System.EventHandler(this.button4_Click);
            // 
            // TelaInicial
            // 
            this.AcceptButton = this.play;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoAEd1.Properties.Resources._1_tela_inicial;
            this.Controls.Add(this.musica);
            this.Controls.Add(this.sair);
            this.Controls.Add(this.scoreboard);
            this.Controls.Add(this.play);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaInicial";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Button scoreboard;
        private System.Windows.Forms.Button sair;
        private System.Windows.Forms.Button musica;
    }
}

