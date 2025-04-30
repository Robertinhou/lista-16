using System;
using System.Data;
using lista16;
using MySql.Data.MySqlClient;

public class Funcionario
{
    private int id;
    private string nome;
    private string cpf;
    private DateTime data;
    private double salario;
    private string sexo;
    private string setor;
    private string cargo;

    Conexao conexao = new Conexao();

    // Propriedades (Get e Set)
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

    public string Sexo
    {
        get { return sexo; }
        set { sexo = value; }
    }

    public string Setor
    {
        get { return setor; }
        set { setor = value; }
    }

    public string Cargo
    {
        get { return cargo; }
        set { cargo = value; }
    }

    // Construtores
    public Funcionario() { }

    public Funcionario(string nome, string cpf, DateTime data, double salario, string sexo, string setor, string cargo)
    {
        this.nome = nome;
        this.cpf = cpf;
        this.data = data;
        this.salario = salario;
        this.sexo = sexo;
        this.setor = setor;
        this.cargo = cargo;
    }

    public Funcionario(int id, string nome, string cpf, DateTime data, double salario, string sexo, string setor, string cargo)
    {
        this.id = id;
        this.nome = nome;
        this.cpf = cpf;
        this.data = data;
        this.salario = salario;
        this.sexo = sexo;
        this.setor = setor;
        this.cargo = cargo;
    }

    // Método Inserir
    public int InserirFuncionario()
    {
        using (MySqlConnection conexaoBanco = conexao.Conectar())
        {
            string sqlInsert = "INSERT INTO funcionarios (nome, cpf, data_nasc, salario, sexo, setor, cargo) " +
                               "VALUES (@nome, @cpf, @data, @salario, @sexo, @setor, @cargo)";

            MySqlCommand comandoSQL = new MySqlCommand(sqlInsert, conexaoBanco);

            comandoSQL.Parameters.AddWithValue("@nome", Nome);
            comandoSQL.Parameters.AddWithValue("@cpf", CPF);
            comandoSQL.Parameters.AddWithValue("@data", Data);
            comandoSQL.Parameters.AddWithValue("@salario", Salario);
            comandoSQL.Parameters.AddWithValue("@sexo", Sexo);
            comandoSQL.Parameters.AddWithValue("@setor", Setor);
            comandoSQL.Parameters.AddWithValue("@cargo", Cargo);

            int resultado = comandoSQL.ExecuteNonQuery();
            return resultado;
        }
    }

    // Método Editar
    public int EditarFuncionario()
    {
        using (MySqlConnection conexaoBanco = conexao.Conectar())
        {
            string sqlUpdate = "UPDATE funcionarios SET nome=@nome, cpf=@cpf, data=@data, salario=@salario, " +
                               "sexo=@sexo, setor=@setor, cargo=@cargo WHERE id=@id";

            MySqlCommand comandoSQL = new MySqlCommand(sqlUpdate, conexaoBanco);

            comandoSQL.Parameters.AddWithValue("@id", Id);
            comandoSQL.Parameters.AddWithValue("@nome", Nome);
            comandoSQL.Parameters.AddWithValue("@cpf", CPF);
            comandoSQL.Parameters.AddWithValue("@data", Data);
            comandoSQL.Parameters.AddWithValue("@salario", Salario);
            comandoSQL.Parameters.AddWithValue("@sexo", Sexo);
            comandoSQL.Parameters.AddWithValue("@setor", Setor);
            comandoSQL.Parameters.AddWithValue("@cargo", Cargo);

            int resultado = comandoSQL.ExecuteNonQuery();
            return resultado;
        }
    }

    // Método Excluir
    public int ExcluirFuncionario()
    {
        using (MySqlConnection conexaoBanco = conexao.Conectar())
        {
            string sqlDelete = "DELETE FROM funcionarios WHERE id=@id";

            MySqlCommand comandoSQL = new MySqlCommand(sqlDelete, conexaoBanco);

            comandoSQL.Parameters.AddWithValue("@id", Id);

            int resultado = comandoSQL.ExecuteNonQuery();
            return resultado;
        }
    }

    // Método Buscar
    public static bool BuscarFuncionario(string nome, DataGridView dgv)
    {
        Conexao conexao = new Conexao();

        using (MySqlConnection conexaoBanco = conexao.Conectar())
        {
            string sqlSelect = "SELECT * FROM funcionarios WHERE nome LIKE @nome";

            MySqlCommand comandoSQL = new MySqlCommand(sqlSelect, conexaoBanco);
            comandoSQL.Parameters.AddWithValue("@nome", "%" + nome + "%");

            MySqlDataAdapter da = new MySqlDataAdapter(comandoSQL);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgv.DataSource = dt;

            if (dgv.Rows.Count > 0)
            {
                dgv.ClearSelection();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
