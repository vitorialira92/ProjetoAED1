using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProjetoAEd1
{
    public partial class Intro : Form
    {
        SoundPlayer player;
        bool estaTocando;
        public Intro(SoundPlayer player, bool estaTocando)
        {
            InitializeComponent();
            this.player = player;
            this.estaTocando = estaTocando;
            tocar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Jogo jogo = new Jogo(nomeJogador.Text);
            jogo.Show();
            this.Hide();
            jogar.Enabled = false;
        }

        private void nomeJogador_TextChanged(object sender, EventArgs e)
        {
            if(nomeJogador.Text!= null)
            {
                jogar.Enabled=true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            TelaInicial tela = new TelaInicial();   
            tela.Show();
        }

        private void musica_Click(object sender, EventArgs e)
        {
            tocar();
        }
        public void tocar()
        {
            Image imagem;
            if (estaTocando)
            {
                player.Stop();
                estaTocando = false;
                imagem = Image.FromFile(@"no-music.PNG");
                musica.BackgroundImage = imagem;

            }

            else
            {
                player.PlayLooping();
                estaTocando = true;
                imagem = Image.FromFile(@"botao-musica.PNG");
                musica.BackgroundImage = imagem;
            }

        }
    }
}
