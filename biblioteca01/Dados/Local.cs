using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca01
{
    class Local
    {
        
        OleDbCommand comandoSql = new OleDbCommand();
        StringBuilder sql = new StringBuilder();
        DataTable dadosTabela = new DataTable();
        internal DataTable listarLocal()
        {
            using (OleDbConnection conectar = new OleDbConnection(Conexao.stringConexao))
            {
                conectar.Open();
                sql.Append(" SELECT tbLocal.idLocal,descricao,nomeLocal,permisao");
                sql.Append(" FROM tbLocal");
                sql.Append(" ORDER BY nomeLocal");
                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = conectar;
                dadosTabela.Load(comandoSql.ExecuteReader());

                return dadosTabela;
            }
        }
        internal DataTable listarGrupo()
        {
            using (OleDbConnection conectar = new OleDbConnection(Conexao.stringConexao))
            {
                conectar.Open();
                sql.Append(" SELECT descricao");
                sql.Append(" FROM tbLocal");
                sql.Append(" GROUP BY descricao");

                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = conectar;
                dadosTabela.Load(comandoSql.ExecuteReader());

                return dadosTabela;
            }
        }
        internal DataTable listarLocal(string descricao)
        {
            using (OleDbConnection conectar = new OleDbConnection(Conexao.stringConexao))
            {
                conectar.Open();

                sql.Append(" SELECT idLocal, nomeLocal,descricao,permisao");
                sql.Append(" FROM tbLocal");
                sql.Append(" WHERE(tbLocal.descricao=@descricao)");
                sql.Append(" ORDER BY nomeLocal");

                comandoSql.Parameters.Add(new OleDbParameter("@descricao", descricao));
                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = conectar;
                dadosTabela.Load(comandoSql.ExecuteReader());

                return dadosTabela;
            }

        }

        internal DataTable listarLocal(int idLocal)
        {
            using (OleDbConnection conectar = new OleDbConnection(Conexao.stringConexao))
            {
                conectar.Open();

                sql.Append(" SELECT idLocal, nomeLocal");
                sql.Append(" FROM tbLocal");
                sql.Append(" WHERE(tbLocal.idLocal=@idLocal)");

                comandoSql.Parameters.Add(new OleDbParameter("@idLocal", idLocal));
                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = conectar;
                dadosTabela.Load(comandoSql.ExecuteReader());

                return dadosTabela;
            }

        }

        internal void salvarLocal(string descricao,string nome,bool permisao)
        {
            using (OleDbConnection conectar = new OleDbConnection(Conexao.stringConexao))
            {
                conectar.Open();
                comandoSql.Parameters.Clear();
                sql.Append(" INSERT INTO tbLocal( descricao,nomeLocal,permisao)");
                sql.Append(" VALUES(@nomeLocal, @dscricao,@permisao)");

                comandoSql.Parameters.Add(new OleDbParameter("@descricao", descricao));
                comandoSql.Parameters.Add(new OleDbParameter("@nomeLocal", nome));
                comandoSql.Parameters.Add(new OleDbParameter("@permisao", permisao));


                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = conectar;
                comandoSql.ExecuteNonQuery();
            }
        }

        internal void atualizarLocal(int idLocal, string nomeLocal, bool status)
        {
            using (OleDbConnection conectar = new OleDbConnection(Conexao.stringConexao))
            {
                conectar.Open();
                comandoSql.Parameters.Clear();

                sql.Append(" UPDATE TBLOCAL");
                sql.Append(" SET nomeLocal=@nomeLocal, permisao=@permisao");
                sql.Append(" WHERE(TBLOCAL.idLocal=@idLocal)");

                comandoSql.Parameters.Add(new OleDbParameter("@nomeLocal", nomeLocal));
                comandoSql.Parameters.Add(new OleDbParameter("@status", status));
                comandoSql.Parameters.Add(new OleDbParameter("@idLocal", idLocal));

                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = conectar;
                comandoSql.ExecuteNonQuery();
            }
        }

        internal void excluirLocal(int idLocal)
        {
            using (OleDbConnection conectar = new OleDbConnection(Conexao.stringConexao))
            {
                conectar.Open();
                sql.Append(" DELETE FROM TBLOCAL");
                sql.Append(" WHERE(TBLOCAL.idLocal=@idLocal)");

                comandoSql.Parameters.Add(new OleDbParameter("@idLocal", idLocal));

                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = conectar;
                dadosTabela.Load(comandoSql.ExecuteReader());
            }

        }
    }
}
