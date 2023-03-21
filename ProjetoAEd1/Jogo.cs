using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ProjetoAEd1
{
    public partial class Jogo : Form
    {
        private Fila fila;
        private string jogador;
        private bool acelerado;
        private Pedido pedidoAgora; //salva o pedido atual
        private int tempo; //variável para o timer (salva o tempo de preparo do pedido atual)
        private float pontuacao; //pontuação total acumulada
        private int contadorTempo; //variável para contar o tempo total do jogo (para apressar e add novos)
        private int quantidadePedidos; //quantidade de pedidos na fila
        private int[] contadores; //auxiliares para os botões (conta quantos elementos de cada tipo na bandeja)
        private int pedidosFeitos; //quantidade de pedidos feitos
        private Botao[] botoes; //auxiliares para os botoes (reserva qual elemento na bandeja na posição)
        private DBConnection conn;
        desistencia desistencia;


        public Jogo(string jogador)
        {
            
            InitializeComponent();
            this.jogador = jogador;
            conn = new DBConnection();
            desistencia = new desistencia();
            fila = new Fila();
            acelerado = false;
            if (fila.addPedido(acelerado))
            { 
                //inicializando todas as variáveis
                pedidoAgora = fila.returnPedido(0);
                tempo = pedidoAgora.getTempo();
                pontuacao = 0;
                contadorTempo = 0;
                quantidadePedidos = 0; //0 na fila
                contadores = new int[6];
                pedidosFeitos = 0;
                botoes = new Botao[6];
                
                //fazendo definições
                textoPedido.Text = pedidoAgora.retornaPedido(); //adiciona o 1º pedido na tela
                textoTimer.Text = "00:"+tempo.ToString(); //coloca o tempo do 1º pedido na tela
                timer.Enabled = true; //liga o timer
            
                textPontuacao.Text = pontuacao.ToString(); //pontuação atual
                textProximos.Text = "Na fila: 0 pedidos"; //proximos na fila, inicialmente 0
                
                //inicialiando cada botão e contador
                for(int i=0;i<6;i++) 
                {
                    botoes[i] = new Botao();
                    contadores[i] = 0;
                }
            }
            
            
        }

        private void resetarBotoes() //reseta configurações iniciais dos botões para um novo pedido
        {
            for (int i = 0; i < 6; i++)
            {
                botoes[i].resetar(); //"limpa" todos os dados exceto a posição 
                contadores[i] = 0; //zerando todos os contadores

            }
            //restaura a funcionalidade e a imagem iniciais de todos os botões
            button1.BackgroundImage = null;
            button1.Enabled = false;
            cha.Enabled = true;
            button2.BackgroundImage = null;
            button2.Enabled = false;
            cafe.Enabled = true;
            button3.BackgroundImage = null;
            button3.Enabled = false;
            rocambole.Enabled = true;
            button4.BackgroundImage = null;
            button4.Enabled = false;
            panqueca.Enabled = true;
            donut.Enabled = true;
            button5.BackgroundImage = null;
            button5.Enabled = false;
            bolo.Enabled = true;
            button6.BackgroundImage = null;
            button6.Enabled = false;
        }

        private void novoPedido() //após finalizar um, mostra o próximo pedido (se houver)
        {
            fila.removerPedido();
            contadorTempo = 0; 
            quantidadePedidos = quantidadePedidos - 1;
            textProximos.Text = "Na fila: " + quantidadePedidos.ToString() + " pedidos";
            if (!fila.estaVazia())
            {
                //se houver outro pedido na fila, adiciona ele na tela
                pedidoAgora = fila.returnPedido(0);
                textoPedido.Text = pedidoAgora.retornaPedido();
                tempo = pedidoAgora.getTempo();
                textoTimer.Text = "00:" + tempo.ToString();
            }
            
            resetarBotoes();
        }

        private void textoPedido_TextChanged(object sender, EventArgs e) //sistema
        {

        }
        private void Form1_Load(object sender, EventArgs e) //sistema
        {

        }

        //adiciona um novo pedido na fila
        public void adicionarPedido()
        {
            if (fila.addPedido(acelerado))
            {
                textProximos.Text = "Na fila: " + quantidadePedidos.ToString() + " pedidos";
                quantidadePedidos++;
            }

        }

        
        //encerra o jogo chamando a próxima tela e informando se o usuário ganhou ou perdeu
        public void encerrar(bool ganhou)
        {

            //trocar essa função para conexão com o banco indireta através de scores
            this.Hide();
            if (ganhou)
            {
                pontuacao += 150;
            }
            Fim fim = new Fim(ganhou, pontuacao, jogador);
            if (conn.retorno(jogador) == -1) //usuário novo
            {
                conn.insert(jogador, pontuacao);
            }
            else if (conn.retorno(jogador) < pontuacao)
            {
                conn.update(jogador, pontuacao);
            }
            
            fim.Show();

            timer.Enabled = false;

        }


        //função do timer > encerra com tempo esgotado, adiciona pedidos na fila, diminui (apressa)
        //o tempo e ajusta o texto do timer (e a cor)
        private void timer_Tick(object sender, EventArgs e)
        {
            contadorTempo++;
            
            if (contadorTempo > pedidoAgora.getTempo())
            {
                encerrar(false);
                desistencia.Hide();
            }
            else if (pedidosFeitos == 27)
            {
                encerrar(true);
            }

            if ((contadorTempo%3)==0)
            {
                adicionarPedido();
            }

            
            /* diminuir tempo
             * if(contadorTempo>50)*/
            if (quantidadePedidos == 7)
            {
                acelerado = true;
                //dimiuir tempo
            }
            if (tempo > 0)
            {
                tempo--;
                if(tempo>=10)
                    textoTimer.Text = "00:" + tempo.ToString();
                else
                    textoTimer.Text = "00:0" + tempo.ToString();
                if (tempo < 5)
                {
                    textoTimer.ForeColor = Color.Red;
                }
                else
                    textoTimer.ForeColor = Color.Black;
            }
            else
            {

                textoTimer.Text = "00:00";
            }
        }

        
        //do sistema
        private void textoTimer_TextChanged(object sender, EventArgs e)
        {
            

        }
        private void textProximos_TextChanged(object sender, EventArgs e)
        {

        }


        private void adicionar(int id) //adiciona um elemento na bandeja
        {
            int aux_posicao = -1; 
            for(int i = 0; i < 6; i++) //verificando se há algum lugar ocupado com o mesmo tipo de item
            {
                if (botoes[i].getId() == id)
                {
                    aux_posicao = i;
                    i = 6;
                }
            }
            if(aux_posicao == -1) //se não há, acha o primeiro desocupado
            {
                int i = 0;
                while (botoes[i].getId() != 0)
                {
                    i++;
                }
                aux_posicao = i;
            }
            
            //código refeito para correção de bug

            botoes[aux_posicao].ocupar(id);
            string aux = id.ToString() + "-" + botoes[aux_posicao].getQuant().ToString() + ".PNG";
            System.Drawing.Image imagem;
            imagem = System.Drawing.Image.FromFile(@aux);
            switch (aux_posicao)
            {
                case 0:
                    button1.BackgroundImage = imagem;
                    button1.Enabled = true;
                    break;
                case 1:
                    button2.BackgroundImage = imagem;
                    button2.Enabled = true;
                    break;
                case 2:
                    button3.BackgroundImage = imagem;
                    button3.Enabled = true;
                    break;
                case 3:
                    button4.BackgroundImage = imagem;
                    button4.Enabled = true;
                    break;
                case 4:
                    button5.BackgroundImage = imagem;
                    button5.Enabled = true;
                    break;
                case 5:
                    button6.BackgroundImage = imagem;
                    button6.Enabled = true;
                    break;

            }

                        
        }
        
        //botões de cima que adicionam os elementos na bandeja
        private void cha_Click(object sender, EventArgs e)
        {
            if (contadores[0] < 2)
            {
                contadores[0]++;
                adicionar(1);
            }
            else
            {
                cha.Enabled = false;
            }
            
        }

        private void cafe_Click(object sender, EventArgs e)
        {
            if (contadores[1] < 2)
            {
                contadores[1]++;
                adicionar(2);
            }
            else
            {
                cafe.Enabled = false;
            }
        }

        private void donut_Click(object sender, EventArgs e)
        {
            if (contadores[2] < 2)
            {
                contadores[2]++;
                adicionar(3);
            }
            else
            {
                donut.Enabled = false;
            }
        }

        private void rocambole_Click(object sender, EventArgs e)
        {
            if (contadores[3] < 2)
            {
                contadores[3]++;
                adicionar(4);
            }
            else
            {
                rocambole.Enabled = false;
            }
        }

        private void panqueca_Click(object sender, EventArgs e)
        {
            if (contadores[4] < 2)
            {
                contadores[4]++;
                adicionar(5);
            }
            else
            {
                panqueca.Enabled = false;
            }
        }

        private void bolo_Click(object sender, EventArgs e)
        {
            if (contadores[5] < 2)
            {
                contadores[5]++;
                adicionar(6);
            }
            else
            {
                bolo.Enabled = false;
            }
        }



        //botões da bandeja que adicionam os elementos na "bandeja"
        private void button1_Click(object sender, EventArgs e)
        {
            diminuirCont(botoes[0].getId());
            botoes[0].desocupar();

            if (botoes[0].getId()==0)
            {
                button1.BackgroundImage = null;
                button1.Enabled = false;
            }
            else
            {
                string aux = botoes[0].getId().ToString() + "-1.PNG";
                System.Drawing.Image imagem;
                imagem = System.Drawing.Image.FromFile(@aux);
                button1.BackgroundImage = imagem;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            diminuirCont(botoes[1].getId());
            botoes[1].desocupar();
            
            if (botoes[1].getId() == 0)
            {
                button2.BackgroundImage = null;
                button2.Enabled = false;
            }
            else
            {
                string aux = botoes[1].getId().ToString() + "-1.PNG";
                System.Drawing.Image imagem;
                imagem = System.Drawing.Image.FromFile(@aux);
                button2.BackgroundImage = imagem;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            diminuirCont(botoes[2].getId());
            botoes[2].desocupar();
            
            if (botoes[2].getId() == 0)
            {
                button3.BackgroundImage = null;
                button3.Enabled = false;
            }
            else
            {
                string aux = botoes[2].getId().ToString() + "-1.PNG";
                System.Drawing.Image imagem;
                imagem = System.Drawing.Image.FromFile(@aux);
                button3.BackgroundImage = imagem;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            diminuirCont(botoes[3].getId());
            botoes[3].desocupar();
            
            if (botoes[3].getId() == 0)
            {
                button4.BackgroundImage = null;
                button4.Enabled = false;
            }
            else
            {
                string aux = botoes[3].getId().ToString() + "-1.PNG";
                System.Drawing.Image imagem;
                imagem = System.Drawing.Image.FromFile(@aux);
                button4.BackgroundImage = imagem;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            diminuirCont(botoes[4].getId());
            botoes[4].desocupar();
            
            if (botoes[4].getId() == 0)
            {
                button5.BackgroundImage = null;
                button5.Enabled = false;
            }
            else
            {
                string aux = botoes[4].getId().ToString() + "-1.PNG";
                System.Drawing.Image imagem;
                imagem = System.Drawing.Image.FromFile(@aux);
                button5.BackgroundImage = imagem;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            diminuirCont(botoes[5].getId());
            botoes[5].desocupar();
            
            if (botoes[5].getId() == 0)
            {
                button6.BackgroundImage = null;
                button6.Enabled = false;
            }
            else
            {
                string aux = botoes[5].getId().ToString() + "-1.PNG";
                System.Drawing.Image imagem;
                imagem = System.Drawing.Image.FromFile(@aux);
                button6.BackgroundImage = imagem;
            }
        }


        private bool verificarPedido() //Verifica se o pedido montado está correto
        {
            int numero = pedidoAgora.getNumero();
            Pedido finalizado = new Pedido(numero, contadores, acelerado);
            if (pedidoAgora.compara(finalizado))
            {
                pontuacao += pedidoAgora.getValor();
                textPontuacao.Text = pontuacao.ToString();
                return true;
            }

            return false;
        }

        private void diminuirCont(int id) //diminui o contador de cada elemento adicionado no pedido
        {
            switch (id)
            {
                case 1:
                    cha.Enabled = true;
                    contadores[0]--;
                    break;
                case 2:
                    cafe.Enabled = true;
                    contadores[1]--;
                    break;
                case 3:
                    donut.Enabled = true;
                    contadores[2]--;
                    break;
                case 4:
                    rocambole.Enabled = true;
                    contadores[3]--;
                    break;
                case 5:
                    panqueca.Enabled = true;
                    contadores[4]--;
                    break;
                default:
                    bolo.Enabled = false;
                    contadores[5]--;
                    break;
            }

        }


        private void fim_Click(object sender, EventArgs e) //botão de fim
        {
            if(verificarPedido()) 
            { 
                pedidosFeitos++;
                novoPedido();
                
            }
            else
            {
                pedidoErrado errado = new pedidoErrado();
                errado.Show();
                //MessageBox.Show("Pedido errado.");
            }
        }

        private void desistir_Click(object sender, EventArgs e)
        {
            desistencia.Show();
        }

        private void textPontuacao_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
