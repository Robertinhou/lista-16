using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using MySql.Data.MySqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lista16.UserControls
{
    public partial class UC_Home : UserControl
    {
        public UC_Home()
        {
            InitializeComponent();
        }

        private void txtCPF_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {



        }



        private void UC_Home_Load_1(object sender, EventArgs e)
        {

            using (MySqlConnection conexao = new Conexao().Conectar())
            {

                Setor setor = new Setor();

                List<string> setores = setor.ObterSetores();




                foreach (string set in setores)
                {
                    comboBox1.Items.Add(set);
                }

                if (setores.Count == 0)
                {

                    comboBox1.Items.Add("Nenhum setor encontrado!");

                    comboBox1.SelectedIndex = 0;

                    comboBox1.Enabled = false;

                }

            }

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Setor setor = new Setor();



        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            string sexo = rBtnMasculino.Checked ? "Masculino" : "Feminino";

            Funcionario func = new Funcionario(
                txtNome.Text,
                txtCPF.Text,
                dtpData.Value,
                double.Parse(txtSalario.Text),
                sexo,
                comboBox1.Text,
                txtCargo.Text
            );

            int resultado = func.InserirFuncionario();

            if (resultado > 0)
            {

                MessageBox.Show("Funcionário cadastrado com sucesso!");
            }
            else
            {
 MessageBox.Show("Erro ao cadastrar funcionário.");
            }
               
        }

        

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBuscarNome_TextChanged(object sender, EventArgs e)
        {

            

            if(txtBuscarNome.Text.Length > 0)
            {

                Funcionario.BuscarFuncionario(txtBuscarNome.Text, dataGrid);
                
            }

        }

        private void txtCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtCargo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpData_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtSalario_TextChanged(object sender, EventArgs e)
        {

        }

        private void rBtnMasculino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rBtnFeminina_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
