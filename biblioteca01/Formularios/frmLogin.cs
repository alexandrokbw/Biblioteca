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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private bool VerificaAcesso()
        {
            Usuario novoUsuario = new Usuario();
            DataTable dadosTabela = new DataTable();
            dadosTabela = novoUsuario.liberaAcesso(txtNome.Text,txtSenha.Text);
            if (dadosTabela.Rows.Count > 0 && dadosTabela.Rows[0][1].ToString() != "") 
            {
                Properties.Settings.Default.usuario = txtNome.Text;
                Properties.Settings.Default.Save();
                return true;
            }
            else
            {
                return false;
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtNome.Text = Properties.Settings.Default.usuario;
            textBox1.Text = Properties.Settings.Default.instituicao;
            if (txtNome.Text=="")
            {
                txtNome.Text = "Nome";
            }
            bunifuThinButton21.Select();
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13&&txtSenha.Text!="")
            {
                if (VerificaAcesso() == true)
                {
                    this. Close();
                }
                else
                {
                    MessageBox.Show("Nome ou senha incorretos!", "Erro");
                }
            }
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (VerificaAcesso() == true)
            {
                this.Close();
            }
            else
            {
                System.Environment.Exit(0);
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

            try
            {
                if (VerificaAcesso() == true)
                {
                    Close();
                }
                else
                {
                    MessageBox.Show("Nome ou senha incorretos!", "Erro");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + "\n\n Arquivo desconhecido! \nErro na conexão com o  banco de dados", "Holve um erro !");
                System.Environment.Exit(0);

            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void txtSenha_Click(object sender, EventArgs e)
        {
            txtSenha.Clear();
            txtSenha.PasswordChar = Convert.ToChar("*");
            txtSenha.ForeColor = Color.LightSkyBlue;
        }

        private void txtNome_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtNome.ForeColor = Color.LightSkyBlue;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && this.Height == 483)
            {
                Properties.Settings.Default.instituicao = string.Format(textBox1.Text);
                Properties.Settings.Default.Save();
                MessageBox.Show("Salvo!");
            }
            this.Height = (this.Height== 365) ? 483 : 365;
            
        }

        private void bunifuImageButton1_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void txtSenha_TabIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void txtSenha_AcceptsTabChanged(object sender, EventArgs e)
        {
            
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            if (txtSenha.Text!="Senha")
            {
               
                txtSenha.PasswordChar = Convert.ToChar("*");
                txtSenha.ForeColor = Color.LightSkyBlue;
            }
        }

        private void label4_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "Database Files|*.accdb";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    Properties.Settings.Default.caminho = dlg.FileName;
                    Properties.Settings.Default.Save();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Holve um erro\n Arquivo desconhecido! ", "Erro !");
                Application.Exit();
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
           
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 && textBox1.Text != "")
            {
                Properties.Settings.Default.instituicao = textBox1.Text;
                Properties.Settings.Default.Save();
                MessageBox.Show("Salvo!");
            }
        }
    }
}
