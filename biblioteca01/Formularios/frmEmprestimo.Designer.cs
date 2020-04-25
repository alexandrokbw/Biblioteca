namespace biblioteca01
{
    partial class frmEmprestimo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmprestimo));
            this.dtglivro = new System.Windows.Forms.DataGridView();
            this.ID_LIVRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.excluido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_livro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genero1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LIVRO_ANO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tombo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgUsuario = new System.Windows.Forms.DataGridView();
            this.ID_USUARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_USUARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USUARIO_ANO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNomeUsuario = new System.Windows.Forms.TextBox();
            this.txtAnoUsuario = new System.Windows.Forms.TextBox();
            this.txtNomeLivro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.txtPesquisaLivro = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button4 = new System.Windows.Forms.Button();
            this.txtPesquisaUsuario = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDevoluicao = new System.Windows.Forms.Button();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboLocal = new System.Windows.Forms.ComboBox();
            this.txtDevolucao = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtglivro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuario)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtglivro
            // 
            this.dtglivro.AllowUserToAddRows = false;
            this.dtglivro.AllowUserToDeleteRows = false;
            this.dtglivro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtglivro.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.dtglivro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtglivro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_LIVRO,
            this.excluido,
            this.nome_livro,
            this.nomeAutor,
            this.genero1,
            this.editora,
            this.LIVRO_ANO,
            this.tombo});
            this.dtglivro.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.dtglivro.Location = new System.Drawing.Point(3, 359);
            this.dtglivro.Name = "dtglivro";
            this.dtglivro.ReadOnly = true;
            this.dtglivro.RowHeadersVisible = false;
            this.dtglivro.Size = new System.Drawing.Size(902, 420);
            this.dtglivro.TabIndex = 0;
            this.dtglivro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtglivro_CellClick);
            // 
            // ID_LIVRO
            // 
            this.ID_LIVRO.DataPropertyName = "idLivro";
            this.ID_LIVRO.HeaderText = "ID_LIVRO";
            this.ID_LIVRO.Name = "ID_LIVRO";
            this.ID_LIVRO.ReadOnly = true;
            this.ID_LIVRO.Visible = false;
            // 
            // excluido
            // 
            this.excluido.DataPropertyName = "excluido";
            this.excluido.HeaderText = "excluido";
            this.excluido.Name = "excluido";
            this.excluido.ReadOnly = true;
            this.excluido.Visible = false;
            // 
            // nome_livro
            // 
            this.nome_livro.DataPropertyName = "nomeLivro";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nome_livro.DefaultCellStyle = dataGridViewCellStyle1;
            this.nome_livro.HeaderText = "nome";
            this.nome_livro.Name = "nome_livro";
            this.nome_livro.ReadOnly = true;
            // 
            // nomeAutor
            // 
            this.nomeAutor.DataPropertyName = "nomeAutor";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nomeAutor.DefaultCellStyle = dataGridViewCellStyle2;
            this.nomeAutor.HeaderText = "autor";
            this.nomeAutor.Name = "nomeAutor";
            this.nomeAutor.ReadOnly = true;
            // 
            // genero1
            // 
            this.genero1.DataPropertyName = "genero";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            this.genero1.DefaultCellStyle = dataGridViewCellStyle3;
            this.genero1.HeaderText = "Genero";
            this.genero1.Name = "genero1";
            this.genero1.ReadOnly = true;
            // 
            // editora
            // 
            this.editora.DataPropertyName = "editora";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.editora.DefaultCellStyle = dataGridViewCellStyle4;
            this.editora.HeaderText = "Editora";
            this.editora.Name = "editora";
            this.editora.ReadOnly = true;
            // 
            // LIVRO_ANO
            // 
            this.LIVRO_ANO.DataPropertyName = "ano";
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LIVRO_ANO.DefaultCellStyle = dataGridViewCellStyle5;
            this.LIVRO_ANO.HeaderText = "Ano";
            this.LIVRO_ANO.Name = "LIVRO_ANO";
            this.LIVRO_ANO.ReadOnly = true;
            // 
            // tombo
            // 
            this.tombo.DataPropertyName = "tombo";
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tombo.DefaultCellStyle = dataGridViewCellStyle6;
            this.tombo.HeaderText = "Tombo";
            this.tombo.Name = "tombo";
            this.tombo.ReadOnly = true;
            // 
            // dtgUsuario
            // 
            this.dtgUsuario.AllowUserToAddRows = false;
            this.dtgUsuario.AllowUserToDeleteRows = false;
            this.dtgUsuario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.dtgUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_USUARIO,
            this.NOME_USUARIO,
            this.USUARIO_ANO,
            this.Telefone,
            this.senha});
            this.dtgUsuario.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.dtgUsuario.Location = new System.Drawing.Point(616, 36);
            this.dtgUsuario.Name = "dtgUsuario";
            this.dtgUsuario.ReadOnly = true;
            this.dtgUsuario.RowHeadersVisible = false;
            this.dtgUsuario.Size = new System.Drawing.Size(289, 315);
            this.dtgUsuario.TabIndex = 1;
            this.dtgUsuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgUsuario_CellClick);
            // 
            // ID_USUARIO
            // 
            this.ID_USUARIO.DataPropertyName = "IDUSUARIO";
            this.ID_USUARIO.HeaderText = "ID_USUARIO";
            this.ID_USUARIO.Name = "ID_USUARIO";
            this.ID_USUARIO.ReadOnly = true;
            this.ID_USUARIO.Visible = false;
            // 
            // NOME_USUARIO
            // 
            this.NOME_USUARIO.DataPropertyName = "nomeUsuario";
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NOME_USUARIO.DefaultCellStyle = dataGridViewCellStyle7;
            this.NOME_USUARIO.HeaderText = "Nome";
            this.NOME_USUARIO.Name = "NOME_USUARIO";
            this.NOME_USUARIO.ReadOnly = true;
            this.NOME_USUARIO.Width = 130;
            // 
            // USUARIO_ANO
            // 
            this.USUARIO_ANO.DataPropertyName = "endereco";
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.USUARIO_ANO.DefaultCellStyle = dataGridViewCellStyle8;
            this.USUARIO_ANO.HeaderText = "Endereço";
            this.USUARIO_ANO.Name = "USUARIO_ANO";
            this.USUARIO_ANO.ReadOnly = true;
            this.USUARIO_ANO.Width = 180;
            // 
            // Telefone
            // 
            this.Telefone.DataPropertyName = "telefone";
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Telefone.DefaultCellStyle = dataGridViewCellStyle9;
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            this.Telefone.Width = 80;
            // 
            // senha
            // 
            this.senha.DataPropertyName = "senha";
            this.senha.HeaderText = "Senha";
            this.senha.Name = "senha";
            this.senha.ReadOnly = true;
            this.senha.Visible = false;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(62, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNomeUsuario
            // 
            this.txtNomeUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.txtNomeUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeUsuario.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtNomeUsuario.Location = new System.Drawing.Point(12, 31);
            this.txtNomeUsuario.Name = "txtNomeUsuario";
            this.txtNomeUsuario.Size = new System.Drawing.Size(280, 24);
            this.txtNomeUsuario.TabIndex = 3;
            // 
            // txtAnoUsuario
            // 
            this.txtAnoUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.txtAnoUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAnoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnoUsuario.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtAnoUsuario.Location = new System.Drawing.Point(298, 31);
            this.txtAnoUsuario.Name = "txtAnoUsuario";
            this.txtAnoUsuario.Size = new System.Drawing.Size(207, 24);
            this.txtAnoUsuario.TabIndex = 3;
            // 
            // txtNomeLivro
            // 
            this.txtNomeLivro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.txtNomeLivro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeLivro.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtNomeLivro.Location = new System.Drawing.Point(12, 80);
            this.txtNomeLivro.Name = "txtNomeLivro";
            this.txtNomeLivro.Size = new System.Drawing.Size(349, 24);
            this.txtNomeLivro.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(301, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Endereço";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Livro";
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(210, 235);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 36);
            this.button2.TabIndex = 2;
            this.button2.Text = "Novo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtGenero
            // 
            this.txtGenero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.txtGenero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenero.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtGenero.Location = new System.Drawing.Point(10, 145);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(140, 24);
            this.txtGenero.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Genero";
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(302, 17);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(73, 30);
            this.button3.TabIndex = 7;
            this.button3.Text = "Buscar";
            this.button3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtPesquisaLivro
            // 
            this.txtPesquisaLivro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.txtPesquisaLivro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPesquisaLivro.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisaLivro.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtPesquisaLivro.Location = new System.Drawing.Point(8, 21);
            this.txtPesquisaLivro.Name = "txtPesquisaLivro";
            this.txtPesquisaLivro.Size = new System.Drawing.Size(288, 23);
            this.txtPesquisaLivro.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.txtPesquisaLivro);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(37, 285);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(468, 68);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pesquisa";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.radioButton3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.radioButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.radioButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(205, 45);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(53, 19);
            this.radioButton3.TabIndex = 9;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Autor";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.radioButton2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.radioButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.radioButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(102, 45);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(66, 19);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Genero";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.radioButton1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.radioButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.radioButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(11, 45);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(51, 19);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Livro";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.button4.FlatAppearance.BorderSize = 2;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(123, 9);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(73, 24);
            this.button4.TabIndex = 11;
            this.button4.Text = "Buscar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtPesquisaUsuario
            // 
            this.txtPesquisaUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.txtPesquisaUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPesquisaUsuario.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisaUsuario.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtPesquisaUsuario.Location = new System.Drawing.Point(6, 9);
            this.txtPesquisaUsuario.Name = "txtPesquisaUsuario";
            this.txtPesquisaUsuario.Size = new System.Drawing.Size(111, 23);
            this.txtPesquisaUsuario.TabIndex = 12;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtPesquisaUsuario);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Location = new System.Drawing.Point(616, -1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(286, 36);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            // 
            // btnDevoluicao
            // 
            this.btnDevoluicao.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDevoluicao.Enabled = false;
            this.btnDevoluicao.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDevoluicao.FlatAppearance.BorderSize = 2;
            this.btnDevoluicao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevoluicao.Location = new System.Drawing.Point(358, 235);
            this.btnDevoluicao.Name = "btnDevoluicao";
            this.btnDevoluicao.Size = new System.Drawing.Size(127, 36);
            this.btnDevoluicao.TabIndex = 14;
            this.btnDevoluicao.Text = "Devolução";
            this.btnDevoluicao.UseVisualStyleBackColor = true;
            this.btnDevoluicao.Click += new System.EventHandler(this.button5_Click);
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblQuantidade.Location = new System.Drawing.Point(558, 154);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(16, 17);
            this.lblQuantidade.TabIndex = 4;
            this.lblQuantidade.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(480, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Disponivel :";
            // 
            // comboLocal
            // 
            this.comboLocal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.comboLocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboLocal.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.comboLocal.FormattingEnabled = true;
            this.comboLocal.Location = new System.Drawing.Point(171, 145);
            this.comboLocal.Name = "comboLocal";
            this.comboLocal.Size = new System.Drawing.Size(121, 24);
            this.comboLocal.TabIndex = 15;
            this.comboLocal.SelectedIndexChanged += new System.EventHandler(this.comboLocal_SelectedIndexChanged);
            // 
            // txtDevolucao
            // 
            this.txtDevolucao.CalendarMonthBackground = System.Drawing.SystemColors.MenuHighlight;
            this.txtDevolucao.CalendarTitleBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtDevolucao.CalendarTrailingForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtDevolucao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDevolucao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDevolucao.Location = new System.Drawing.Point(317, 146);
            this.txtDevolucao.Name = "txtDevolucao";
            this.txtDevolucao.Size = new System.Drawing.Size(109, 22);
            this.txtDevolucao.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(314, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Data para devolução";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(173, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Local";
            // 
            // frmEmprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(907, 783);
            this.Controls.Add(this.txtDevolucao);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.comboLocal);
            this.Controls.Add(this.btnDevoluicao);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNomeLivro);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.txtAnoUsuario);
            this.Controls.Add(this.txtNomeUsuario);
            this.Controls.Add(this.dtglivro);
            this.Controls.Add(this.dtgUsuario);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEmprestimo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emprestimo";
            this.Activated += new System.EventHandler(this.frmEmprestimo_Activated);
            this.Load += new System.EventHandler(this.frmEmprestimo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtglivro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuario)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtglivro;
        private System.Windows.Forms.DataGridView dtgUsuario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNomeUsuario;
        private System.Windows.Forms.TextBox txtAnoUsuario;
        private System.Windows.Forms.TextBox txtNomeLivro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtPesquisaLivro;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtPesquisaUsuario;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDevoluicao;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboLocal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_USUARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_USUARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn USUARIO_ANO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn senha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_LIVRO;
        private System.Windows.Forms.DataGridViewTextBoxColumn excluido;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_livro;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn genero1;
        private System.Windows.Forms.DataGridViewTextBoxColumn editora;
        private System.Windows.Forms.DataGridViewTextBoxColumn LIVRO_ANO;
        private System.Windows.Forms.DataGridViewTextBoxColumn tombo;
        private System.Windows.Forms.DateTimePicker txtDevolucao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
    }
}