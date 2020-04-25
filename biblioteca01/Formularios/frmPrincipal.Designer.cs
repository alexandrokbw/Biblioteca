namespace biblioteca01
{
    partial class frmPrincipal
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle43 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle44 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle45 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle46 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle47 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle48 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle49 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle50 = new System.Windows.Forms.DataGridViewCellStyle();
            AnimatorNS.Animation animation4 = new AnimatorNS.Animation();
            AnimatorNS.Animation animation3 = new AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.dtgEmprestimoTelaPrincipal = new System.Windows.Forms.DataGridView();
            this.nome_livro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeAutor1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prateleira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSaida1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USUARIO_ANO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_EMPRESTIMO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idLocal1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_LIVRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_USUARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabEmprestimo = new System.Windows.Forms.TabPage();
            this.tabDevolucao = new System.Windows.Forms.TabPage();
            this.dtgDevolucao = new System.Windows.Forms.DataGridView();
            this.nomeLeitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeLivro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSaida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGENERO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeLocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTELEFONE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEmprestimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idLocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idLivro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbGenero = new System.Windows.Forms.RadioButton();
            this.rbAutor = new System.Windows.Forms.RadioButton();
            this.rbSaida = new System.Windows.Forms.RadioButton();
            this.rbLeitor = new System.Windows.Forms.RadioButton();
            this.rbLivro = new System.Windows.Forms.RadioButton();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripLblNome = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblNomeCaminhoBanco = new System.Windows.Forms.ToolStripStatusLabel();
            this.paneAnimator = new AnimatorNS.Animator(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnPrateleira1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSair1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAdicionarUsuario1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAdicionarLivros1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEmprestimo1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMenu = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.logoAnimator = new AnimatorNS.Animator(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.btnTodos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmprestimoTelaPrincipal)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabEmprestimo.SuspendLayout();
            this.tabDevolucao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDevolucao)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgEmprestimoTelaPrincipal
            // 
            this.dtgEmprestimoTelaPrincipal.AllowUserToAddRows = false;
            this.dtgEmprestimoTelaPrincipal.AllowUserToDeleteRows = false;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.White;
            this.dtgEmprestimoTelaPrincipal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle26;
            this.dtgEmprestimoTelaPrincipal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgEmprestimoTelaPrincipal.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.dtgEmprestimoTelaPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgEmprestimoTelaPrincipal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgEmprestimoTelaPrincipal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.dtgEmprestimoTelaPrincipal.ColumnHeadersHeight = 30;
            this.dtgEmprestimoTelaPrincipal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nome_livro,
            this.genero,
            this.nomeAutor1,
            this.prateleira,
            this.dataSaida1,
            this.nome_usuario,
            this.telefone,
            this.USUARIO_ANO,
            this.ID_EMPRESTIMO,
            this.idLocal1,
            this.ID_LIVRO,
            this.ID_USUARIO});
            this.logoAnimator.SetDecoration(this.dtgEmprestimoTelaPrincipal, AnimatorNS.DecorationType.None);
            this.paneAnimator.SetDecoration(this.dtgEmprestimoTelaPrincipal, AnimatorNS.DecorationType.None);
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle36.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle36.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgEmprestimoTelaPrincipal.DefaultCellStyle = dataGridViewCellStyle36;
            this.dtgEmprestimoTelaPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgEmprestimoTelaPrincipal.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.dtgEmprestimoTelaPrincipal.Location = new System.Drawing.Point(3, 3);
            this.dtgEmprestimoTelaPrincipal.Name = "dtgEmprestimoTelaPrincipal";
            this.dtgEmprestimoTelaPrincipal.ReadOnly = true;
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle37.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle37.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle37.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle37.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle37.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle37.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgEmprestimoTelaPrincipal.RowHeadersDefaultCellStyle = dataGridViewCellStyle37;
            this.dtgEmprestimoTelaPrincipal.RowHeadersVisible = false;
            dataGridViewCellStyle38.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.dtgEmprestimoTelaPrincipal.RowsDefaultCellStyle = dataGridViewCellStyle38;
            this.dtgEmprestimoTelaPrincipal.Size = new System.Drawing.Size(981, 590);
            this.dtgEmprestimoTelaPrincipal.TabIndex = 2;
            this.dtgEmprestimoTelaPrincipal.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgEmprestimoTelaPrincipal_CellDoubleClick);
            // 
            // nome_livro
            // 
            this.nome_livro.DataPropertyName = "nomeLivro";
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.White;
            this.nome_livro.DefaultCellStyle = dataGridViewCellStyle28;
            this.nome_livro.HeaderText = "livro";
            this.nome_livro.Name = "nome_livro";
            this.nome_livro.ReadOnly = true;
            // 
            // genero
            // 
            this.genero.DataPropertyName = "genero";
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genero.DefaultCellStyle = dataGridViewCellStyle29;
            this.genero.HeaderText = "genero";
            this.genero.Name = "genero";
            this.genero.ReadOnly = true;
            // 
            // nomeAutor1
            // 
            this.nomeAutor1.DataPropertyName = "nomeAutor";
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.White;
            this.nomeAutor1.DefaultCellStyle = dataGridViewCellStyle30;
            this.nomeAutor1.HeaderText = "Autor";
            this.nomeAutor1.Name = "nomeAutor1";
            this.nomeAutor1.ReadOnly = true;
            // 
            // prateleira
            // 
            this.prateleira.DataPropertyName = "nomeLocal";
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.prateleira.DefaultCellStyle = dataGridViewCellStyle31;
            this.prateleira.HeaderText = "prateleira";
            this.prateleira.Name = "prateleira";
            this.prateleira.ReadOnly = true;
            // 
            // dataSaida1
            // 
            this.dataSaida1.DataPropertyName = "dataSaida";
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.dataSaida1.DefaultCellStyle = dataGridViewCellStyle32;
            this.dataSaida1.HeaderText = "Saida";
            this.dataSaida1.Name = "dataSaida1";
            this.dataSaida1.ReadOnly = true;
            // 
            // nome_usuario
            // 
            this.nome_usuario.DataPropertyName = "nomeUsuario";
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.nome_usuario.DefaultCellStyle = dataGridViewCellStyle33;
            this.nome_usuario.HeaderText = "nome";
            this.nome_usuario.Name = "nome_usuario";
            this.nome_usuario.ReadOnly = true;
            // 
            // telefone
            // 
            this.telefone.DataPropertyName = "telefone";
            dataGridViewCellStyle34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.telefone.DefaultCellStyle = dataGridViewCellStyle34;
            this.telefone.HeaderText = "telefone";
            this.telefone.Name = "telefone";
            this.telefone.ReadOnly = true;
            // 
            // USUARIO_ANO
            // 
            this.USUARIO_ANO.DataPropertyName = "endereco";
            dataGridViewCellStyle35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.USUARIO_ANO.DefaultCellStyle = dataGridViewCellStyle35;
            this.USUARIO_ANO.HeaderText = "sala";
            this.USUARIO_ANO.Name = "USUARIO_ANO";
            this.USUARIO_ANO.ReadOnly = true;
            // 
            // ID_EMPRESTIMO
            // 
            this.ID_EMPRESTIMO.DataPropertyName = "IDEMPRESTIMO";
            this.ID_EMPRESTIMO.HeaderText = "ID_EMPRESTIMO";
            this.ID_EMPRESTIMO.Name = "ID_EMPRESTIMO";
            this.ID_EMPRESTIMO.ReadOnly = true;
            this.ID_EMPRESTIMO.Visible = false;
            // 
            // idLocal1
            // 
            this.idLocal1.DataPropertyName = "idLocal";
            this.idLocal1.HeaderText = "ID_lOCAL";
            this.idLocal1.Name = "idLocal1";
            this.idLocal1.ReadOnly = true;
            this.idLocal1.Visible = false;
            // 
            // ID_LIVRO
            // 
            this.ID_LIVRO.DataPropertyName = "IDLIVRO";
            this.ID_LIVRO.HeaderText = "ID_LIVRO";
            this.ID_LIVRO.Name = "ID_LIVRO";
            this.ID_LIVRO.ReadOnly = true;
            this.ID_LIVRO.Visible = false;
            // 
            // ID_USUARIO
            // 
            this.ID_USUARIO.DataPropertyName = "IDUSUARIO";
            this.ID_USUARIO.HeaderText = "ID_USUARIO";
            this.ID_USUARIO.Name = "ID_USUARIO";
            this.ID_USUARIO.ReadOnly = true;
            this.ID_USUARIO.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabEmprestimo);
            this.tabControl1.Controls.Add(this.tabDevolucao);
            this.logoAnimator.SetDecoration(this.tabControl1, AnimatorNS.DecorationType.None);
            this.paneAnimator.SetDecoration(this.tabControl1, AnimatorNS.DecorationType.None);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(235, 121);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(997, 626);
            this.tabControl1.TabIndex = 3;
            // 
            // tabEmprestimo
            // 
            this.tabEmprestimo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabEmprestimo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabEmprestimo.Controls.Add(this.dtgEmprestimoTelaPrincipal);
            this.logoAnimator.SetDecoration(this.tabEmprestimo, AnimatorNS.DecorationType.None);
            this.paneAnimator.SetDecoration(this.tabEmprestimo, AnimatorNS.DecorationType.None);
            this.tabEmprestimo.Location = new System.Drawing.Point(4, 24);
            this.tabEmprestimo.Name = "tabEmprestimo";
            this.tabEmprestimo.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmprestimo.Size = new System.Drawing.Size(989, 598);
            this.tabEmprestimo.TabIndex = 0;
            this.tabEmprestimo.Text = "Emprestimos";
            // 
            // tabDevolucao
            // 
            this.tabDevolucao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabDevolucao.Controls.Add(this.dtgDevolucao);
            this.logoAnimator.SetDecoration(this.tabDevolucao, AnimatorNS.DecorationType.None);
            this.paneAnimator.SetDecoration(this.tabDevolucao, AnimatorNS.DecorationType.None);
            this.tabDevolucao.Location = new System.Drawing.Point(4, 24);
            this.tabDevolucao.Name = "tabDevolucao";
            this.tabDevolucao.Padding = new System.Windows.Forms.Padding(3);
            this.tabDevolucao.Size = new System.Drawing.Size(919, 580);
            this.tabDevolucao.TabIndex = 1;
            this.tabDevolucao.Text = "Devoluções";
            // 
            // dtgDevolucao
            // 
            this.dtgDevolucao.AllowUserToAddRows = false;
            this.dtgDevolucao.AllowUserToDeleteRows = false;
            this.dtgDevolucao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgDevolucao.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtgDevolucao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDevolucao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeLeitor,
            this.nomeLivro,
            this.dataSaida,
            this.dataEntrada,
            this.DGENERO,
            this.nomeLocal,
            this.DTELEFONE,
            this.endereco,
            this.idEmprestimo,
            this.idLocal,
            this.nomeAutor,
            this.idLivro,
            this.idUsuario});
            this.logoAnimator.SetDecoration(this.dtgDevolucao, AnimatorNS.DecorationType.None);
            this.paneAnimator.SetDecoration(this.dtgDevolucao, AnimatorNS.DecorationType.None);
            this.dtgDevolucao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgDevolucao.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.dtgDevolucao.Location = new System.Drawing.Point(3, 3);
            this.dtgDevolucao.Name = "dtgDevolucao";
            this.dtgDevolucao.ReadOnly = true;
            this.dtgDevolucao.RowHeadersVisible = false;
            this.dtgDevolucao.Size = new System.Drawing.Size(913, 574);
            this.dtgDevolucao.TabIndex = 0;
            // 
            // nomeLeitor
            // 
            this.nomeLeitor.DataPropertyName = "nomeUsuario";
            dataGridViewCellStyle39.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nomeLeitor.DefaultCellStyle = dataGridViewCellStyle39;
            this.nomeLeitor.HeaderText = "Leitor";
            this.nomeLeitor.Name = "nomeLeitor";
            this.nomeLeitor.ReadOnly = true;
            // 
            // nomeLivro
            // 
            this.nomeLivro.DataPropertyName = "nomeLivro";
            dataGridViewCellStyle40.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nomeLivro.DefaultCellStyle = dataGridViewCellStyle40;
            this.nomeLivro.HeaderText = "Livro";
            this.nomeLivro.Name = "nomeLivro";
            this.nomeLivro.ReadOnly = true;
            // 
            // dataSaida
            // 
            this.dataSaida.DataPropertyName = "dataSaida";
            dataGridViewCellStyle41.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataSaida.DefaultCellStyle = dataGridViewCellStyle41;
            this.dataSaida.HeaderText = "Data saida";
            this.dataSaida.Name = "dataSaida";
            this.dataSaida.ReadOnly = true;
            // 
            // dataEntrada
            // 
            this.dataEntrada.DataPropertyName = "dataEntrada";
            dataGridViewCellStyle42.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataEntrada.DefaultCellStyle = dataGridViewCellStyle42;
            this.dataEntrada.HeaderText = "Data entrada";
            this.dataEntrada.Name = "dataEntrada";
            this.dataEntrada.ReadOnly = true;
            // 
            // DGENERO
            // 
            this.DGENERO.DataPropertyName = "GENERO";
            dataGridViewCellStyle43.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DGENERO.DefaultCellStyle = dataGridViewCellStyle43;
            this.DGENERO.HeaderText = "Genero";
            this.DGENERO.Name = "DGENERO";
            this.DGENERO.ReadOnly = true;
            // 
            // nomeLocal
            // 
            this.nomeLocal.DataPropertyName = "nomeLocal";
            dataGridViewCellStyle44.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nomeLocal.DefaultCellStyle = dataGridViewCellStyle44;
            this.nomeLocal.HeaderText = "Local";
            this.nomeLocal.Name = "nomeLocal";
            this.nomeLocal.ReadOnly = true;
            // 
            // DTELEFONE
            // 
            this.DTELEFONE.DataPropertyName = "TELEFONE";
            dataGridViewCellStyle45.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DTELEFONE.DefaultCellStyle = dataGridViewCellStyle45;
            this.DTELEFONE.HeaderText = "Telefone";
            this.DTELEFONE.Name = "DTELEFONE";
            this.DTELEFONE.ReadOnly = true;
            // 
            // endereco
            // 
            this.endereco.DataPropertyName = "endereco";
            dataGridViewCellStyle46.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.endereco.DefaultCellStyle = dataGridViewCellStyle46;
            this.endereco.HeaderText = "Endereço";
            this.endereco.Name = "endereco";
            this.endereco.ReadOnly = true;
            // 
            // idEmprestimo
            // 
            this.idEmprestimo.DataPropertyName = "idEmprestimo";
            dataGridViewCellStyle47.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.idEmprestimo.DefaultCellStyle = dataGridViewCellStyle47;
            this.idEmprestimo.HeaderText = "idEmprestimo";
            this.idEmprestimo.Name = "idEmprestimo";
            this.idEmprestimo.ReadOnly = true;
            this.idEmprestimo.Visible = false;
            // 
            // idLocal
            // 
            this.idLocal.DataPropertyName = "idLocal";
            this.idLocal.HeaderText = "idLocal";
            this.idLocal.Name = "idLocal";
            this.idLocal.ReadOnly = true;
            this.idLocal.Visible = false;
            // 
            // nomeAutor
            // 
            this.nomeAutor.DataPropertyName = "nomeAutor";
            dataGridViewCellStyle48.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle48.ForeColor = System.Drawing.Color.White;
            this.nomeAutor.DefaultCellStyle = dataGridViewCellStyle48;
            this.nomeAutor.HeaderText = "Autor";
            this.nomeAutor.Name = "nomeAutor";
            this.nomeAutor.ReadOnly = true;
            // 
            // idLivro
            // 
            this.idLivro.DataPropertyName = "idLivro";
            dataGridViewCellStyle49.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.idLivro.DefaultCellStyle = dataGridViewCellStyle49;
            this.idLivro.HeaderText = "LIVRO";
            this.idLivro.Name = "idLivro";
            this.idLivro.ReadOnly = true;
            this.idLivro.Visible = false;
            // 
            // idUsuario
            // 
            this.idUsuario.DataPropertyName = "idUsuario";
            dataGridViewCellStyle50.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.idUsuario.DefaultCellStyle = dataGridViewCellStyle50;
            this.idUsuario.HeaderText = "idUsuario";
            this.idUsuario.Name = "idUsuario";
            this.idUsuario.ReadOnly = true;
            this.idUsuario.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(100)))));
            this.groupBox1.Controls.Add(this.btnTodos);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.rbGenero);
            this.groupBox1.Controls.Add(this.rbAutor);
            this.groupBox1.Controls.Add(this.rbSaida);
            this.groupBox1.Controls.Add(this.rbLeitor);
            this.groupBox1.Controls.Add(this.rbLivro);
            this.groupBox1.Controls.Add(this.txtPesquisa);
            this.groupBox1.Controls.Add(this.button4);
            this.logoAnimator.SetDecoration(this.groupBox1, AnimatorNS.DecorationType.None);
            this.paneAnimator.SetDecoration(this.groupBox1, AnimatorNS.DecorationType.None);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(397, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(831, 46);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa";
            // 
            // rbGenero
            // 
            this.rbGenero.AutoSize = true;
            this.rbGenero.BackColor = System.Drawing.Color.Transparent;
            this.paneAnimator.SetDecoration(this.rbGenero, AnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.rbGenero, AnimatorNS.DecorationType.None);
            this.rbGenero.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.rbGenero.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.rbGenero.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.rbGenero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.rbGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGenero.Location = new System.Drawing.Point(423, 13);
            this.rbGenero.Name = "rbGenero";
            this.rbGenero.Size = new System.Drawing.Size(69, 20);
            this.rbGenero.TabIndex = 2;
            this.rbGenero.TabStop = true;
            this.rbGenero.Text = "genero";
            this.rbGenero.UseVisualStyleBackColor = false;
            // 
            // rbAutor
            // 
            this.rbAutor.AutoSize = true;
            this.rbAutor.BackColor = System.Drawing.Color.Transparent;
            this.paneAnimator.SetDecoration(this.rbAutor, AnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.rbAutor, AnimatorNS.DecorationType.None);
            this.rbAutor.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.rbAutor.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.rbAutor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.rbAutor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.rbAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAutor.Location = new System.Drawing.Point(580, 13);
            this.rbAutor.Name = "rbAutor";
            this.rbAutor.Size = new System.Drawing.Size(57, 20);
            this.rbAutor.TabIndex = 2;
            this.rbAutor.TabStop = true;
            this.rbAutor.Text = "Autor";
            this.rbAutor.UseVisualStyleBackColor = false;
            // 
            // rbSaida
            // 
            this.rbSaida.AutoSize = true;
            this.rbSaida.BackColor = System.Drawing.Color.Transparent;
            this.paneAnimator.SetDecoration(this.rbSaida, AnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.rbSaida, AnimatorNS.DecorationType.None);
            this.rbSaida.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.rbSaida.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.rbSaida.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.rbSaida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.rbSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSaida.Location = new System.Drawing.Point(506, 13);
            this.rbSaida.Name = "rbSaida";
            this.rbSaida.Size = new System.Drawing.Size(60, 20);
            this.rbSaida.TabIndex = 2;
            this.rbSaida.TabStop = true;
            this.rbSaida.Text = "saida";
            this.rbSaida.UseVisualStyleBackColor = false;
            // 
            // rbLeitor
            // 
            this.rbLeitor.AutoSize = true;
            this.rbLeitor.BackColor = System.Drawing.Color.Transparent;
            this.paneAnimator.SetDecoration(this.rbLeitor, AnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.rbLeitor, AnimatorNS.DecorationType.None);
            this.rbLeitor.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.rbLeitor.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.rbLeitor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.rbLeitor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.rbLeitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLeitor.Location = new System.Drawing.Point(282, 13);
            this.rbLeitor.Name = "rbLeitor";
            this.rbLeitor.Size = new System.Drawing.Size(59, 20);
            this.rbLeitor.TabIndex = 2;
            this.rbLeitor.TabStop = true;
            this.rbLeitor.Text = "Leitor";
            this.rbLeitor.UseVisualStyleBackColor = false;
            // 
            // rbLivro
            // 
            this.rbLivro.AutoSize = true;
            this.rbLivro.BackColor = System.Drawing.Color.Transparent;
            this.paneAnimator.SetDecoration(this.rbLivro, AnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.rbLivro, AnimatorNS.DecorationType.None);
            this.rbLivro.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.rbLivro.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.rbLivro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.rbLivro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.rbLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLivro.Location = new System.Drawing.Point(359, 13);
            this.rbLivro.Name = "rbLivro";
            this.rbLivro.Size = new System.Drawing.Size(51, 20);
            this.rbLivro.TabIndex = 2;
            this.rbLivro.TabStop = true;
            this.rbLivro.Text = "livro";
            this.rbLivro.UseVisualStyleBackColor = false;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.paneAnimator.SetDecoration(this.txtPesquisa, AnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.txtPesquisa, AnimatorNS.DecorationType.None);
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.ForeColor = System.Drawing.Color.Black;
            this.txtPesquisa.Location = new System.Drawing.Point(5, 13);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(165, 22);
            this.txtPesquisa.TabIndex = 1;
            // 
            // button4
            // 
            this.paneAnimator.SetDecoration(this.button4, AnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.button4, AnimatorNS.DecorationType.None);
            this.button4.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(195, 13);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "Buscar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.logoAnimator.SetDecoration(this.statusStrip1, AnimatorNS.DecorationType.None);
            this.paneAnimator.SetDecoration(this.statusStrip1, AnimatorNS.DecorationType.None);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel5,
            this.toolStripStatusLabel1,
            this.toolStripLblNome,
            this.toolStripStatusLabel2,
            this.lblNomeCaminhoBanco});
            this.statusStrip1.Location = new System.Drawing.Point(0, 747);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1232, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Margin = new System.Windows.Forms.Padding(10, 3, 0, 2);
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(37, 17);
            this.toolStripStatusLabel5.Text = "Sobre";
            this.toolStripStatusLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripStatusLabel5.Click += new System.EventHandler(this.toolStripStatusLabel5_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Margin = new System.Windows.Forms.Padding(30, 3, 0, 2);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(53, 17);
            this.toolStripStatusLabel1.Text = "Usuario :";
            // 
            // toolStripLblNome
            // 
            this.toolStripLblNome.Name = "toolStripLblNome";
            this.toolStripLblNome.Size = new System.Drawing.Size(61, 17);
            this.toolStripLblNome.Text = "Alexandro";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Margin = new System.Windows.Forms.Padding(30, 3, 0, 2);
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(163, 17);
            this.toolStripStatusLabel2.Text = "Diretorio do Banco de dados :";
            this.toolStripStatusLabel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStripStatusLabel2_MouseDown);
            this.toolStripStatusLabel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.toolStripStatusLabel2_MouseUp);
            // 
            // lblNomeCaminhoBanco
            // 
            this.lblNomeCaminhoBanco.Margin = new System.Windows.Forms.Padding(20, 3, 0, 2);
            this.lblNomeCaminhoBanco.Name = "lblNomeCaminhoBanco";
            this.lblNomeCaminhoBanco.Size = new System.Drawing.Size(240, 17);
            this.lblNomeCaminhoBanco.Text = "C:\\bancoDeDadosAcces\\bdBiblioteca.accdb";
            this.lblNomeCaminhoBanco.Visible = false;
            // 
            // paneAnimator
            // 
            this.paneAnimator.AnimationType = AnimatorNS.AnimationType.Particles;
            this.paneAnimator.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 1;
            animation4.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 2F;
            animation4.TransparencyCoeff = 0F;
            this.paneAnimator.DefaultAnimation = animation4;
            this.paneAnimator.Interval = 20;
            this.paneAnimator.MaxAnimationTime = 2500;
            this.paneAnimator.TimeStep = 0.1F;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.paneAnimator.SetDecoration(this.pictureBox1, AnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.pictureBox1, AnimatorNS.DecorationType.None);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(235, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(997, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.btnPrateleira1);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuFlatButton1);
            this.bunifuGradientPanel1.Controls.Add(this.btnSair1);
            this.bunifuGradientPanel1.Controls.Add(this.btnAdicionarUsuario1);
            this.bunifuGradientPanel1.Controls.Add(this.btnAdicionarLivros1);
            this.bunifuGradientPanel1.Controls.Add(this.btnEmprestimo1);
            this.bunifuGradientPanel1.Controls.Add(this.btnMenu);
            this.bunifuGradientPanel1.Controls.Add(this.logo);
            this.logoAnimator.SetDecoration(this.bunifuGradientPanel1, AnimatorNS.DecorationType.None);
            this.paneAnimator.SetDecoration(this.bunifuGradientPanel1, AnimatorNS.DecorationType.None);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(80)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(80)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(235, 747);
            this.bunifuGradientPanel1.TabIndex = 6;
            // 
            // btnPrateleira1
            // 
            this.btnPrateleira1.Activecolor = System.Drawing.Color.Transparent;
            this.btnPrateleira1.BackColor = System.Drawing.Color.Transparent;
            this.btnPrateleira1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrateleira1.BorderRadius = 0;
            this.btnPrateleira1.ButtonText = "Prateleiras";
            this.btnPrateleira1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoAnimator.SetDecoration(this.btnPrateleira1, AnimatorNS.DecorationType.None);
            this.paneAnimator.SetDecoration(this.btnPrateleira1, AnimatorNS.DecorationType.None);
            this.btnPrateleira1.DisabledColor = System.Drawing.Color.Gray;
            this.btnPrateleira1.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPrateleira1.Iconimage = global::biblioteca01.Properties.Resources.book;
            this.btnPrateleira1.Iconimage_right = null;
            this.btnPrateleira1.Iconimage_right_Selected = null;
            this.btnPrateleira1.Iconimage_Selected = null;
            this.btnPrateleira1.IconMarginLeft = 0;
            this.btnPrateleira1.IconMarginRight = 0;
            this.btnPrateleira1.IconRightVisible = true;
            this.btnPrateleira1.IconRightZoom = 0D;
            this.btnPrateleira1.IconVisible = true;
            this.btnPrateleira1.IconZoom = 90D;
            this.btnPrateleira1.IsTab = false;
            this.btnPrateleira1.Location = new System.Drawing.Point(2, 420);
            this.btnPrateleira1.Name = "btnPrateleira1";
            this.btnPrateleira1.Normalcolor = System.Drawing.Color.Transparent;
            this.btnPrateleira1.OnHovercolor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPrateleira1.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPrateleira1.selected = false;
            this.btnPrateleira1.Size = new System.Drawing.Size(230, 62);
            this.btnPrateleira1.TabIndex = 3;
            this.btnPrateleira1.Text = "Prateleiras";
            this.btnPrateleira1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPrateleira1.Textcolor = System.Drawing.Color.White;
            this.btnPrateleira1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrateleira1.Click += new System.EventHandler(this.btnPrateleira1_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Resultados";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoAnimator.SetDecoration(this.bunifuFlatButton1, AnimatorNS.DecorationType.None);
            this.paneAnimator.SetDecoration(this.bunifuFlatButton1, AnimatorNS.DecorationType.None);
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = global::biblioteca01.Properties.Resources.rising56761;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(3, 522);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.SystemColors.MenuHighlight;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(230, 62);
            this.bunifuFlatButton1.TabIndex = 3;
            this.bunifuFlatButton1.Text = "Resultados";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.btnSair1_Click);
            // 
            // btnSair1
            // 
            this.btnSair1.Activecolor = System.Drawing.Color.Transparent;
            this.btnSair1.BackColor = System.Drawing.Color.Transparent;
            this.btnSair1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSair1.BorderRadius = 0;
            this.btnSair1.ButtonText = "Sair";
            this.btnSair1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoAnimator.SetDecoration(this.btnSair1, AnimatorNS.DecorationType.None);
            this.paneAnimator.SetDecoration(this.btnSair1, AnimatorNS.DecorationType.None);
            this.btnSair1.DisabledColor = System.Drawing.Color.Gray;
            this.btnSair1.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSair1.Iconimage = global::biblioteca01.Properties.Resources.icon;
            this.btnSair1.Iconimage_right = null;
            this.btnSair1.Iconimage_right_Selected = null;
            this.btnSair1.Iconimage_Selected = null;
            this.btnSair1.IconMarginLeft = 0;
            this.btnSair1.IconMarginRight = 0;
            this.btnSair1.IconRightVisible = true;
            this.btnSair1.IconRightZoom = 0D;
            this.btnSair1.IconVisible = true;
            this.btnSair1.IconZoom = 90D;
            this.btnSair1.IsTab = false;
            this.btnSair1.Location = new System.Drawing.Point(3, 624);
            this.btnSair1.Name = "btnSair1";
            this.btnSair1.Normalcolor = System.Drawing.Color.Transparent;
            this.btnSair1.OnHovercolor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSair1.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSair1.selected = false;
            this.btnSair1.Size = new System.Drawing.Size(230, 62);
            this.btnSair1.TabIndex = 3;
            this.btnSair1.Text = "Sair";
            this.btnSair1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSair1.Textcolor = System.Drawing.Color.White;
            this.btnSair1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair1.Click += new System.EventHandler(this.btnSair1_Click_1);
            // 
            // btnAdicionarUsuario1
            // 
            this.btnAdicionarUsuario1.Activecolor = System.Drawing.Color.Transparent;
            this.btnAdicionarUsuario1.BackColor = System.Drawing.Color.Transparent;
            this.btnAdicionarUsuario1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdicionarUsuario1.BorderRadius = 0;
            this.btnAdicionarUsuario1.ButtonText = "Adicionar usuario";
            this.btnAdicionarUsuario1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoAnimator.SetDecoration(this.btnAdicionarUsuario1, AnimatorNS.DecorationType.None);
            this.paneAnimator.SetDecoration(this.btnAdicionarUsuario1, AnimatorNS.DecorationType.None);
            this.btnAdicionarUsuario1.DisabledColor = System.Drawing.Color.Gray;
            this.btnAdicionarUsuario1.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAdicionarUsuario1.Iconimage = global::biblioteca01.Properties.Resources.man;
            this.btnAdicionarUsuario1.Iconimage_right = null;
            this.btnAdicionarUsuario1.Iconimage_right_Selected = null;
            this.btnAdicionarUsuario1.Iconimage_Selected = null;
            this.btnAdicionarUsuario1.IconMarginLeft = 0;
            this.btnAdicionarUsuario1.IconMarginRight = 0;
            this.btnAdicionarUsuario1.IconRightVisible = true;
            this.btnAdicionarUsuario1.IconRightZoom = 0D;
            this.btnAdicionarUsuario1.IconVisible = true;
            this.btnAdicionarUsuario1.IconZoom = 90D;
            this.btnAdicionarUsuario1.IsTab = false;
            this.btnAdicionarUsuario1.Location = new System.Drawing.Point(2, 318);
            this.btnAdicionarUsuario1.Name = "btnAdicionarUsuario1";
            this.btnAdicionarUsuario1.Normalcolor = System.Drawing.Color.Transparent;
            this.btnAdicionarUsuario1.OnHovercolor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAdicionarUsuario1.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAdicionarUsuario1.selected = false;
            this.btnAdicionarUsuario1.Size = new System.Drawing.Size(230, 62);
            this.btnAdicionarUsuario1.TabIndex = 3;
            this.btnAdicionarUsuario1.Text = "Adicionar usuario";
            this.btnAdicionarUsuario1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdicionarUsuario1.Textcolor = System.Drawing.Color.White;
            this.btnAdicionarUsuario1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarUsuario1.Click += new System.EventHandler(this.btnAdicionarUsuario1_Click);
            // 
            // btnAdicionarLivros1
            // 
            this.btnAdicionarLivros1.Activecolor = System.Drawing.Color.Transparent;
            this.btnAdicionarLivros1.BackColor = System.Drawing.Color.Transparent;
            this.btnAdicionarLivros1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdicionarLivros1.BorderRadius = 0;
            this.btnAdicionarLivros1.ButtonText = "Adicionar livros";
            this.btnAdicionarLivros1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoAnimator.SetDecoration(this.btnAdicionarLivros1, AnimatorNS.DecorationType.None);
            this.paneAnimator.SetDecoration(this.btnAdicionarLivros1, AnimatorNS.DecorationType.None);
            this.btnAdicionarLivros1.DisabledColor = System.Drawing.Color.Gray;
            this.btnAdicionarLivros1.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAdicionarLivros1.Iconimage = global::biblioteca01.Properties.Resources.books;
            this.btnAdicionarLivros1.Iconimage_right = null;
            this.btnAdicionarLivros1.Iconimage_right_Selected = null;
            this.btnAdicionarLivros1.Iconimage_Selected = null;
            this.btnAdicionarLivros1.IconMarginLeft = 0;
            this.btnAdicionarLivros1.IconMarginRight = 0;
            this.btnAdicionarLivros1.IconRightVisible = true;
            this.btnAdicionarLivros1.IconRightZoom = 0D;
            this.btnAdicionarLivros1.IconVisible = true;
            this.btnAdicionarLivros1.IconZoom = 90D;
            this.btnAdicionarLivros1.IsTab = false;
            this.btnAdicionarLivros1.Location = new System.Drawing.Point(2, 216);
            this.btnAdicionarLivros1.Name = "btnAdicionarLivros1";
            this.btnAdicionarLivros1.Normalcolor = System.Drawing.Color.Transparent;
            this.btnAdicionarLivros1.OnHovercolor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAdicionarLivros1.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAdicionarLivros1.selected = false;
            this.btnAdicionarLivros1.Size = new System.Drawing.Size(230, 62);
            this.btnAdicionarLivros1.TabIndex = 3;
            this.btnAdicionarLivros1.Text = "Adicionar livros";
            this.btnAdicionarLivros1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdicionarLivros1.Textcolor = System.Drawing.Color.White;
            this.btnAdicionarLivros1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarLivros1.Click += new System.EventHandler(this.btnAdicionarLivros1_Click);
            // 
            // btnEmprestimo1
            // 
            this.btnEmprestimo1.Activecolor = System.Drawing.Color.Transparent;
            this.btnEmprestimo1.BackColor = System.Drawing.Color.Transparent;
            this.btnEmprestimo1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEmprestimo1.BorderRadius = 0;
            this.btnEmprestimo1.ButtonText = "Emprestimo";
            this.btnEmprestimo1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoAnimator.SetDecoration(this.btnEmprestimo1, AnimatorNS.DecorationType.None);
            this.paneAnimator.SetDecoration(this.btnEmprestimo1, AnimatorNS.DecorationType.None);
            this.btnEmprestimo1.DisabledColor = System.Drawing.Color.Gray;
            this.btnEmprestimo1.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEmprestimo1.Iconimage = global::biblioteca01.Properties.Resources.study;
            this.btnEmprestimo1.Iconimage_right = null;
            this.btnEmprestimo1.Iconimage_right_Selected = null;
            this.btnEmprestimo1.Iconimage_Selected = null;
            this.btnEmprestimo1.IconMarginLeft = 0;
            this.btnEmprestimo1.IconMarginRight = 0;
            this.btnEmprestimo1.IconRightVisible = true;
            this.btnEmprestimo1.IconRightZoom = 0D;
            this.btnEmprestimo1.IconVisible = true;
            this.btnEmprestimo1.IconZoom = 90D;
            this.btnEmprestimo1.IsTab = false;
            this.btnEmprestimo1.Location = new System.Drawing.Point(2, 114);
            this.btnEmprestimo1.Name = "btnEmprestimo1";
            this.btnEmprestimo1.Normalcolor = System.Drawing.Color.Transparent;
            this.btnEmprestimo1.OnHovercolor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEmprestimo1.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEmprestimo1.selected = false;
            this.btnEmprestimo1.Size = new System.Drawing.Size(230, 62);
            this.btnEmprestimo1.TabIndex = 3;
            this.btnEmprestimo1.Text = "Emprestimo";
            this.btnEmprestimo1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEmprestimo1.Textcolor = System.Drawing.Color.White;
            this.btnEmprestimo1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmprestimo1.Click += new System.EventHandler(this.btnEmprestimo1_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.BackgroundImage = global::biblioteca01.Properties.Resources.menu;
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.paneAnimator.SetDecoration(this.btnMenu, AnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.btnMenu, AnimatorNS.DecorationType.None);
            this.btnMenu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.Black;
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnMenu.Location = new System.Drawing.Point(184, 19);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(42, 36);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.paneAnimator.SetDecoration(this.logo, AnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.logo, AnimatorNS.DecorationType.None);
            this.logo.Image = global::biblioteca01.Properties.Resources.logo;
            this.logo.Location = new System.Drawing.Point(7, 2);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(167, 71);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 3;
            this.logo.TabStop = false;
            this.logo.Visible = false;
            // 
            // logoAnimator
            // 
            this.logoAnimator.AnimationType = AnimatorNS.AnimationType.ScaleAndRotate;
            this.logoAnimator.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(30);
            animation3.RotateCoeff = 0.5F;
            animation3.RotateLimit = 0.2F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.logoAnimator.DefaultAnimation = animation3;
            this.logoAnimator.Interval = 20;
            this.logoAnimator.MaxAnimationTime = 2500;
            this.logoAnimator.TimeStep = 0.04F;
            // 
            // button1
            // 
            this.paneAnimator.SetDecoration(this.button1, AnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.button1, AnimatorNS.DecorationType.None);
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(655, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Pendencias";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnTodos
            // 
            this.paneAnimator.SetDecoration(this.btnTodos, AnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.btnTodos, AnimatorNS.DecorationType.None);
            this.btnTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTodos.Location = new System.Drawing.Point(757, 13);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(69, 23);
            this.btnTodos.TabIndex = 3;
            this.btnTodos.Text = "Todos";
            this.btnTodos.UseVisualStyleBackColor = true;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1232, 769);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.statusStrip1);
            this.paneAnimator.SetDecoration(this, AnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this, AnimatorNS.DecorationType.None);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biblioteca";
            this.Activated += new System.EventHandler(this.frmPrincipal_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmprestimoTelaPrincipal)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabEmprestimo.ResumeLayout(false);
            this.tabDevolucao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDevolucao)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dtgEmprestimoTelaPrincipal;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabEmprestimo;
        private System.Windows.Forms.TabPage tabDevolucao;
        private System.Windows.Forms.DataGridView dtgDevolucao;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RadioButton rbGenero;
        private System.Windows.Forms.RadioButton rbAutor;
        private System.Windows.Forms.RadioButton rbSaida;
        private System.Windows.Forms.RadioButton rbLivro;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripLblNome;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel lblNomeCaminhoBanco;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.RadioButton rbLeitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeLeitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeLivro;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataSaida;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGENERO;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeLocal;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTELEFONE;
        private System.Windows.Forms.DataGridViewTextBoxColumn endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmprestimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLocal;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLivro;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button btnMenu;
        private AnimatorNS.Animator logoAnimator;
        private AnimatorNS.Animator paneAnimator;
        private Bunifu.Framework.UI.BunifuFlatButton btnEmprestimo1;
        private Bunifu.Framework.UI.BunifuFlatButton btnAdicionarLivros1;
        private Bunifu.Framework.UI.BunifuFlatButton btnAdicionarUsuario1;
        private Bunifu.Framework.UI.BunifuFlatButton btnPrateleira1;
        private Bunifu.Framework.UI.BunifuFlatButton btnSair1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_livro;
        private System.Windows.Forms.DataGridViewTextBoxColumn genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeAutor1;
        private System.Windows.Forms.DataGridViewTextBoxColumn prateleira;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataSaida1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn USUARIO_ANO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_EMPRESTIMO;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLocal1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_LIVRO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_USUARIO;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnTodos;
    }
}

