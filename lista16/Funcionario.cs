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
        private DateTime data;
        private double salario;
        private char sexo;
        private string cargo;
        private string setor;



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

        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }

        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }

       public char Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public string Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }

        public string Setor
        {
            get { return setor; }
            set{ setor = value; }
        }


        
    }
}
