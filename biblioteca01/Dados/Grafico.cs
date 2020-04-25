using System.Data;
using System.Text;
using System.Data.OleDb;
using System;

namespace biblioteca01
{
    class Grafico
    {
        OleDbCommand comandoSql = new OleDbCommand();
        StringBuilder sql = new StringBuilder();
        DataTable dadosTabela = new DataTable();


       
        internal DataTable ListarLivrosMiasEmprestados(DateTime inicio, DateTime fim)
        {
            using (OleDbConnection conectar = new OleDbConnection(Conexao.stringConexao))
            {
                conectar.Open();
                sql.Append(" SELECT COUNT(tbEmprestimo.idLivro) AS Quantidade, tbLivro.nomeLivro AS Livro");
                sql.Append(" FROM(tbEmprestimo INNER JOIN");
                sql.Append(" tbLivro ON tbEmprestimo.idLivro = tbLivro.idLivro)");
                //sql.Append("  WHERE(tbEmprestimo.dataSaida BETWEEN #08/08/2019# AND #25/08/2019#)");
                sql.Append(" WHERE(tbEmprestimo.dataSaida BETWEEN @inicio AND @fim)");

                sql.Append(" GROUP BY tbLivro.nomeLivro");
                sql.Append(" ORDER BY COUNT(tbEmprestimo.idLivro) DESC");

                comandoSql.Parameters.Add(new OleDbParameter("@inicio", inicio.ToShortDateString()));
                comandoSql.Parameters.Add(new OleDbParameter("@fim", fim.ToShortDateString()));

                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = conectar;
                dadosTabela.Load(comandoSql.ExecuteReader());

                return dadosTabela;
            }


        }

        internal DataTable ListarUsuariosMaisLivros(DateTime inicio, DateTime fim)
        {
            using (OleDbConnection conectar = new OleDbConnection(Conexao.stringConexao))
            {
                conectar.Open();
         
                sql.Append(" SELECT COUNT(tbEmprestimo.idUsuario) AS Quantidade, tbUsuario.nomeUsuario AS usuario,tbUsuario.endereco");
                sql.Append(" FROM(tbEmprestimo INNER JOIN");
                sql.Append(" tbUsuario ON tbEmprestimo.idUsuario = tbUsuario.idUsuario)");
                sql.Append(" WHERE(tbEmprestimo.dataSaida BETWEEN @inicio AND @fim)");
                sql.Append(" GROUP BY tbUsuario.nomeUsuario,tbUsuario.endereco");
                sql.Append(" ORDER BY COUNT(tbEmprestimo.idUsuario) DESC");

                comandoSql.Parameters.Add(new OleDbParameter("@inicio", inicio.ToShortDateString()));
                comandoSql.Parameters.Add(new OleDbParameter("@fim", fim.ToShortDateString()));

                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = conectar;
                dadosTabela.Load(comandoSql.ExecuteReader());

                return dadosTabela;
            }

        }
        internal DataTable ListarLivrosEndereco(DateTime inicio, DateTime fim)
        {
            using (OleDbConnection conectar = new OleDbConnection(Conexao.stringConexao))
            {
                conectar.Open();

                sql.Append(" SELECT COUNT(tbEmprestimo.idUsuario) AS Quantidade, tbUsuario.endereco");
                sql.Append(" FROM(tbEmprestimo INNER JOIN");
                sql.Append(" tbUsuario ON tbEmprestimo.idUsuario = tbUsuario.idUsuario)");
                sql.Append(" WHERE(tbEmprestimo.dataSaida BETWEEN @inicio AND @fim)");
                sql.Append(" GROUP BY tbUsuario.endereco");
                sql.Append(" ORDER BY COUNT(tbEmprestimo.idUsuario) DESC");

                comandoSql.Parameters.Add(new OleDbParameter("@inicio", inicio.ToShortDateString()));
                comandoSql.Parameters.Add(new OleDbParameter("@fim", fim.ToShortDateString()));

                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = conectar;
                dadosTabela.Load(comandoSql.ExecuteReader());

                return dadosTabela;
            }

        }
       
    }
}
