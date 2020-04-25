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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        Emprestimo emprestimno;
        DataTable dadosTabela;

        public void listarEmprestimo()
        {
            emprestimno = new Emprestimo();
            dadosTabela = new DataTable();
            dadosTabela = emprestimno.listarEmprestimo();
            dtgEmprestimoTelaPrincipal.DataSource = dadosTabela;
        }
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                frmLogin novoLogin = new frmLogin();
                novoLogin.ShowDialog();
                listarEmprestimo();
                listarDevolucao();
                toolStripLblNome.Text = Properties.Settings.Default.usuario;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + "\ninstalar AccessDatabaseEngine, pode resolver!", "Erro na conexão com o  banco de dados");
                this.Close();
            }
        }

        private void listarDevolucao()
        {
            emprestimno = new Emprestimo();
            dadosTabela = emprestimno.listarDevolucao();
            dtgDevolucao.DataSource = dadosTabela;
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void dtgEmprestimoTelaPrincipal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmEmprestimo novoEmprestimo = new frmEmprestimo();

            novoEmprestimo.idUsuario = Convert.ToInt16(dtgEmprestimoTelaPrincipal.CurrentRow.Cells["ID_USUARIO"].Value);
            novoEmprestimo.salaAluno = dtgEmprestimoTelaPrincipal.CurrentRow.Cells["USUARIO_ANO"].Value.ToString();
            novoEmprestimo.nomeAluno = dtgEmprestimoTelaPrincipal.CurrentRow.Cells["NOME_USUARIO"].Value.ToString();

            novoEmprestimo.idLivro = Convert.ToInt16(dtgEmprestimoTelaPrincipal.CurrentRow.Cells["ID_LIVRO"].Value);
            novoEmprestimo.NomeLivro = dtgEmprestimoTelaPrincipal.CurrentRow.Cells["NOME_LIVRO"].Value.ToString();
            novoEmprestimo.Genero = dtgEmprestimoTelaPrincipal.CurrentRow.Cells["GENERO"].Value.ToString();
            novoEmprestimo.dataSaida = Convert.ToDateTime(dtgEmprestimoTelaPrincipal.CurrentRow.Cells["DATASAIDA1"].Value);

            novoEmprestimo.idEmprestimo = Convert.ToInt16(dtgEmprestimoTelaPrincipal.CurrentRow.Cells["ID_EMPRESTIMO"].Value);
            novoEmprestimo.idLocal = Convert.ToInt16(dtgEmprestimoTelaPrincipal.CurrentRow.Cells["idLocal1"].Value);

            novoEmprestimo.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void frmPrincipal_Activated(object sender, EventArgs e)
        {
          
            try
            {
                listarEmprestimo();
                listarDevolucao();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + "\ninstalar AccessDatabaseEngine, pode resolver!", "Erro na conexão com o  banco de dados");
                System.Environment.Exit(0);
            }

        }

        private void toolStripStatusLabel5_Click(object sender, EventArgs e)
        {
            frmSobre novoFrm = new frmSobre();
            novoFrm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            emprestimno = new Emprestimo();
            dadosTabela = new DataTable();
            if (tabControl1.SelectedTab == tabDevolucao && txtPesquisa.Text != "")
            {
                if (rbLivro.Checked)
                {
                    dadosTabela = emprestimno.listardevolucao(txtPesquisa.Text, "Livro");
                    dtgDevolucao.DataSource = dadosTabela;
                }
                else if (rbGenero.Checked)
                {
                    dadosTabela = emprestimno.listardevolucao(txtPesquisa.Text, "Genero");
                    dtgDevolucao.DataSource = dadosTabela;
                }
                else if (rbSaida.Checked)
                {
                    dadosTabela = emprestimno.listardevolucao(txtPesquisa.Text, "Saida");
                    dtgDevolucao.DataSource = dadosTabela;
                }
                else if (rbAutor.Checked)
                {
                    dadosTabela = emprestimno.listardevolucao(txtPesquisa.Text, "Autor");
                    dtgDevolucao.DataSource = dadosTabela;
                }
                else if (rbLeitor.Checked)
                {
                    dadosTabela = emprestimno.listardevolucao(txtPesquisa.Text, "Aluno");
                    dtgDevolucao.DataSource = dadosTabela;
                }

            }
        
            else if (tabControl1.SelectedTab == tabEmprestimo && txtPesquisa.Text != "")
            {
                if (rbLivro.Checked)
                {
                    dadosTabela = emprestimno.listarEmprestimo(txtPesquisa.Text, "Livro");
                    dtgEmprestimoTelaPrincipal.DataSource = dadosTabela;
                }
                else if (rbGenero.Checked)
                {
                    dadosTabela = emprestimno.listarEmprestimo(txtPesquisa.Text, "Genero");
                    dtgEmprestimoTelaPrincipal.DataSource = dadosTabela;
                }
                else if (rbSaida.Checked)
                {
                    dadosTabela = emprestimno.listarEmprestimo(txtPesquisa.Text, "Saida");
                    dtgEmprestimoTelaPrincipal.DataSource = dadosTabela;
                }
                else if (rbAutor.Checked)
                {
                    dadosTabela = emprestimno.listarEmprestimo(txtPesquisa.Text, "Autor");
                    dtgEmprestimoTelaPrincipal.DataSource = dadosTabela;
                }
                else if (rbLeitor.Checked)
                {
                    dadosTabela = emprestimno.listarEmprestimo(txtPesquisa.Text, "Aluno");
                    dtgEmprestimoTelaPrincipal.DataSource = dadosTabela;
                }

            }

        }

        private void toolStripStatusLabel6_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel2_MouseDown(object sender, MouseEventArgs e)
        {
            lblNomeCaminhoBanco.Visible = true;
            lblNomeCaminhoBanco.Text = Properties.Settings.Default.caminho.ToString();
        }

        private void toolStripStatusLabel2_MouseUp(object sender, MouseEventArgs e)
        {
            lblNomeCaminhoBanco.Visible = false;
        }

        private void frmPrincipal_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair ?", "Saindo...", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                System.Environment.Exit(0);
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (bunifuGradientPanel1.Width == 70)
            {
               // bunifuGradientPanel1.Visible = false;
                bunifuGradientPanel1.Width = 235;

                paneAnimator.ShowSync(bunifuGradientPanel1);
                logoAnimator.ShowSync(logo);
            }
            else
            {
                logoAnimator.HideSync(logo);
                bunifuGradientPanel1.Visible = false;
                bunifuGradientPanel1.Width = 70;
                paneAnimator.ShowSync(bunifuGradientPanel1);
            }
        }

        private void btnEmprestimo1_Click(object sender, EventArgs e)
        {
            //panel1.BackColor = Color.Red;
            frmEmprestimo novoEmprestimo = new frmEmprestimo();
            novoEmprestimo.ShowDialog();
        }

        private void btnAdicionarLivros1_Click(object sender, EventArgs e)
        {
          //  panel1.BackColor = Color.Red;
            frmLivros novoLivro = new frmLivros();
            novoLivro.ShowDialog();
        }

        private void btnAdicionarUsuario1_Click(object sender, EventArgs e)
        {
          //  panel1.BackColor = Color.Red;
            frmUsuarios novoUsuario = new frmUsuarios();
            novoUsuario.ShowDialog();
        }

        private void btnSair1_Click(object sender, EventArgs e)
        {
          //  panel1.BackColor = Color.Red;
            Formularios.frmResultados graficos = new Formularios.frmResultados();
            graficos.ShowDialog();
        }

        private void btnPrateleira1_Click(object sender, EventArgs e)
        {
            //panel1.BackColor = Color.Red;
            frmPrateleiras novaPrateleira = new frmPrateleiras();
            novaPrateleira.ShowDialog();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSair1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            emprestimno = new Emprestimo();
            dadosTabela = new DataTable();

            dadosTabela = emprestimno.listardevolucao(DateTime.Today);
            dtgEmprestimoTelaPrincipal.DataSource = dadosTabela;
               
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            listarDevolucao();
            listarEmprestimo();
        }
    }
}
