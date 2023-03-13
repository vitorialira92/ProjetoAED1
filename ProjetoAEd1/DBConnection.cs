using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjetoAEd1
{
    internal class DBConnection
    {
        private MySqlConnection connection;
        private static SQLiteConnection connection2;
        private SQLiteCommand command2;
        private MySqlCommand command;
        private string server;
        private string database;
        private string uid;
        private string password;
        private int contadorAux;

        public DBConnection()
        {
            Initialize();
            contadorAux = Count();
        }

        public void Initialize()
        {
            //a fazer: mudar os nomes de command2 e connection2


            if (File.Exists(@"database.sqlite"))
            {
                connection2 = new SQLiteConnection("Data Source=database.sqlite; Version=3;");
                connection2.Open();
                command2 = new SQLiteCommand(connection2);


            }
            else
            {
                criarBanco();

            }

        }

        private void criarBanco()
        {
            SQLiteConnection.CreateFile(@"database.sqlite");
            connection2 = new SQLiteConnection("Data Source=database.sqlite; Version=3;New=True;");
            connection2.Open();//abrindo o banco
            //criar tabelas
            command2 = new SQLiteCommand(connection2);
            command2.CommandText = "CREATE TABLE records (autor VARCHAR (50) NOT NULL, score INT NOT NULL, primary key(autor));";
            command2.ExecuteNonQuery();
            //tabela de records
            command2.CommandText = "create table itens (id int not null, nome varchar(50) not null, valor float not null, tempoPreparo int, primary key(id));";
            command2.ExecuteNonQuery();
            //tabela de itens
            command2.CommandText = "insert into itens values(1, 'cha', 12, 2);insert into itens values(2, 'cafe', 12, 2);insert into itens values(3, 'donut', 12, 2);insert into itens values(4, " +
                "'rocambole', 23, 3);insert into itens values(5, 'panqueca', 10, 3);insert into itens values(6, 'bolo', 18, 3);insert into itens values(11, 'cha', 24, 1);insert into itens values(22, 'cafe', 24, 1);" +
                "insert into itens values(33, 'donut', 24, 1);insert into itens values(44, 'rocambole', 46, 2);insert into itens values(55, 'panqueca', 20, 2);insert into itens values(66, 'bolo', 36, 2);";
            command2.ExecuteNonQuery();
        }

        private bool OpenConnection()
        {
            try
            {
                if(connection2.State != ConnectionState.Open)
                {
                    connection2.Close();
                    connection2.Open();
                }
                return true;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                      
                return false;
            }
        }

        private bool CloseConnection()
        {
            try
            {
                connection2.Close();
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            
        }

        public void insert(string nome, float score ) //can only insert into records
        {
            string query = "insert into records values ('" + nome + "'," + score + ")";

            if(this.OpenConnection() == true || connection2.State.ToString() == "Open")
            {
                command2 = connection2.CreateCommand();
                command2.CommandText = query;
                command2.ExecuteNonQuery();
                this.CloseConnection();
            }

           
        }


        public Item novoItem(int id)
        {
            Item item;
            string query = "select * from itens where id =" + id;
            if (this.OpenConnection() == true || connection2.State.ToString() == "Open")
            {
                command2.CommandText = query;
                SQLiteDataReader reader2 = command2.ExecuteReader();
                float valor = 0;
                string nome = "";
                int tempoPreparo = 0;

                while (reader2.Read())
                {
                    valor = float.Parse(reader2.GetFloat(2).ToString());
                    nome = reader2.GetString(1).ToString();
                    tempoPreparo = reader2.GetInt32(3);

                }
                reader2.Close();
                this.CloseConnection();
                item = new Item(nome, valor, tempoPreparo);
                return item;
            }

            return null;
            
        }

        

        public void update(string nome, float score)
        {
            int scoreAux = (int)score;
            string query = "update records set score = " + scoreAux + " where autor ='" + nome + "';";
            if (this.OpenConnection() == true || connection2.State.ToString() == "Open")
            {
                command2.Connection.Open();
                command2.CommandText = query;
                command2.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public float retorno(string nome)
        {
            string query = "select * from records where autor ='" + nome + "';";
            float retorno = -1;

            command2.Connection.Open();
            command2.CommandText = query;
            SQLiteDataReader reader = command2.ExecuteReader();



            while (reader.Read())
            {
                retorno = (int)reader.GetInt32(reader.GetOrdinal("score"));
            }
            reader.Close();
            this.CloseConnection();

            return retorno;
        }

        public List<Scores> retornoTabela()
        {
            //criar um array de score e retorna com os elementos da tabela em ordem decrescente
            string query = "select * from records order by score desc;";

            List <Scores> lista = new List<Scores>();
            if (this.OpenConnection() == true || connection2.State.ToString() == "Open")
            {
                
                command2.CommandText = query;
                SQLiteDataReader reader = command2.ExecuteReader();

                int counter = 0;
                
                while (reader.Read())
                {
                    float valor = float.Parse(reader.GetFloat(1).ToString());
                    string nome = reader.GetString(0).ToString();
                    Scores aux = new Scores(nome, valor);
                    lista.Add(aux);
                    
                    counter++; 
                } 
                reader.Close();
                this.CloseConnection();
            }

            return lista;
        }

        public int Count()
        {
            string query = "select count(*) from records";
            int Count = -1;

            if (this.OpenConnection() == true || connection2.State.ToString() == "Open")
            {
                command2.CommandText = query;
                Count = int.Parse(command2.ExecuteScalar().ToString());
                
                this.CloseConnection();
                return Count;
            }
            else
            {
                return Count;
            }
        }
    }
}
