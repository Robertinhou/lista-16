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
            txtID = new TextBox();
            txtNome = new TextBox();
            dtpData = new DateTimePicker();
            txtCPF = new MaskedTextBox();
            txtSalario = new TextBox();
            comboBox1 = new ComboBox();
            txtCargo = new TextBox();
            label1 = new Label();
            rBtnMasculino = new RadioButton();
            rBtnFeminina = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            SuspendLayout();
            // 
            // lblNomeF
            // 
            lblNomeF.AutoSize = true;
            lblNomeF.Location = new Point(47, 33);
            lblNomeF.Margin = new Padding(4, 0, 4, 0);
            lblNomeF.Name = "lblNomeF";
            lblNomeF.Size = new Size(251, 25);
            lblNomeF.TabIndex = 0;
            lblNomeF.Text = "Digite o nome do funcionário:";
            // 
            // txtBuscarNome
            // 
            txtBuscarNome.Location = new Point(307, 28);
            txtBuscarNome.Margin = new Padding(4, 5, 4, 5);
            txtBuscarNome.Name = "txtBuscarNome";
            txtBuscarNome.Size = new Size(520, 31);
            txtBuscarNome.TabIndex = 1;
            txtBuscarNome.TextChanged += txtBuscarNome_TextChanged;
            // 
            // dataGrid
            // 
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Location = new Point(47, 103);
            dataGrid.Margin = new Padding(4, 5, 4, 5);
            dataGrid.Name = "dataGrid";
            dataGrid.RowHeadersWidth = 62;
            dataGrid.Size = new Size(781, 297);
            dataGrid.TabIndex = 2;
            dataGrid.CellContentClick += dataGrid_CellContentClick;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(47, 422);
            lblID.Margin = new Padding(4, 0, 4, 0);
            lblID.Name = "lblID";
            lblID.Size = new Size(34, 25);
            lblID.TabIndex = 3;
            lblID.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 470);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(65, 25);
            label2.TabIndex = 4;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 527);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(53, 25);
            label3.TabIndex = 5;
            label3.Text = "Data:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 577);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(69, 25);
            label4.TabIndex = 6;
            label4.Text = "Salário:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 632);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(54, 25);
            label5.TabIndex = 7;
            label5.Text = "Sexo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(689, 422);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(46, 25);
            label6.TabIndex = 8;
            label6.Text = "CPF:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(689, 475);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(58, 25);
            label7.TabIndex = 9;
            label7.Text = "Setor:";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(209, 705);
            btnCadastrar.Margin = new Padding(4, 5, 4, 5);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(196, 50);
            btnCadastrar.TabIndex = 10;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(524, 705);
            btnEditar.Margin = new Padding(4, 5, 4, 5);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(196, 50);
            btnEditar.TabIndex = 11;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(820, 705);
            btnExcluir.Margin = new Padding(4, 5, 4, 5);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(196, 50);
            btnExcluir.TabIndex = 12;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(126, 422);
            txtID.Margin = new Padding(4, 5, 4, 5);
            txtID.Name = "txtID";
            txtID.Size = new Size(94, 31);
            txtID.TabIndex = 15;
            txtID.TextChanged += txtID_TextChanged;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(126, 470);
            txtNome.Margin = new Padding(4, 5, 4, 5);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(520, 31);
            txtNome.TabIndex = 16;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // dtpData
            // 
            dtpData.Checked = false;
            dtpData.Format = DateTimePickerFormat.Short;
            dtpData.Location = new Point(123, 522);
            dtpData.Margin = new Padding(4, 5, 4, 5);
            dtpData.MinDate = new DateTime(1960, 1, 1, 0, 0, 0, 0);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(157, 31);
            dtpData.TabIndex = 20;
            dtpData.ValueChanged += dtpData_ValueChanged;
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(750, 417);
            txtCPF.Margin = new Padding(4, 5, 4, 5);
            txtCPF.Mask = "000,000,000-00";
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(215, 31);
            txtCPF.TabIndex = 22;
            txtCPF.MaskInputRejected += txtCPF_MaskInputRejected;
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(123, 572);
            txtSalario.Margin = new Padding(4, 5, 4, 5);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(163, 31);
            txtSalario.TabIndex = 17;
            txtSalario.TextChanged += txtSalario_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(750, 475);
            comboBox1.Margin = new Padding(4, 5, 4, 5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(377, 33);
            comboBox1.TabIndex = 23;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(750, 527);
            txtCargo.Margin = new Padding(4, 5, 4, 5);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(377, 31);
            txtCargo.TabIndex = 25;
            txtCargo.TextChanged += txtCargo_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(684, 532);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(60, 25);
            label1.TabIndex = 24;
            label1.Text = "Cargo";
            // 
            // rBtnMasculino
            // 
            rBtnMasculino.AutoSize = true;
            rBtnMasculino.Location = new Point(122, 631);
            rBtnMasculino.Name = "rBtnMasculino";
            rBtnMasculino.Size = new Size(109, 29);
            rBtnMasculino.TabIndex = 26;
            rBtnMasculino.TabStop = true;
            rBtnMasculino.Text = "Maculino";
            rBtnMasculino.UseVisualStyleBackColor = true;
            rBtnMasculino.CheckedChanged += rBtnMasculino_CheckedChanged;
            // 
            // rBtnFeminina
            // 
            rBtnFeminina.AutoSize = true;
            rBtnFeminina.Location = new Point(241, 632);
            rBtnFeminina.Name = "rBtnFeminina";
            rBtnFeminina.Size = new Size(108, 29);
            rBtnFeminina.TabIndex = 27;
            rBtnFeminina.TabStop = true;
            rBtnFeminina.Text = "Feminina";
            rBtnFeminina.UseVisualStyleBackColor = true;
            rBtnFeminina.CheckedChanged += rBtnFeminina_CheckedChanged;
            // 
            // UC_Home
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(rBtnFeminina);
            Controls.Add(rBtnMasculino);
            Controls.Add(txtCargo);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(txtCPF);
            Controls.Add(dtpData);
            Controls.Add(txtSalario);
            Controls.Add(txtNome);
            Controls.Add(txtID);
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
            Margin = new Padding(4, 5, 4, 5);
            Name = "UC_Home";
            Size = new Size(1214, 768);
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
        private TextBox txtID;
        private TextBox txtNome;
        private DateTimePicker dtpData;
        private MaskedTextBox txtCPF;
        private TextBox txtSalario;
        private ComboBox comboBox1;
        private TextBox txtCargo;
        private Label label1;
        private RadioButton rBtnMasculino;
        private RadioButton rBtnFeminina;
    }
}
