using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAEd1
{
    internal class Scores
    {
        private string nome;
        private float pontuacao;
        
        public Scores(string nome, float pontuacao)
        {
            this.nome = nome;
            this.pontuacao= pontuacao;
        }

        public string getNome()
        {
            return nome;
        }

        public float getPontuacao()
        {
            return pontuacao;
        }

    }
}
