using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;

namespace lista16
{
    

    public class Conexao
    {
        private string conexaoBanco = "Server=localHost;Database=empresa;Uid=root;pwd=''";

        public MySqlConnection Conectar()
        {

            MySqlConnection conexao = new MySqlConnection(conexaoBanco);

            conexao.Open();

            return conexao;
        }

    }
}
