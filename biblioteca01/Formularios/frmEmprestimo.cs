using System;
using System.Data;
using System.Windows.Forms;

namespace biblioteca01
{
    public partial class frmEmprestimo : Form
    {
        public frmEmprestimo()
        {
            InitializeComponent();
        }
        Emprestimo novoEmprestimo;
        DataTable dadosTabela;
        Estoque novoEstoque;
        Usuario usuario;
        Livro livro;
        

         public int idUsuario, idLivro, idLivro2, idLocal2, idLocal,idEmprestimo, idEstoque;
         public string nomeAluno, NomeLivro, Genero, salaAluno;
         public DateTime dataSaida;

        private void frmEmprestimo_Load(object sender, EventArgs e)
        {
            comboLocal.ValueMember = "0";
            listarLivros();
            listarUsuarios();
            if (idEmprestimo != 0)
            {
                txtNomeUsuario.Text = nomeAluno;
                txtNomeLivro.Text = NomeLivro;
                txtAnoUsuario.Text =salaAluno;
                txtGenero.Text = Genero;
                btnDevoluicao.Enabled = true;
            }
            
        }
       
        private void listarUsuarios()
        {
            usuario = new Usuario();
            dadosTabela = new DataTable();
            dadosTabela = usuario.listarUsuario();
            dtgUsuario.DataSource = dadosTabela;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (idLivro2!=0)
            {
                MessageBox.Show("Voce deve salvar as alteracões para proseguir","Ops!");
            }
            else
            {
                idLivro = (idLivro2>0) ? idLivro2 : idLivro;
                novoEstoque = new Estoque();
                dadosTabela = new DataTable();
                dadosTabela= novoEstoque.verificaEstoque(idLivro, idLocal);
                if (dadosTabela.Rows.Count > 0) //Se ja hover o mesmo livro no local
                {
                    int quant = Convert.ToInt32(dadosTabela.Rows[0]["quantidade"]);
                    int idEst = Convert.ToInt32(dadosTabela.Rows[0]["idEstoque"]);

                    novoEstoque = new Estoque();
                    novoEstoque.atualizar(idEst, quant + 1); //O liro se soma com o que ja existe no local
                }
                else
                {
                    novoEstoque = new Estoque();
                    novoEstoque.salvarEstoque(idLocal, idLivro, 1); //Se nao o livro e inserido no local
                }
                Livro novoLivro = new Livro();
                novoLivro.excluir(idLivro, false);
              
                novoEmprestimo = new Emprestimo();
                novoEmprestimo.devolucaoEmprestimo(idEmprestimo, DateTime.Today, idUsuario, idLivro, idLocal,false);
                mensagemDevolucao();
                limpar();
            }
        }

        private void mensagemDevolucao()
        {
           Local novoLocal = new Local();
            dadosTabela = new DataTable();
            dadosTabela = novoLocal.listarLocal(idLocal);
            MessageBox.Show("Emprestimo finalizado\nLivro: " + txtNomeLivro.Text + 
            "\nDeve ser devolvido no local:\n\t"+dadosTabela.Rows[0]["nomeLocal"].ToString()," Devolucão!");
        }

        private void listarLivros()
        {
            livro = new Livro();
            dadosTabela = new DataTable();
            dadosTabela = livro.listarLivro();
            dtglivro.DataSource = dadosTabela;
        }

        private void comboLocal_SelectedIndexChanged(object sender, EventArgs e)
        {
            idLocal2 = Convert.ToInt32(comboLocal.SelectedValue);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            usuario = new Usuario();
            dadosTabela = new DataTable();
            dadosTabela = usuario.listarUsuario(txtPesquisaUsuario.Text);
            dtgUsuario.DataSource = dadosTabela;
        }

        private void frmEmprestimo_Activated(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNomeUsuario.Text = dtgUsuario.CurrentRow.Cells["NOME_USUARIO"].Value.ToString();
            txtAnoUsuario.Text = dtgUsuario.CurrentRow.Cells["USUARIO_ANO"].Value.ToString();
            nomeAluno = dtgUsuario.CurrentRow.Cells["NOME_USUARIO"].Value.ToString();
            idUsuario = Convert.ToInt32(dtgUsuario.CurrentRow.Cells["ID_USUARIO"].Value);
            if (idLocal2==0)
            {
                idLocal2 = idLocal;
            } 

        }

