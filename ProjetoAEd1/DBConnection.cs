using System;
using System.Collections.Generic;
using System.Data.SQLite;
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
            server = "localhost";
            database = "aed";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";DATABASE=" + database + ";UID=" +
                uid + ";PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
            command = connection.CreateCommand();

        }

        private bool OpenConnection()
        {
            try
            {
                if(connection.State.ToString() != "Open")
                connection.Open();
                return true;
            }
            catch (MySqlException e)
            {
                switch (e.ErrorCode)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server. Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;

            }
        }

        private bool CloseConnection()
        {
            try
            {
                connection.Close(); 
                return true;
            }
            catch(MySqlException e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public void insert(string nome, float score ) //can only insert into records
        {
            string query = "insert into records value ('" + nome + "'," + score + ")";

            if (this.OpenConnection() == true || connection.State.ToString() == "Open")
            {
                MySqlCommand cmd = new MySqlCommand(query);
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }


        public Item novoItem(int id)
        {
            Item item;
            string query = "select * from itens where id =" + id;
            if (this.OpenConnection() == true || connection.State.ToString() == "Open")
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                //reader.Read();

                float valor = 0;
                string nome = "";
                int tempoPreparo = 0;
                while (reader.Read())
                {
                    valor = float.Parse(reader.GetFloat(2).ToString());
                    nome = reader.GetString(1).ToString();
                    tempoPreparo = reader.GetInt32(3);
                    
                }
                reader.Close();
                this.CloseConnection();
                item = new Item(nome, valor, tempoPreparo);
                return item;
            }

            return null;
        }
        
        public void delete(string nome)
        {
            string query = "delete from records where nome = '" + nome + "';";

            if (this.OpenConnection() == true || connection.State.ToString() == "Open")
            {
                MySqlCommand cmd = new MySqlCommand(query);
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public void update(string nome, float score)
        {
            int scoreAux = (int)score;
            string query = "update records set score = " + scoreAux + " where autor ='" + nome + "';";
            if (this.OpenConnection() == true || connection.State.ToString() == "Open")
            {
                MySqlCommand cmd = new MySqlCommand(query);
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public float retorno(string nome)
        {
            string query = "select * from records where autor ='" + nome + "';";
            float retorno = -1;

            if(this.OpenConnection() == true || connection.State.ToString() == "Open")
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    retorno = (int)reader.GetInt32(reader.GetOrdinal("score"));
                }
                reader.Close();
                this.CloseConnection();
            }

            return retorno;
        }

        public List<Scores> retornoTabela()
        {
            //criar um array de score e retorna com os elementos da tabela em ordem decrescente
            string query = "select * from records order by score desc;";

            List <Scores> lista = new List<Scores>();
            if (this.OpenConnection() == true || connection.State.ToString() == "Open")
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                //reader.Read();
                int counter = 0;
                
                while (reader.Read())
                {
                    float valor = float.Parse(reader.GetFloat(1).ToString());
                    string nome = reader.GetString(0).ToString();
                    Scores aux = new Scores(nome, valor);
                    lista.Add(aux);
                    //MessageBox.Show("counter " + counter + "nome " + nome + "valor" + valor);
                    //retorna na ordem certa, exibe na ordem errada
                    /*lista[counter] = new Scores(nome, valor);*/
                    counter++; //???????????
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

            //Open Connection
            if (this.OpenConnection() == true || connection.State.ToString() == "Open")
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //ExecuteScalar will return one value
                Count = int.Parse(cmd.ExecuteScalar().ToString());
                
                //close Connection
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
