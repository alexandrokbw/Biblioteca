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
    public partial class frmPrateleiras : Form
    {
        public frmPrateleiras()
        {
            InitializeComponent();
        }
        Local novoLocal;
        Estoque novoEstoque;
        DataTable dadosTabela;
        int idLocal;
        string nomeLocal1, descricao1;
        private void frmPrateleiras_Load(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
            listarGrupo();
            listarLocal();
          
        }

        private void listarLocal()
        {
           
            dadosTabela = new DataTable();
            novoLocal = new Local();
            dadosTabela = novoLocal.listarLocal();
            dtgLocais.DataSource = dadosTabela;

            novoLocal = new Local();
            dadosTabela = novoLocal.listarGrupo();
            comboBox1.DataSource = dadosTabela;
            comboBox1.DisplayMember = "descricao";
        }
        private void listarGrupo()
        {
            dadosTabela = new DataTable();
            novoLocal = new Local();
            dadosTabela = novoLocal.listarGrupo();
            comboGrupo1.DataSource = dadosTabela;
            comboGrupo1.DisplayMember = "descricao";
        }
        private void listarLocal(string descricao)
        {
            dadosTabela = new DataTable();
            novoLocal = new Local();
            dadosTabela = novoLocal.listarLocal(descricao);
            comboLocal1.DataSource = dadosTabela;
            comboLocal1.DisplayMember = "nomeLocal";
        }

        private void comboGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            listarLocal(comboGrupo1.Text);
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
           
           label4.Visible=(checkBox1.Checked) ? false : true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            novoEstoque = new Estoque();
            DataTable dadosTabela = new DataTable();
            dadosTabela=novoEstoque.listarEstoque(comboGrupo1.Text, comboLocal1.Text);
            dtgLivroPrateleira.DataSource = dadosTabela;

        }

        private void button1_Click(object sender, EventArgs e)
        {
                 if (comboBox1.Text != "" && txtNomeLocal.Text!="")//adiciona local ao grupo existente
                 {
                    novoLocal = new Local();
                    novoLocal.salvarLocal(comboBox1.Text, txtNomeLocal.Text, checkBox1.Checked);
                    listarLocal();
                    MessageBox.Show("Salvo!", "Sucesso");
                 }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void txtGrupo_TextChanged(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            //comboBox1.SelectedValue = 0;
            txtNomeLocal.Clear();
            idLocal = 0;
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            txtGrupo.Text = "";
        }

        private void dtgLocais_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           comboBox1.Text= descricao1= dtgLocais.CurrentRow.Cells["descricao"].Value.ToString();
           txtNomeLocal.Text= nomeLocal1= dtgLocais.CurrentRow.Cells["nomeLocal"].Value.ToString();
           idLocal = Convert.ToInt32(dtgLocais.CurrentRow.Cells["idLocal1"].Value);
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dadosTabela = new DataTable();
            novoLocal = new Local();
            dadosTabela = novoLocal.listarLocal(txtGrupo.Text);

            if (dadosTabela.Rows.Count > 0)
            {
                MessageBox.Show("Ja existe um grupo chamado \n" + dadosTabela.Rows[0]["descricao"].ToString(), "Ops,");
            }
            else if (txtNomeLocal.Text != "" && idLocal == 0)//Salva um grupo e um novo local
            {
                novoLocal = new Local();
                novoLocal.salvarLocal(txtGrupo.Text, txtNomeLocal.Text, checkBox1.Checked);
                listarLocal();
                limpar();
                MessageBox.Show("Um novo grupo foi adicionado","Sucesso");
            }
        }

        private void limpar()
        {
            txtNomeLocal.Clear();
            txtGrupo.Clear();
            comboBox1.Text = "";
            idLocal = 0;
        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listarLocal();
        }

        private void button3_Click(object sender, EventArgs e)
        { 
            if (idLocal>0)
            {
                novoEstoque = new Estoque();
                dadosTabela = new DataTable();
                dadosTabela = novoEstoque.verificalocal(idLocal);
                if (dadosTabela.Rows.Count==0)
                {
                    novoLocal = new Local();
                    novoLocal.excluirLocal(idLocal);
                    listarLocal();
                    limpar();
                    MessageBox.Show("Excluido", "Sucesso");
                }
                else
                {
                    MessageBox.Show("Locais que possuem livros armazenados,\n nao podem ser excluidos !", "Ops");
                }
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
             if (comboLocal1.Text != "" && txtNomeLocal.Text != "" && idLocal > 0)
             {
                novoLocal = new Local();
                novoLocal.atualizarLocal(idLocal, txtNomeLocal.Text,checkBox1.Checked);
                listarLocal();
                MessageBox.Show("Atualizado!", "Sucesso");
            }
        }
    }
}