        private void button2_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void limpar()
        {
            comboLocal.Text="";
            lblQuantidade.Text = "";
            btnDevoluicao.Enabled = false;
            txtNomeUsuario.Text = "";
            txtNomeLivro.Text = "";
            txtAnoUsuario.Text = "";
            txtGenero.Text = "";

            idLivro2 = 0;
            idLivro = 0;
            idEmprestimo = 0;
            idUsuario = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (idLocal2 > 0 && idUsuario > 0) 
            {
                novoEmprestimo = new Emprestimo();
                if (idEmprestimo > 0)
                {
                    if (idLivro2>0)//se o usuario altera o livro
                    {
                        novoEmprestimo.atualizaEmprestimo(idEmprestimo, dataSaida, idUsuario, idLivro2, idLocal2);
                        atualizaEstoque();
                        MessageBox.Show(" Atualizado!\n O livro foi substituído ! ", "Atualização...");
                    }
                    else
                    {
                        novoEmprestimo.atualizaEmprestimo(idEmprestimo, dataSaida, idUsuario, idLivro, idLocal);
                        MessageBox.Show("Atualizado!", "Atualização...");
                    }
                   
                }
                else
                {
                    novoEmprestimo.salvarEmprestimo(DateTime.Today,Convert.ToDateTime(txtDevolucao.Text), idUsuario, idLivro2, idLocal2);
                    atualizaEstoque();
                    MessageBox.Show("Salvo!", "Salvando emprestimo...");
                }
                limpar();
            }
            else
            {
                MessageBox.Show(" Informe o nome do Leitor\n o nome do livro \n e o local ! ", "Pode haver campos em branco !");
            }
        }


        private void atualizaEstoque()
        {//Ocorre tanto no salvamento quanto na atualizacao
                int quant, idEst;
                dadosTabela = new DataTable();
                novoEstoque = new Estoque();

                dadosTabela = novoEstoque.verificaEstoque(idLivro2, idLocal2);
                quant = Convert.ToInt32(dadosTabela.Rows[0]["quantidade"]);
                idEst = Convert.ToInt32(dadosTabela.Rows[0]["idEstoque"]);

                novoEstoque = new Estoque();
                novoEstoque.atualizar(idEst,quant-1);//O livro emprestado sai do estoque

            if (idLivro>0)
            {//Ocorre somente na atualizacao
                novoEstoque = new Estoque();
                dadosTabela = new DataTable();
                dadosTabela = novoEstoque.verificaEstoque(idLivro, idLocal);

                if (dadosTabela.Rows.Count > 0) //Se ja hover o mesmo livro no local
                {
                    quant = Convert.ToInt32(dadosTabela.Rows[0]["quantidade"]);
                    idEst = Convert.ToInt32(dadosTabela.Rows[0]["idEstoque"]);

                    novoEstoque = new Estoque();
                    novoEstoque.atualizar(idEst,quant + 1); //O liro se soma com o que ja exste no local
                }
                else
                {
                    novoEstoque = new Estoque();
                    novoEstoque.salvarEstoque(idLocal, idLivro, 1); //Se nao o livro e inserido no local
                }
                Livro novoLivro = new Livro();
                novoLivro.excluir(idLivro, false);
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            livro = new Livro();
            dadosTabela = new DataTable();
            if (radioButton1.Checked && txtPesquisaLivro.Text != "") 
            {
                dadosTabela = livro.listarLivro(txtPesquisaLivro.Text,"nomeLivro");
                dtglivro.DataSource = dadosTabela;
            }
            else if (radioButton2.Checked && txtPesquisaLivro.Text != "")
            {
                dadosTabela = livro.listarLivro(txtPesquisaLivro.Text, "Genero");
                dtglivro.DataSource = dadosTabela;
            }
            else if (radioButton3.Checked && txtPesquisaLivro.Text != "")
            {
                dadosTabela = livro.listarLivro(txtPesquisaLivro.Text, "Autor");
                dtglivro.DataSource = dadosTabela;

            }
            
        }

        private void dtglivro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNomeLivro.Text = dtglivro.CurrentRow.Cells["NOME_LIVRO"].Value.ToString();
            txtGenero.Text = dtglivro.CurrentRow.Cells["GENERO1"].Value.ToString();
            NomeLivro = dtglivro.CurrentRow.Cells["NOME_LIVRO"].Value.ToString();
            idLivro2 = Convert.ToInt16(dtglivro.CurrentRow.Cells["ID_LIVRO"].Value);
            idLocal2 = 0;
            comboLocal.Text = "";
            listarQuantidadeLivro(idLivro2);
            listarLocalLivro(idLivro2);
        }

        private void listarLocalLivro(int idLivro)
        {
                dadosTabela = new DataTable();
                novoEstoque = new Estoque();
                dadosTabela = novoEstoque.listarLocalLivro(idLivro2);
           
                comboLocal.DataSource = dadosTabela;
                comboLocal.DisplayMember = "nomeLocal";
                comboLocal.ValueMember = "idLocal";
        }

        private void listarQuantidadeLivro(int idLivro)
        {
            Livro novoLivro = new Livro();
            DataTable dadosTabela = new DataTable();
            dadosTabela = novoLivro.quantidadeLivro(idLivro2);
            if (dadosTabela.Rows[0]["quantidade"] ==DBNull.Value)
            {
                lblQuantidade.Text = "0";
            }
            else
            {
                lblQuantidade.Text =dadosTabela.Rows[0]["quantidade"].ToString();
              
            }
        }
    }
}
