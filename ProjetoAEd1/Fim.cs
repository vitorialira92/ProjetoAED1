using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAEd1
{
    public partial class Fim : Form
    {
        private string jogador;
        public Fim(Boolean ganhou, float pontuacao, string jogador)
        {
            InitializeComponent();
            this.jogador = jogador;
            string aux = "tela-fim-";
            if (ganhou)
            {
                aux += "ganhou.PNG";
            }
            else
                aux += "perdeu.PNG";
            System.Drawing.Image imagem;
            imagem = System.Drawing.Image.FromFile(@aux);
            this.BackgroundImage = imagem;
            pontuacaoText.ForeColor = System.Drawing.Color.FromArgb(1, 255, 167, 167);//cor tá certa
            
            pontuacaoText.Text ="  " + pontuacao.ToString();
            /*pra trocar imagem
             * string aux = botoes[0].getId().ToString() + "-1.PNG";
             *  System.Drawing.Image imagem;
             *  C:\Users\vitor\source\repos\ProjetoAEd1\ProjetoAEd1\Fim.cs
                imagem = System.Drawing.Image.FromFile(@aux);
                button1.BackgroundImage = imagem;*/
        }

        private void Fim_Load(object sender, EventArgs e)
        {

        }

        private void sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Jogo jogo = new Jogo(jogador);
            jogo.Show();
        }

        private void pontuacaoText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
