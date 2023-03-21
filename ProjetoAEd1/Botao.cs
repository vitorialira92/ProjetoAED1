using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAEd1
{
    internal class Botao
    {
        private bool ocupado;
        private int id;
        private int quantidade;

        public Botao()
        {
            ocupado = false;
            id = 0;
            quantidade = 0;
        }


        public void ocupar(int id)
        {
            ocupado = true;
            this.id = id;
            this.quantidade++;
            
        }

        public bool getOcupado()
        {
            return ocupado;
        }

        public int getId()
        {
            return id;
        }


        public void desocupar()
        {
            quantidade--;
            if(quantidade == 0)
            {
                id = 0;
                ocupado = false;
            }

        }
        public int getQuant()
        {
            return quantidade;
        }
        public void resetar()
        {
            ocupado = false;
            id = 0;
            quantidade = 0;
            
        }
    }
}
