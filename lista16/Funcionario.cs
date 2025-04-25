using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;


namespace lista16
{
    public class Funcionario
    {

        private int id;
        private string nome;
        private string cpf;
        private string data;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string CPF
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public string Data
        {
            get { return data; }
            set { data = value; }
        }

        

       

        public List<string> ObterSetores()
        {
            using (MySqlConnection conexao = new Conexao().Conectar())
            {
                List<string> nomesSetores = new List<string>();

                string sql = "SELECT * FROM setores ORDER BY nome ASC";
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                using (MySqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string nome = reader["nome"].ToString();
                        nomesSetores.Add(nome);
                    }
                }

                return nomesSetores;
            }
        }
    }
}
