namespace lista16.UserControls
{
    partial class UC_Home
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            lblNomeF = new Label();
            txtBuscarNome = new TextBox();
            dataGrid = new DataGridView();
            lblID = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnCadastrar = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            CBmasculino = new CheckBox();
            CBfeminino = new CheckBox();
            txtID = new TextBox();
            txtNome = new TextBox();
            dtpData = new DateTimePicker();
            txtCPF = new MaskedTextBox();
            txtSalario = new TextBox();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            SuspendLayout();
            // 
            // lblNomeF
            // 
            lblNomeF.AutoSize = true;
            lblNomeF.Location = new Point(33, 20);
            lblNomeF.Name = "lblNomeF";
            lblNomeF.Size = new Size(166, 15);
            lblNomeF.TabIndex = 0;
            lblNomeF.Text = "Digite o nome do funcionário:";
            // 
            // txtBuscarNome
            // 
            txtBuscarNome.Location = new Point(215, 17);
            txtBuscarNome.Name = "txtBuscarNome";
            txtBuscarNome.Size = new Size(365, 23);
            txtBuscarNome.TabIndex = 1;
            // 
            // dataGrid
            // 
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Location = new Point(33, 62);
            dataGrid.Name = "dataGrid";
            dataGrid.Size = new Size(547, 178);
            dataGrid.TabIndex = 2;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(33, 253);
            lblID.Name = "lblID";
            lblID.Size = new Size(21, 15);
            lblID.TabIndex = 3;
            lblID.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 282);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 4;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 316);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 5;
            label3.Text = "Data:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 346);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 6;
            label4.Text = "Salário:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 379);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 7;
            label5.Text = "Sexo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(482, 253);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 8;
            label6.Text = "CPF:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(482, 285);
            label7.Name = "label7";
            label7.Size = new Size(37, 15);
            label7.TabIndex = 9;
            label7.Text = "Setor:";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(146, 423);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(137, 30);
            btnCadastrar.TabIndex = 10;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(367, 423);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(137, 30);
            btnEditar.TabIndex = 11;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(574, 423);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(137, 30);
            btnExcluir.TabIndex = 12;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // CBmasculino
            // 
            CBmasculino.AutoSize = true;
            CBmasculino.Location = new Point(72, 379);
            CBmasculino.Name = "CBmasculino";
            CBmasculino.Size = new Size(81, 19);
            CBmasculino.TabIndex = 13;
            CBmasculino.Text = "Masculino";
            CBmasculino.UseVisualStyleBackColor = true;
            // 
            // CBfeminino
            // 
            CBfeminino.AutoSize = true;
            CBfeminino.Location = new Point(159, 379);
            CBfeminino.Name = "CBfeminino";
            CBfeminino.Size = new Size(76, 19);
            CBfeminino.TabIndex = 14;
            CBfeminino.Text = "Feminino";
            CBfeminino.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            txtID.Location = new Point(88, 253);
            txtID.Name = "txtID";
            txtID.Size = new Size(67, 23);
            txtID.TabIndex = 15;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(88, 282);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(365, 23);
            txtNome.TabIndex = 16;
            // 
            // dtpData
            // 
            dtpData.Checked = false;
            dtpData.Format = DateTimePickerFormat.Short;
            dtpData.Location = new Point(86, 313);
            dtpData.MinDate = new DateTime(1960, 1, 1, 0, 0, 0, 0);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(111, 23);
            dtpData.TabIndex = 20;
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(525, 250);
            txtCPF.Mask = "000,000,000-00";
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(152, 23);
            txtCPF.TabIndex = 22;
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(86, 343);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(115, 23);
            txtSalario.TabIndex = 17;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(525, 285);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(152, 23);
            comboBox1.TabIndex = 23;
            // 
            // UC_Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(comboBox1);
            Controls.Add(txtCPF);
            Controls.Add(dtpData);
            Controls.Add(txtSalario);
            Controls.Add(txtNome);
            Controls.Add(txtID);
            Controls.Add(CBfeminino);
            Controls.Add(CBmasculino);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnCadastrar);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblID);
            Controls.Add(dataGrid);
            Controls.Add(txtBuscarNome);
            Controls.Add(lblNomeF);
            Name = "UC_Home";
            Size = new Size(850, 461);
            Load += UC_Home_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNomeF;
        private TextBox txtBuscarNome;
        private DataGridView dataGrid;
        private Label lblID;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnCadastrar;
        private Button btnEditar;
        private Button btnExcluir;
        private CheckBox CBmasculino;
        private CheckBox CBfeminino;
        private TextBox txtID;
        private TextBox txtNome;
        private DateTimePicker dtpData;
        private MaskedTextBox txtCPF;
        private TextBox txtSalario;
        private ComboBox comboBox1;
    }
}
