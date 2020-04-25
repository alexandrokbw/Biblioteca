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
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }
        Usuario novoUsuario;
       
        DataTable dadosTabela;
        int id;
        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            listarUsuario();
        }

        private void dtgUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            txtNome.Text = dtgUsuario.CurrentRow.Cells["NOME_USUARIO"].Value.ToString();
            txtSala.Text = dtgUsuario.CurrentRow.Cells["SALA"].Value.ToString();
            txtSenha.Text = dtgUsuario.CurrentRow.Cells["SENHA"].Value.ToString();
            txtTelefone.Text = dtgUsuario.CurrentRow.Cells["TELEFONE"].Value.ToString();
            id = Convert.ToInt16(dtgUsuario.CurrentRow.Cells["ID_USUARIO"].Value);
            somaEmprestimo(id);
        }

        private void somaEmprestimo(int id)
        {
            dadosTabela = new DataTable();
            novoUsuario = new Usuario();
            dadosTabela = novoUsuario.somaEmprestimo(id, false);
            lblDevolvido.Text = dadosTabela.Rows[0]["idUsuario"].ToString();

            novoUsuario = new Usuario();
            dadosTabela = novoUsuario.somaEmprestimo(id, true);
            lblPendente.Text = dadosTabela.Rows[0]["idUsuario"].ToString();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            novoUsuario = new Usuario();
            if (txtTelefone.Text!=""&& txtNome.Text != "" && txtSala.Text != "")
            {
                if (id == 0)
                {
                    novoUsuario.salavar(txtNome.Text, txtSala.Text, txtTelefone.Text, txtSenha.Text);
                    MessageBox.Show("salvo!", "Sucesso");
                }
                else
                {
                    novoUsuario.atualizar(id, txtNome.Text, txtSala.Text, txtTelefone.Text, txtSenha.Text);
                    MessageBox.Show("Atualizado!", "Sucesso");
                }
                listarUsuario();
                limpar();
            }
            
        }

        private void limpar()
        {
            txtNome.Clear();
            txtSala.Clear();
            txtSenha.Clear();
            txtTelefone.Clear();
            lblDevolvido.Text = "0";
            lblPendente.Text = "0";
            id = 0;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (id > 0 ) 
            {
                if (Convert.ToInt32(lblPendente.Text)>0)
                {
                    if (MessageBox.Show("Deseja realmente excluir ?\nEsse usuario possui livros emprestados", "Excluido...", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        novoUsuario = new Usuario();
                        novoUsuario.statusUsuario(id);
                        MessageBox.Show("Excluido!", "Sucesso");
                    }
                }
                else
                {
                    if (MessageBox.Show("Deseja realmente excluir ?", "Excluido...", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        novoUsuario = new Usuario();
                        novoUsuario.excluir(id);
                        MessageBox.Show("Excluido!", "Sucesso");
                    }
                }
                listarUsuario();
                limpar();
            }
        }

        private void listarUsuario()
        {
            novoUsuario = new Usuario();
            dadosTabela = new DataTable();
            dadosTabela = novoUsuario.listarUsuario();
            dtgUsuario.DataSource = dadosTabela;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            novoUsuario = new Usuario();
            dadosTabela = novoUsuario.listarUsuario(textBox1.Text);
            dtgUsuario.DataSource = dadosTabela;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
