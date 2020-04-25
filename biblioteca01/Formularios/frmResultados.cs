using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace biblioteca01.Formularios
{
    public partial class frmResultados : Form
    {
        public frmResultados()
        {
            InitializeComponent();
        }
        Grafico novoGrafico;
        DataTable dadosTabela;

       string[] textoParaImpressao = new string[251];

        private void listar(DataTable dadosTabela)
        {
            limpar();
            if (dadosTabela.Rows.Count > 0)
            {
                grafico02.MaximumValue = Convert.ToInt32(dadosTabela.Rows[0]["Quantidade"]);
                grafico03.MaximumValue = Convert.ToInt32(dadosTabela.Rows[0]["Quantidade"]);
                grafico04.MaximumValue = Convert.ToInt32(dadosTabela.Rows[0]["Quantidade"]);
                grafico01.MaximumValue = Convert.ToInt32(dadosTabela.Rows[0]["Quantidade"]);

                grafico01.Value = Convert.ToInt32(dadosTabela.Rows[0][0]);
                label5.Text = dadosTabela.Rows[0][0].ToString();
                label1.Text = dadosTabela.Rows[0][1].ToString();
            }
            if (dadosTabela.Rows.Count > 1)
            {
                grafico02.Value = Convert.ToInt32(dadosTabela.Rows[1][0]);
                label6.Text = dadosTabela.Rows[1][0].ToString();
                label2.Text = dadosTabela.Rows[1][1].ToString();
            }
            if (dadosTabela.Rows.Count > 2)
            {
                grafico03.Value = Convert.ToInt32(dadosTabela.Rows[2][0]);
                label7.Text = dadosTabela.Rows[2][0].ToString();
                label3.Text = dadosTabela.Rows[2][1].ToString();
            }
            if (dadosTabela.Rows.Count > 3)
            {
                grafico04.Value = Convert.ToInt32(dadosTabela.Rows[3][0]);
                label8.Text = dadosTabela.Rows[3][0].ToString();
                label4.Text = dadosTabela.Rows[3][1].ToString();
            }


        }
        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            limpar();
            novoGrafico = new Grafico(); 
            dadosTabela = new DataTable();
            dadosTabela = novoGrafico.ListarUsuariosMaisLivros(txtDataInicio.Value, txtdataFim.Value);
            listar(dadosTabela);

            textoParaImpressao[0] = string.Format(Properties.Settings.Default.instituicao, Environment.NewLine);
            textoParaImpressao[2] = "_______________________________________________________________";
            textoParaImpressao[3] = "Leitores que emprestaram mais livros de: " + txtDataInicio.Value.ToShortDateString() + " a " + txtdataFim.Value.ToShortDateString();
            textoParaImpressao[4] = "_______________________________________________________________";
            if (dadosTabela.Rows.Count > 0)
            {
                for (int i = 0; i < dadosTabela.Rows.Count; i++)
                {
                    textoParaImpressao[i + 5] = dadosTabela.Rows[i]["Quantidade"].ToString().PadRight(2);
                    textoParaImpressao[i + 5] += " Livro(s)".PadRight(10);
                    textoParaImpressao[i + 5] += dadosTabela.Rows[i]["usuario"].ToString().PadRight(30);
                    textoParaImpressao[i + 5] += dadosTabela.Rows[i]["endereco"].ToString();
                }
            }
        }

        private void frmResultados_Load(object sender, EventArgs e)
        {
           
        }

        private void bunifuGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLivrosMiasEmprestados_Click(object sender, EventArgs e)
        {
            limpar();
            novoGrafico = new Grafico();
            dadosTabela = new DataTable();

           dadosTabela= novoGrafico.ListarLivrosMiasEmprestados(txtDataInicio.Value,txtdataFim.Value);
           listar(dadosTabela);

            textoParaImpressao[0] = string.Format(Properties.Settings.Default.instituicao);
            textoParaImpressao[2] = "___________________________________________________";
            textoParaImpressao[3] = "Livros mais emprestados de: "+txtDataInicio.Value.ToShortDateString()+" a "+txtdataFim.Value.ToShortDateString();
            textoParaImpressao[4] = "___________________________________________________";
            if (dadosTabela.Rows.Count > 0)
            {
                for (int i = 0; i < dadosTabela.Rows.Count; i++)
                {
                    textoParaImpressao[i + 5] = dadosTabela.Rows[i]["Quantidade"].ToString().PadRight(3);
                    textoParaImpressao[i + 5] += dadosTabela.Rows[i]["livro"].ToString().PadRight(40);
                   
                }
            }
        }

        private void limpar()
        {
            grafico01.Value = 0;
            grafico02.Value = 0;
            grafico03.Value = 0;
            grafico04.Value = 0;
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            Array.Clear(textoParaImpressao ,0,251);
        }

        private void bunifuTileButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuTileButton5_Click(object sender, EventArgs e)
        {
            PrintDocument doc = new ImprimirDocumento(textoParaImpressao);
            doc.PrintPage += this.Doc_PrintPage;

            PrintDialog dialogo = new PrintDialog();
            dialogo.Document = doc;

            //  Se o usuário clicar em OK , imprime o documento
            if (dialogo.ShowDialog() == DialogResult.OK)
            {
                if (chkVisualizaImpressao.Checked)
                {
                    PrintPreviewDialog ppdlg = new PrintPreviewDialog();
                    ppdlg.Document = doc;
                    ppdlg.MinimumSize = new System.Drawing.Size(1153, 853);
                    ppdlg.PrintPreviewControl.Zoom = 1f;
                    ppdlg.ShowDialog();
                }
                else
                {
                    doc.Print();
                }
            }
        }

        private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Recupera o documento que enviou este evento.
            ImprimirDocumento doc = (ImprimirDocumento)sender;
            
            // Define a fonte e determina a altura da linha
            using (Font fonte = new Font("Consolas", 14))
            {
                float alturaLinha = fonte.GetHeight(e.Graphics);

                // Cria as variáveis para tratar a posição na página
                float x = e.MarginBounds.Left;
                float y = e.MarginBounds.Top;

                // Incrementa o contador de página para refletir 
                // a página que esta sendo impressa
                doc.NumeroPagina += 1;

                // Imprime toda a informação que cabe na página
                // O laço termina quando a próxima linha 
                // iria passar a borda da margem ou quando não 
                // houve mais linhas a imprimir

                while ((y + alturaLinha) < e.MarginBounds.Bottom &&
                  doc.Offset <= doc.Texto.GetUpperBound(0))
                {
                   
                    e.Graphics.DrawString(doc.Texto[doc.Offset], fonte, Brushes.Black, x, y);


                    // move para a proxima linha
                    doc.Offset += 1;

                    // Move uma linha para baixo (proxima linha)
                    y += alturaLinha;
                }

                if (doc.Offset < doc.Texto.GetUpperBound(0))
                {
                    // Havendo ainda pelo menos mais uma página.
                    // Sinaliza o evento para disparar novamente
                    e.HasMorePages = true;
                }
                else
                {
                    // A impressão terminou
                    doc.Offset = 0;
                }
            }
           
        }

        private void frmResultados_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            limpar();
            novoGrafico = new Grafico();
            dadosTabela = new DataTable();

            dadosTabela = novoGrafico.ListarLivrosEndereco(txtDataInicio.Value, txtdataFim.Value);
            listar(dadosTabela);

            textoParaImpressao[0] = string.Format(Properties.Settings.Default.instituicao);
            textoParaImpressao[2] = "___________________________________________________";
            textoParaImpressao[3] = "Livros mais emprestados por sala de: " + txtDataInicio.Value.ToShortDateString() + " a " + txtdataFim.Value.ToShortDateString();
            textoParaImpressao[4] = "___________________________________________________";
            if (dadosTabela.Rows.Count > 0)
            {
                for (int i = 0; i < dadosTabela.Rows.Count; i++)
                {
                    textoParaImpressao[i + 5] = (i + 1)+"º".ToString().PadRight(4);
                    textoParaImpressao[i + 5] += dadosTabela.Rows[i]["Quantidade"].ToString() + " Livro(s)".PadRight(12);
                    textoParaImpressao[i + 5] += dadosTabela.Rows[i]["endereco"].ToString();
                    textoParaImpressao[i + 6] += "___________________________________________________";
                }
               
            }
        }
    }
}
