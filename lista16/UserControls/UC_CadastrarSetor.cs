using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lista16.UserControls
{
    public partial class UC_CadastrarSetor : UserControl
    {
        public UC_CadastrarSetor()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

            Setor setor = new Setor();

            setor.Nome = txtNome.Text;

            setor.InserirSetor();

            setor.BuscarPorNone(dataGrind);

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            Setor setor = new Setor();

        }
    }
}
