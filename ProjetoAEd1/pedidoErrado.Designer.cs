namespace ProjetoAEd1
{
    partial class pedidoErrado
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
            this.voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // voltar
            // 
            this.voltar.BackColor = System.Drawing.Color.Transparent;
            this.voltar.BackgroundImage = global::ProjetoAEd1.Properties.Resources.voltar;
            this.voltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.voltar.FlatAppearance.BorderSize = 0;
            this.voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.voltar.Location = new System.Drawing.Point(230, 139);
            this.voltar.Margin = new System.Windows.Forms.Padding(0);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(94, 36);
            this.voltar.TabIndex = 0;
            this.voltar.UseVisualStyleBackColor = false;
            this.voltar.Click += new System.EventHandler(this.voltar_Click);
            // 
            // pedidoErrado
            // 
            this.AcceptButton = this.voltar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoAEd1.Properties.Resources.messageBox_pedidoErrado;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(554, 225);
            this.Controls.Add(this.voltar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "pedidoErrado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button voltar;
    }
}