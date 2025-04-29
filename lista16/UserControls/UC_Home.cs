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
    }
}
