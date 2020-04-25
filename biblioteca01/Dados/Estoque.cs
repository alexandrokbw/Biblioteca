using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biblioteca01
{
    class Estoque
    {
        OleDbCommand comandoSql = new OleDbCommand();
        StringBuilder sql = new StringBuilder();
        DataTable dadosTabela = new DataTable();

        internal DataTable listarEstoque(int idLivro)
        {
            using (OleDbConnection conectar = new OleDbConnection(Conexao.stringConexao))
            {
                conectar.Open();
                sql.Append(" SELECT tbEstoque.idEstoque,idLivro,quantidade,tbLocal.idLocal,nomeLocal,descricao");
                sql.Append(" FROM tbEstoque,tbLocal");
                sql.Append(" WHERE(tbEstoque.idLivro=@idLivro and tbEstoque.idLocal=tbLocal.idLocal)");


                comandoSql.Parameters.Add(new OleDbParameter("@idLivro", idLivro));
                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = conectar;
                dadosTabela.Load(comandoSql.ExecuteReader());

                return dadosTabela;
            }

        }
        internal void excluir(int idEstoque)////////////////////////
        {
            using (OleDbConnection conectar = new OleDbConnection(Conexao.stringConexao))
            {
                conectar.Open();
                sql.Append(" DELETE FROM tbEstoque");
                sql.Append(" WHERE(tbEstoque.idEstoque=@idEstoque)");

                comandoSql.Parameters.Add(new OleDbParameter("@idEstoque", idEstoque));

                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = conectar;
                dadosTabela.Load(comandoSql.ExecuteReader());
            }

        }
        

        internal DataTable listarEstoque(string descricao, string nomeLocal)
        {
            using (OleDbConnection conectar = new OleDbConnection(Conexao.stringConexao))
            {
                conectar.Open();
                comandoSql.Parameters.Clear();
                sql.Append(" SELECT tbLivro.nomeLivro,nomeAutor,genero,editora,ano,tombo,tbEstoque.quantidade");
                sql.Append(" FROM ((tbLivro INNER JOIN");
                sql.Append(" tbEstoque ON tbLivro.idLivro = tbEstoque.idLivro) INNER JOIN");
                sql.Append(" tbLocal ON tbEstoque.idLocal = tbLocal.idLocal)");
                sql.Append(" WHERE(tbLocal.descricao = @descricao) AND(tbLocal.nomeLocal = @nomeLocal)");

                comandoSql.Parameters.Add(new OleDbParameter("@descricao", descricao));
                comandoSql.Parameters.Add(new OleDbParameter("@nomeLocal", nomeLocal));
                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = conectar;
                dadosTabela.Load(comandoSql.ExecuteReader());

                return dadosTabela;
            }

        }

        internal void salvarEstoque(int idLocall, int idLivrol,  int quantidadel)
        {
            using (OleDbConnection conectar = new OleDbConnection(Conexao.stringConexao))
            {
                conectar.Open();
                comandoSql.Parameters.Clear();
                sql.Append(" INSERT INTO tbEstoque(idLocal,idLivro,quantidade)");
                sql.Append(" VALUES(@idLocal,@idLivro,@quantidade)");

                comandoSql.Parameters.Add(new OleDbParameter("@idLocal", idLocall));
                comandoSql.Parameters.Add(new OleDbParameter("@idLivro", idLivrol));
                comandoSql.Parameters.Add(new OleDbParameter("@quantidade", quantidadel));

                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = conectar;
                comandoSql.ExecuteNonQuery();
            }
        }

        internal DataTable verificaEstoque(int idLivro,int idLocal)
        {
            using (OleDbConnection conectar = new OleDbConnection(Conexao.stringConexao))
            {
                conectar.Open();

                sql.Append(" SELECT tbEstoque.idEstoque,tbEstoque.idLocal,idLivro,quantidade,tbLocal.nomeLocal");
                sql.Append(" FROM(tbEstoque INNER JOIN");
                sql.Append(" tbLocal ON tbEstoque.idLocal = tbLocal.idLocal)");
                sql.Append(" WHERE(tbEstoque.idLivro = @idLivro AND tbEstoque.idLocal = @idLocal)");
               

                comandoSql.Parameters.Add(new OleDbParameter("@idLivro", idLivro));
                comandoSql.Parameters.Add(new OleDbParameter("@idLocal", idLocal));

                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = conectar;
                dadosTabela.Load(comandoSql.ExecuteReader());

                return dadosTabela;
            }
        }

        internal void atualizar(int idEstoque, int quantidade)//atualiza ou apaga 
        {
            using (OleDbConnection conectar = new OleDbConnection(Conexao.stringConexao))
            {
                conectar.Open();
                if (quantidade==0)
                {
                    sql.Append(" DELETE FROM tbEstoque");
                    sql.Append(" WHERE(idEstoque=@idEstoque)");
                    comandoSql.Parameters.Add(new OleDbParameter("@idEstoque", idEstoque));
                }
                else
                {
                    sql.Append(" UPDATE tbEstoque");
                    sql.Append(" SET quantidade = @quantidade");
                    sql.Append(" WHERE(idEstoque=@idEstoque)");
                    comandoSql.Parameters.Add(new OleDbParameter("@quantidade", quantidade));
                    comandoSql.Parameters.Add(new OleDbParameter("@idEstoque", idEstoque));
                }
                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = conectar;
                comandoSql.ExecuteNonQuery();
            }
        }

        internal DataTable verificalocal(int idLocal)
        {
            using (OleDbConnection conectar = new OleDbConnection(Conexao.stringConexao))
            {
                conectar.Open();
                sql.Append(" SELECT tbEstoque.idLocal");
                sql.Append(" FROM tbEstoque");
                sql.Append(" WHERE(tbEstoque.idLocal=@idLocal)");


                comandoSql.Parameters.Add(new OleDbParameter("@idLocal", idLocal));
                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = conectar;
                dadosTabela.Load(comandoSql.ExecuteReader());

                return dadosTabela;
            }
        }

        internal DataTable listarLocalLivro(int idLivro)
        {
            using (OleDbConnection conectar = new OleDbConnection(Conexao.stringConexao))
            {
                conectar.Open();
                comandoSql.Parameters.Clear();
                sql.Append(" SELECT tbLocal.idLocal, tbLocal.descricao, tbLocal.nomeLocal, tbEstoque.idLivro,idEstoque,quantidade");
                sql.Append(" FROM(tbEstoque INNER JOIN tbLocal ON tbEstoque.idLocal = tbLocal.idLocal)");
                sql.Append(" WHERE(tbEstoque.idLivro = @idLivro AND tbLocal.Permisao = true)");

                comandoSql.Parameters.Add(new OleDbParameter("@idLivro", idLivro));
                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = conectar;
                dadosTabela.Load(comandoSql.ExecuteReader());

                return dadosTabela;
            }
        }

    }
}
