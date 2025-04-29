namespace lista16.UserControls
{
    partial class UC_CadastrarSetor
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
            label2 = new Label();
            lblTitle = new Label();
            btnCancelar = new Button();
            btnListarPnome = new Button();
            btnListarTodos = new Button();
            btnExcluir = new Button();
            btnEditar = new Button();
            txtNome = new TextBox();
            txtID = new TextBox();
            lblNome = new Label();
            btnGravar = new Button();
            txtNomeSetor = new TextBox();
            lblid = new Label();
            lblNomeSetor = new Label();
            dataGrind = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGrind).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(63, 40);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(178, 33);
            label2.TabIndex = 30;
            label2.Text = "Inserir setor";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arial Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(67, 208);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(171, 33);
            lblTitle.TabIndex = 29;
            lblTitle.Text = "Editar setor";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(961, 370);
            btnCancelar.Margin = new Padding(4, 5, 4, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(189, 82);
            btnCancelar.TabIndex = 28;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnListarPnome
            // 
            btnListarPnome.Location = new Point(617, 320);
            btnListarPnome.Margin = new Padding(4, 5, 4, 5);
            btnListarPnome.Name = "btnListarPnome";
            btnListarPnome.Size = new Size(189, 82);
            btnListarPnome.TabIndex = 27;
            btnListarPnome.Text = "Procurar";
            btnListarPnome.UseVisualStyleBackColor = true;
            // 
            // btnListarTodos
            // 
            btnListarTodos.Location = new Point(923, 583);
            btnListarTodos.Margin = new Padding(4, 5, 4, 5);
            btnListarTodos.Name = "btnListarTodos";
            btnListarTodos.Size = new Size(253, 82);
            btnListarTodos.TabIndex = 26;
            btnListarTodos.Text = "Listar todos";
            btnListarTodos.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(961, 277);
            btnExcluir.Margin = new Padding(4, 5, 4, 5);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(189, 82);
            btnExcluir.TabIndex = 25;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(961, 165);
            btnEditar.Margin = new Padding(4, 5, 4, 5);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(189, 82);
            btnEditar.TabIndex = 24;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(214, 117);
            txtNome.Margin = new Padding(4, 5, 4, 5);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(380, 31);
            txtNome.TabIndex = 23;
            // 
            // txtID
            // 
            txtID.Location = new Point(487, 343);
            txtID.Margin = new Padding(4, 5, 4, 5);
            txtID.Name = "txtID";
            txtID.Size = new Size(107, 31);
            txtID.TabIndex = 22;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(71, 120);
            lblNome.Margin = new Padding(4, 0, 4, 0);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(85, 32);
            lblNome.TabIndex = 21;
            lblNome.Text = "Nome:";
            // 
            // btnGravar
            // 
            btnGravar.Location = new Point(961, 73);
            btnGravar.Margin = new Padding(4, 5, 4, 5);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(189, 82);
            btnGravar.TabIndex = 20;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // txtNomeSetor
            // 
            txtNomeSetor.Location = new Point(71, 343);
            txtNomeSetor.Margin = new Padding(4, 5, 4, 5);
            txtNomeSetor.Name = "txtNomeSetor";
            txtNomeSetor.Size = new Size(381, 31);
            txtNomeSetor.TabIndex = 19;
            // 
            // lblid
            // 
            lblid.AutoSize = true;
            lblid.Font = new Font("Segoe UI", 12F);
            lblid.Location = new Point(487, 277);
            lblid.Margin = new Padding(4, 0, 4, 0);
            lblid.Name = "lblid";
            lblid.Size = new Size(42, 32);
            lblid.TabIndex = 18;
            lblid.Text = "ID:";
            // 
            // lblNomeSetor
            // 
            lblNomeSetor.AutoSize = true;
            lblNomeSetor.Font = new Font("Segoe UI", 12F);
            lblNomeSetor.Location = new Point(67, 277);
            lblNomeSetor.Margin = new Padding(4, 0, 4, 0);
            lblNomeSetor.Name = "lblNomeSetor";
            lblNomeSetor.Size = new Size(271, 32);
            lblNomeSetor.TabIndex = 17;
            lblNomeSetor.Text = "Digite o nome do Setor:";
            // 
            // dataGrind
            // 
            dataGrind.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrind.Location = new Point(71, 412);
            dataGrind.Margin = new Padding(4, 5, 4, 5);
            dataGrind.Name = "dataGrind";
            dataGrind.RowHeadersWidth = 62;
            dataGrind.Size = new Size(830, 327);
            dataGrind.TabIndex = 16;
            // 
            // UC_CadastrarSetor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(lblTitle);
            Controls.Add(btnCancelar);
            Controls.Add(btnListarPnome);
            Controls.Add(btnListarTodos);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(txtNome);
            Controls.Add(txtID);
            Controls.Add(lblNome);
            Controls.Add(btnGravar);
            Controls.Add(txtNomeSetor);
            Controls.Add(lblid);
            Controls.Add(lblNomeSetor);
            Controls.Add(dataGrind);
            Margin = new Padding(4, 5, 4, 5);
            Name = "UC_CadastrarSetor";
            Size = new Size(1214, 768);
            ((System.ComponentModel.ISupportInitialize)dataGrind).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label lblTitle;
        private Button btnCancelar;
        private Button btnListarPnome;
        private Button btnListarTodos;
        private Button btnExcluir;
        private Button btnEditar;
        private TextBox txtNome;
        private TextBox txtID;
        private Label lblNome;
        private Button btnGravar;
        private TextBox txtNomeSetor;
        private Label lblid;
        private Label lblNomeSetor;
        private DataGridView dataGrind;
    }
}
