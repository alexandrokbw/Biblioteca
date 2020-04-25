using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace biblioteca01
{
    class Livro
    {
        OleDbCommand comandoSql = new OleDbCommand();
        StringBuilder sql = new StringBuilder();
        DataTable dadosTabela = new DataTable();

        internal DataTable listarLivro()
        {
            using (OleDbConnection conectar = new OleDbConnection(Conexao.stringConexao))
            {
                conectar.Open();
                sql.Append(" SELECT *");
                sql.Append(" FROM TBLIVRO");
                sql.Append(" WHERE(tbLivro.excluido=false)");

                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = conectar;
                dadosTabela.Load(comandoSql.ExecuteReader());
                return dadosTabela;
            }
        }

        internal void salvar(string nomeLivro, string nomeAltor, string genero, string editora, string ano, string tombo)
        {
            using (OleDbConnection conectar = new OleDbConnection(Conexao.stringConexao))
            {
                conectar.Open();
                comandoSql.Parameters.Clear();
                sql.Append(" INSERT INTO tbLivro(nomeLivro,nomeAutor,genero,editora,ano,tombo)");
                sql.Append(" VALUES(@nomeLivro,@nomeAutor,@genero,@editora,@ano,@tombo)");

                comandoSql.Parameters.Add(new OleDbParameter("@nomeLivro", nomeLivro));
                comandoSql.Parameters.Add(new OleDbParameter("@nomeAutor", nomeAltor));
                comandoSql.Parameters.Add(new OleDbParameter("@genero", genero));
                comandoSql.Parameters.Add(new OleDbParameter("@editora", editora));
                comandoSql.Parameters.Add(new OleDbParameter("@ano",ano));
                comandoSql.Parameters.Add(new OleDbParameter("@tombo",tombo));

                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = conectar;
                comandoSql.ExecuteNonQuery();
            }
        }

        internal void atualizar(int id, string nomeLivro, string nomeAutor, string genero, string editora, string ano, string tombo)
        {
            using (OleDbConnection conectar = new OleDbConnection(Conexao.stringConexao))
            {
                conectar.Open();
                comandoSql.Parameters.Clear();

                sql.Append(" UPDATE tbLivro");
                sql.Append(" SET nomeLivro=@nomeLivro,nomeAutor=@nomeAutor,genero=@genero,editora=@editora,ano=@ano,tombo=@tombo,excluido=false");
                sql.Append(" WHERE(tbLivro.idLivro=@idLivro)");

                comandoSql.Parameters.Add(new OleDbParameter("@nomeLivro", nomeLivro));
                comandoSql.Parameters.Add(new OleDbParameter("@nomeAutor", nomeAutor));
                comandoSql.Parameters.Add(new OleDbParameter("@genero", genero));
                comandoSql.Parameters.Add(new OleDbParameter("@editora", editora));
                comandoSql.Parameters.Add(new OleDbParameter("@ano", ano));
                comandoSql.Parameters.Add(new OleDbParameter("@tombo", tombo));
                comandoSql.Parameters.Add(new OleDbParameter("@idLivro", id));

                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = conectar;
                comandoSql.ExecuteNonQuery();
            }
        }

        internal void excluir(int id, bool v)
        {
            using (OleDbConnection conectar = new OleDbConnection(Conexao.stringConexao))
            {
                conectar.Open();
                comandoSql.Parameters.Clear();

                sql.Append(" UPDATE tbLivro");
                if (v==false) { sql.Append(" SET excluido=false"); }
                else { sql.Append(" SET excluido=true"); }
                sql.Append(" WHERE(idLivro=@idLivro)");

                comandoSql.Parameters.Add(new OleDbParameter("@idLivro", id));
                comandoSql.Parameters.Add(new OleDbParameter("@excluido", v));

                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = conectar;
                comandoSql.ExecuteNonQuery();
            }
        }

        internal DataTable quantidadeLivro(int idLivro)
        {
            using (OleDbConnection conectar = new OleDbConnection(Conexao.stringConexao))
            {
                conectar.Open();
                sql.Append(" SELECT SUM(tbEstoque.quantidade) AS quantidade");
                sql.Append(" FROM(tbEstoque INNER JOIN tbLocal ON tbEstoque.idLocal = tbLocal.idLocal)");
                sql.Append(" WHERE(tbEstoque.idLivro = @idLivro) AND(tbLocal.Permisao = true)");

                comandoSql.Parameters.Add(new OleDbParameter("@idLivro", idLivro));
                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = conectar;
                dadosTabela.Load(comandoSql.ExecuteReader());
                return dadosTabela;
            }
        }

        internal  DataTable listarLivro(string pesquisa, string v)
        {
           // System.Windows.Forms.MessageBox.Show(pesquisa, v);
            using (OleDbConnection conectar = new OleDbConnection(Conexao.stringConexao))
                {
                    conectar.Open();
                    sql.Append(" SELECT *");
                    sql.Append(" FROM TBLIVRO");
                if (v == "nomeLivro")
                {
                    sql.Append(" WHERE(TBLIVRO.nomeLivro LIKE '%'+@nomeLivro+'%')");
                    comandoSql.Parameters.Add(new OleDbParameter("@nomeLivro", pesquisa));
                   // System.Windows.Forms.MessageBox.Show(pesquisa, v);
                }
                else if (v=="Autor")
                {
                    sql.Append(" WHERE(TBLIVRO.nomeAutor LIKE '%'+@nomeAutor+'%')");
                    comandoSql.Parameters.Add(new OleDbParameter("@nomeAutor", pesquisa));

                }
                else if (v == "Genero")
                {
                    sql.Append(" WHERE(TBLIVRO.genero LIKE '%'+@genero+'%')");
                    comandoSql.Parameters.Add(new OleDbParameter("@genero", pesquisa));

                }
                if (v == "Editora")
                {
                    sql.Append(" WHERE(TBLIVRO.editora LIKE '%'+@editora+'%')");
                    comandoSql.Parameters.Add(new OleDbParameter("@editora", pesquisa));

                }
                else if (v == "Ano")
                {
                    sql.Append(" WHERE(TBLIVRO.Ano LIKE '%'+@Ano+'%')");
                    comandoSql.Parameters.Add(new OleDbParameter("@Ano", pesquisa));

                }
                else if (v == "Tombo")
                {
                    sql.Append(" WHERE(TBLIVRO.Tombo LIKE '%'+@Tombo+'%')");
                    comandoSql.Parameters.Add(new OleDbParameter("@Tombo", pesquisa));

                }
                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = conectar;
                dadosTabela.Load(comandoSql.ExecuteReader());
                return dadosTabela;
              }
        }

    }
}
