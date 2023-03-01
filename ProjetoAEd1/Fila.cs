using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAEd1
{
    internal class Fila
    {
        private Pedido[] pedidos;
        private int quantPedidos;


        public Fila()
        {
            pedidos = new Pedido[5];
            quantPedidos = 0;
        }

        public bool addPedido(bool acelerado)
        {
            if (quantPedidos == 5)
                return false;
            quantPedidos++;
            Random gerador = new Random();
            int[] quantidadesAleatorias = new int[6];
            for(int i = 0; i < 6; i++)
            {
                quantidadesAleatorias[i] = gerador.Next(0,3);
            }
            pedidos[quantPedidos - 1] = new Pedido(gerador.Next(300,1899), quantidadesAleatorias, acelerado);
            return true;
        }
        
        public void removerPedido()
        {
            if(quantPedidos != 0)
            {
                for(int i = 0;i < quantPedidos -1;i++) 
                {
                    pedidos[i] = pedidos[i+1];
                }
                quantPedidos--;
                pedidos[quantPedidos] = null; 
            }
        }
        

        public bool estaVazia()
        {
            if (quantPedidos == 0)
                return true;
            return false;
        }

        public Pedido returnPedido(int i)
        {
            if(i<quantPedidos)
                return pedidos[i];
            return null;
        }

        public int getQuantidade()
        {
            return quantPedidos;
        }
    }
}
