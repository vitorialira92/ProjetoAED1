using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProjetoAEd1
{
    internal class Item{
        private string nome;
        private float valor;
        private int quant;
        private int tempoPrep; //de preparo


        public Item(string nome, float valor, int tempoPreparo)
        {
            this.nome = nome;
            this.valor = valor;
            this.tempoPrep = tempoPreparo;
        }

        public void setQuantidade(int quantidade)
        {
            quant = quantidade;
            this.valor = valor * quant; 
            this.tempoPrep = quant * tempoPrep;
        }


        public int getTempo() { return tempoPrep; }

        public float getValor() { return valor; }

        public int getQuant() { return quant; } 
        public string retornaEscrito()
        {
            string retorno = getQuant() + " " + getNome() + "(s)\n";
            return retorno;
        }

        public string getNome() { return nome; }
    }

    
}