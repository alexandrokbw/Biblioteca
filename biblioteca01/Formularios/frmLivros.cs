using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biblioteca01
{
    public partial class frmLivros : Form
    {
        public frmLivros()
        {
            InitializeComponent();
        }

        Estoque novoEstoque;
        Local novoLocal;
        Livro novoLivro;
        DataTable dadosTabela;
        int idEstoquel, idLivrol, idLocall, quantidadel,nSoma = 0;
       


        private void listarLivro()
        {
            DataTable dadosTabela = new DataTable();
            novoLivro = new Livro();
            dadosTabela = novoLivro.listarLivro();
            dtgLivro.DataSource = dadosTabela;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            novoLivro = new Livro();
            if (idLivrol == 0)
            {
                novoLivro.salvar(txtNome.Text, txtNomeAltor.Text,
                txtGenero.Text, txtEditora.Text, txtAno.Text, txtTombo.Text);
                MessageBox.Show("Salvo","Sucesso!");
            }
            else
            {
                novoLivro.atualizar(idLivrol, txtNome.Text, txtNomeAltor.Text,
                txtGenero.Text, txtEditora.Text, txtAno.Text, txtTombo.Text);
                MessageBox.Show("Atualizado","Sucesso!");
            }
            limpar();
            listarLivro();
        }

        private void dtgLivro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idEstoquel = 0;
            comboGrupo.Enabled = true;
            combolocal.Enabled = true;
            txtQuantidade.Text = "0";
            lblGrupo.Text="";
            lblOrigem.Text = "";
            txtNome.Text = dtgLivro["nomeLivro", dtgLivro.CurrentRow.Index].Value.ToString();
            txtNomeAltor.Text = dtgLivro.CurrentRow.Cells["nomeAutor"].Value.ToString();
            txtGenero.Text = dtgLivro.CurrentRow.Cells["genero"].Value.ToString();
            txtEditora.Text = dtgLivro.CurrentRow.Cells["editora"].Value.ToString();
            txtAno.Text = dtgLivro.CurrentRow.Cells["ano"].Value.ToString();
            txtTombo.Text = dtgLivro.CurrentRow.Cells["tombo"].Value.ToString();
            idLivrol = Convert.ToInt32(dtgLivro.CurrentRow.Cells["idLivro"].Value);
            listarEstoque();
        }

        private void listarEstoque()
        {
            DataTable dadosTabela = new DataTable();
            novoEstoque = new Estoque();
            dadosTabela = novoEstoque.listarEstoque(idLivrol);
            dtgEstoque.DataSource = dadosTabela;
            nSoma = 0;
            foreach (DataRow oLinha in dadosTabela.Rows)
            nSoma += Convert.ToInt32(oLinha["quantidade"].ToString());
            lblQuantidade.Text = "Quantidade: "+ nSoma.ToString();
        }

        private void frmLivros_Load(object sender, EventArgs e)
        {
            listarLivro();
           
        }

        private void listarGrupo()
        {
            dadosTabela = new DataTable();
            novoLocal = new Local();
            dadosTabela = novoLocal.listarGrupo();
            comboGrupo.DataSource = dadosTabela;
            comboGrupo.DisplayMember = "descricao";
           

        }
        private void listarLocal(string descricao)
        {
            dadosTabela = new DataTable();
            novoLocal = new Local();
            dadosTabela = novoLocal.listarLocal(descricao);
            combolocal.DataSource = dadosTabela;
            combolocal.DisplayMember = "nomeLocal";
            combolocal.ValueMember= "idLocal";
            

        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void limpar()
        {

            txtNome.Clear();
            txtNomeAltor.Clear();
            txtGenero.Clear();
            txtEditora.Clear();
            txtAno.Clear();
            txtTombo.Clear();
            idLivrol = 0;
            lblQuantidade.Text = "";
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (idLivrol > 0)
            {
                //Emprestimo novoEmprestimo = new Emprestimo();
                //dadosTabela = new DataTable();
                //dadosTabela = novoEmprestimo.listarEmprestimo(idLivrol);
                if ( nSoma > 0) 
                {
                    MessageBox.Show("Este livro nao pode ser excluido !", "Ops,");
                }
                else
                {
                    if (MessageBox.Show("Deseja realmente excluir ?", "Excluindo...", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        novoLivro = new Livro();
                        novoLivro.excluir(idLivrol,true);
                        MessageBox.Show("Excluido", "Sucesso!");
                    }
                    limpar();
                    listarLivro();
                }
                
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmPrateleiras novaPrateleira = new frmPrateleiras();
            novaPrateleira.ShowDialog();
        }

        private void dtgEstoque_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            comboGrupo.Text = "";
            combolocal.Text = "";
            comboGrupo.Enabled = false;
            combolocal.Enabled = false;
            if (dtgEstoque.Rows.Count>0)
            {
                lblGrupo.Text = dtgEstoque["descricao", dtgEstoque.CurrentRow.Index].Value.ToString();
                lblOrigem.Text = dtgEstoque["nomeLocal", dtgEstoque.CurrentRow.Index].Value.ToString();
                txtQuantidade.Text = dtgEstoque["quantidade", dtgEstoque.CurrentRow.Index].Value.ToString();
                quantidadel=Convert.ToInt32(dtgEstoque["quantidade", dtgEstoque.CurrentRow.Index].Value);
                idEstoquel= Convert.ToInt32(dtgEstoque["idEstoque", dtgEstoque.CurrentRow.Index].Value);
            }
           
        }

        private void panel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
                novoLivro = new Livro();
                dadosTabela = new DataTable();
                if (comboPesquisa.Text == "Nome")
                {
                    dadosTabela = novoLivro.listarLivro(txtPesquisa.Text, "nomeLivro");
                    dtgLivro.DataSource = dadosTabela;
               
                }
                else if (comboPesquisa.Text == "Autor")
                {
                    dadosTabela = novoLivro.listarLivro(txtPesquisa.Text, "Autor");
                    dtgLivro.DataSource = dadosTabela;
                }
                else if (comboPesquisa.Text == "Genero")
                {
                    dadosTabela = novoLivro.listarLivro(txtPesquisa.Text, "Genero");
                    dtgLivro.DataSource = dadosTabela;
                }
                else if (comboPesquisa.Text == "Editora")
                {
                    dadosTabela = novoLivro.listarLivro(txtPesquisa.Text, "Editora");
                    dtgLivro.DataSource = dadosTabela;
                }
                else if (comboPesquisa.Text == "Ano")
                {
                    dadosTabela = novoLivro.listarLivro(txtPesquisa.Text, "Ano");
                    dtgLivro.DataSource = dadosTabela;
                }
                else if (comboPesquisa.Text == "Tombo")
                {
                    dadosTabela = novoLivro.listarLivro(txtPesquisa.Text, "Tombo");
                    dtgLivro.DataSource = dadosTabela;
                }
            else if (comboPesquisa.Text == "Todos")
            {
                txtPesquisa.Clear();
                listarLivro();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmLivros_Activated(object sender, EventArgs e)
        {
            listarGrupo();
        }

        private void comboGrupo_SelectedValueChanged(object sender, EventArgs e)
        {
            listarLocal(comboGrupo.Text);
        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            if (idEstoquel>0)
            {
                if (Convert.ToInt32(txtQuantidade.Text)>0)
                {
                    novoEstoque = new Estoque();
                    novoEstoque.atualizar(idEstoquel, Convert.ToInt32(txtQuantidade.Text));
                    listarEstoque();
                }
				else	
				{
					novoEstoque = new Estoque();
                    novoEstoque.excluir(idEstoquel);
                    listarEstoque();
				}
            }
            else
            {
                if (Convert.ToInt32(txtQuantidade.Text) > 0 && idLocall > 0 && idLivrol > 0) 
                {
                   DataTable dadosTabela = new DataTable();
                   novoEstoque = new Estoque();
                   dadosTabela = novoEstoque.verificaEstoque(idLivrol, idLocall);
				   if(dadosTabela.Rows.Count>0)
				   {
					   novoEstoque = new Estoque();
                       novoEstoque.atualizar(Convert.ToInt32(dadosTabela.Rows[0]["idEstoque"]), Convert.ToInt32(txtQuantidade.Text)+ Convert.ToInt32(dadosTabela.Rows[0]["quantidade"]));
                       listarEstoque();
				   }
				   else
				   {
					   novoEstoque = new Estoque();
                       novoEstoque.salvarEstoque(idLocall,idLivrol, Convert.ToInt32(txtQuantidade.Text));
                       listarEstoque();
				   }
                }
            }
            txtQuantidade.Text="0";combolocal.Text = "";comboGrupo.Text = "";lblGrupo.Text = "-";lblOrigem.Text = "-";
        }

        private void combolocal_SelectedIndexChanged(object sender, EventArgs e)
        {
           idLocall=Convert.ToInt32(combolocal.SelectedValue);
        }
    }
}
