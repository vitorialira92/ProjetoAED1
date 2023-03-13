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
        public Intro()
        {
            InitializeComponent();
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
        }
    }
}
