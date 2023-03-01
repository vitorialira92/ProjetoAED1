namespace ProjetoAEd1
{
    partial class Fim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fim));
            this.button1 = new System.Windows.Forms.Button();
            this.sair = new System.Windows.Forms.Button();
            this.pontuacaoText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::ProjetoAEd1.Properties.Resources.jogar_novamente;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(273, 432);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 77);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sair
            // 
            this.sair.BackColor = System.Drawing.Color.Transparent;
            this.sair.BackgroundImage = global::ProjetoAEd1.Properties.Resources.sair;
            this.sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.sair.FlatAppearance.BorderSize = 0;
            this.sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sair.Location = new System.Drawing.Point(550, 431);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(223, 77);
            this.sair.TabIndex = 1;
            this.sair.UseVisualStyleBackColor = false;
            this.sair.Click += new System.EventHandler(this.sair_Click);
            // 
            // pontuacaoText
            // 
            this.pontuacaoText.BackColor = System.Drawing.Color.White;
            this.pontuacaoText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pontuacaoText.Font = new System.Drawing.Font("Kawaii Stitch", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pontuacaoText.ForeColor = System.Drawing.SystemColors.Window;
            this.pontuacaoText.Location = new System.Drawing.Point(576, 306);
            this.pontuacaoText.Name = "pontuacaoText";
            this.pontuacaoText.Size = new System.Drawing.Size(187, 32);
            this.pontuacaoText.TabIndex = 2;
            this.pontuacaoText.TextChanged += new System.EventHandler(this.pontuacaoText_TextChanged);
            // 
            // Fim
            // 
            this.AcceptButton = this.sair;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1006, 591);
            this.Controls.Add(this.pontuacaoText);
            this.Controls.Add(this.sair);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Fim_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button sair;
        private System.Windows.Forms.TextBox pontuacaoText;
    }
}