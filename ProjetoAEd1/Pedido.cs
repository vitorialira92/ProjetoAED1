using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAEd1
{
    internal class Pedido
    {
        private int numPedido;//numero aleatório p o pedido
        private float valor;//valor total
        private Item[] itens;
        private int quantItens;
        private bool acelerado;
        private int tempoTotal;

        public Pedido(int numPedido, int[] quantidadesAleatorias, bool acelerado)
        {
            /*int quantCha, int quantCafe, int quantDonut, int quantRocambole,
            int quantPanqueca, int quantBolo,*/
            this.numPedido = numPedido;
            this.acelerado = acelerado;
            int aux = 0;

            for(int i = 0; i < 6; i++)
            {
                if (quantidadesAleatorias[i] != 0)
                    aux++;
            }

            itens = new Item[aux];
            quantItens = 0;
            
            if(adicionarItem(1, quantItens, quantidadesAleatorias[0], acelerado))
                quantItens++;
            if (adicionarItem(2, quantItens, quantidadesAleatorias[1], acelerado))
                quantItens++;
            if (adicionarItem(3, quantItens, quantidadesAleatorias[2], acelerado))
                quantItens++;
            if (adicionarItem(4, quantItens, quantidadesAleatorias[3], acelerado))
                quantItens++;
            if (adicionarItem(5, quantItens, quantidadesAleatorias[4], acelerado))
                quantItens++;
            if (adicionarItem(6, quantItens, quantidadesAleatorias[5], acelerado))
                quantItens++;
            
            
            calculaTempo();
            calculaValor();
        }

        private void calculaValor()
        {
            valor = 0;
            for (int i = 0; i < quantItens; i++)
            {
                valor+=itens[i].getValor();
            }
        }
        private bool adicionarItem(int id, int i, int quantidade, bool acelerado)
        {
            if (acelerado)
                id = id * 11;
            if(quantidade > 0)
            {
                DBConnection conn = new DBConnection(); 
                //estabelecendo conexão com o banco
                itens[i] = conn.novoItem(id);
                //novoItem retorna um item criado de acordo com id passado
                //Item é criado sem inicializar quantidade
                itens[i].setQuantidade(quantidade);
                //inicializando quantidade e atualizando valores de
                //valor e tempo de preparo
                return true;
            }
            return false;
            
        }

        /*public void diminuirTempo()
        {
            if (tempoTotal >= 4)
            {
                double aux = tempoTotal * 0.25;
                tempoTotal = (int)aux;
            }
        }
        */
        public int getTempo()
        {
            return tempoTotal;
        }

        private void calculaTempo()
        {
            for (int i = 0; i < quantItens; i++)
            {
                tempoTotal += itens[i].getTempo();
            }
        
        }


        public string retornaPedido()
        {
            string retorno = "Pedido " + numPedido + "\r\n";
            for(int i = 0; i < quantItens; i++)
            {
                retorno = retorno + itens[i].retornaEscrito() + " \r\n" ;
            }
            retorno = retorno + "Valor: R$" + valor;
            return retorno;
        }

        public int getNumero()
        {
            return numPedido;
        }

        public float getValor() { return valor; }

        public int getQuantidade()
        {
            return quantItens;
        }
        public bool compara(Pedido pedido)
        {
            if (pedido.quantItens != this.quantItens)
                return false;
            for(int i = 0; i < quantItens; i++)
            {
                if (pedido.itens[i].getNome() != this.itens[i].getNome() ||
                    pedido.itens[i].getTempo() != this.itens[i].getTempo() ||
                    pedido.itens[i].getValor() != this.itens[i].getValor()) 
                { 
                    return false;
                }
            }
            return true;
        }

    }


}
