using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace ProjetoAEd1
{
    public partial class Scoreboard : Form
    {
        private DBConnection conn;
        private int quantidadeRecords;
        public Scoreboard()
        {
            InitializeComponent();
            conn = new DBConnection();
            quantidadeRecords = conn.Count();
            adicionarScores();
        }

        private void adicionarScores() //método para adicionar os valores na tabela
        {
            List<Scores> lista1 = new List<Scores>();
            lista1 = conn.retornoTabela();
            ListViewItem[] itens = new ListViewItem[lista1.Count()];
            for (int i = 0;i < quantidadeRecords; i++) 
            {
                string[] itemAux = new string[2];
                itemAux[0] = lista1[i].getNome();
                itemAux[1] = lista1[i].getPontuacao().ToString();
                ListViewItem item = new ListViewItem(itemAux);
                lista.Items.Add(item);
            }
            
        }

        private void lista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaInicial tela = new TelaInicial();
            tela.Show();
        }
    }
}
