using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace ProjetoAEd1
{
    public partial class TelaInicial : Form
    {
        public static Boolean estaTocando;
        public static SoundPlayer player;
        public static SoundPlayer player2;
        public TelaInicial()
        {
            InitializeComponent();
            player = new SoundPlayer();
            PlayMusic();
            estaTocando = true;
            Image imagem;
            imagem = Image.FromFile(@"1-tela_inicial.PNG");
            //this.BackgroundImage = imagem;
        }
        public static void PlayMusic()
        {
            player.SoundLocation = "still-lovely.wav";
            player.PlayLooping();
            estaTocando = true;
        }

        public static void PlayMusicButton()
        {
        }

        public static void StopMusic()
        {
            player.Stop();
            estaTocando = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlayMusicButton();
            Intro intro = new Intro();
            intro.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PlayMusicButton();
            this.Hide();
            Scoreboard scoreboard = new Scoreboard();
            scoreboard.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PlayMusicButton();
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PlayMusicButton();
            Image imagem;
            if (estaTocando)
            {
                StopMusic();
                estaTocando = false;
                imagem = Image.FromFile(@"no-music.PNG");
                musica.BackgroundImage = imagem;
                
            }

            else
            {
                PlayMusic(); 
                estaTocando = true;
                imagem = Image.FromFile(@"botao-musica.PNG");
                musica.BackgroundImage = imagem;
            }
                
        }
    }
}
