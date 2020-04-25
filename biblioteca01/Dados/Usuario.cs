using System.Data;
using System.Text;
using System.Data.OleDb;

namespace biblioteca01
{
    class Usuario
    {
        OleDbCommand comandoSql = new OleDbCommand();
        StringBuilder sql = new StringBuilder();
        DataTable dadosTabela = new DataTable();

        internal DataTable listarUsuario()
        {
            using (OleDbConnection conectar = new OleDbConnection(Conexao.stringConexao))
            {
                conectar.Open();
                sql.Append(" SELECT tbusuario.idUsuario,nomeUsuario,endereco,telefone,senha");
                sql.Append(" FROM tbusuario");
                sql.Append(" WHERE(tbUsuario.excluido=false)");
                sql.Append(" ORDER BY tbusuario.NOMEUSUARIO");
                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = conectar;
                dadosTabela.Load(comandoSql.ExecuteReader());
               
                return dadosTabela;
                
            }
            
        }
        internal DataTable listarUsuario(string nome)
        {
            using (OleDbConnection conectar = new OleDbConnection(Conexao.stringConexao))
            {
                conectar.Open();
                sql.Append(" SELECT tbusuario.idUsuario,nomeUsuario,endereco,telefone,senha");
                sql.Append(" FROM tbusuario");
                sql.Append(" WHERE(tbUsuario.nomeUsuario LIKE '%'+@nomeUsuario+'%')");

                comandoSql.Parameters.Add(new OleDbParameter("@nomeUsuario", nome));
                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = conectar;
                dadosTabela.Load(comandoSql.ExecuteReader());

                return dadosTabela;
            }

        }

        internal DataTable somaEmprestimo(int id, bool v)
        {
            using (OleDbConnection conectar = new OleDbConnection(Conexao.stringConexao))
            {
                conectar.Open();
                sql.Append(" SELECT COUNT(idUsuario) AS idUsuario");
                sql.Append(" FROM tbEmprestimo");
                sql.Append(" WHERE(idUsuario = @idUsuario AND status = @status)");
               
                comandoSql.Parameters.Add(new OleDbParameter("@idUsuario", id));
                comandoSql.Parameters.Add(new OleDbParameter("@status", v));
                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = conectar;
                dadosTabela.Load(comandoSql.ExecuteReader());

                return dadosTabela;
            }

        }

        internal void salavar(string nome, string endereco, string telefone,string senha)
        {
            using (OleDbConnection conectar = new OleDbConnection(Conexao.stringConexao))
            {
                conectar.Open();
                comandoSql.Parameters.Clear();
                sql.Append(" INSERT INTO tbUsuario(nomeUsuario, endereco,telefone,senha)");
                sql.Append(" VALUES(@nomeUsuario, @endereco,@telefone,@senha)");

                comandoSql.Parameters.Add(new OleDbParameter("@nomeUsuario", nome));
                comandoSql.Parameters.Add(new OleDbParameter("@endereco", endereco));
                comandoSql.Parameters.Add(new OleDbParameter("@telefone", telefone));
                comandoSql.Parameters.Add(new OleDbParameter("@senha", senha));
               

                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = conectar;
                comandoSql.ExecuteNonQuery();
            }
        }

        internal DataTable liberaAcesso(string nome, string senha)
        {
            using (OleDbConnection conectar = new OleDbConnection(Conexao.stringConexao))
            {
                conectar.Open();
                sql.Append(" SELECT tbUsuario.nomeUsuario,senha");
                sql.Append(" FROM tbusuario");
                sql.Append(" WHERE(tbUsuario.nomeUsuario=@nomeUsuario AND senha=@senha AND excluido=false)");

                comandoSql.Parameters.Add(new OleDbParameter("@nomeUsuario", nome));
                comandoSql.Parameters.Add(new OleDbParameter("@senha", senha));

                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = conectar;
                dadosTabela.Load(comandoSql.ExecuteReader());

                return dadosTabela;

            }


        }

        internal void atualizar(int id, string nome, string endereco, string telefone, string senha)
        {
            using (OleDbConnection conectar = new OleDbConnection(Conexao.stringConexao))
            {
                conectar.Open();
                comandoSql.Parameters.Clear();

                sql.Append(" UPDATE TBUSUARIO");
                sql.Append(" SET nomeUsuario=@nomeUsuario, endereco=@endereco,telefone=@telefone,senha=@senha");
                sql.Append(" WHERE(tbUsuario.idUsuario=@idUsuario)");

                comandoSql.Parameters.Add(new OleDbParameter("@nomeUsuario", nome));
                comandoSql.Parameters.Add(new OleDbParameter("@endereco", endereco));
                comandoSql.Parameters.Add(new OleDbParameter("@telefone", telefone));
                comandoSql.Parameters.Add(new OleDbParameter("@senha", senha));
                comandoSql.Parameters.Add(new OleDbParameter("@idUsuario", id));

                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = conectar;
                comandoSql.ExecuteNonQuery();
            }
        }

        internal void excluir(int id)
        {
            using (OleDbConnection conectar = new OleDbConnection(Conexao.stringConexao))
            {
                conectar.Open();
                comandoSql.Parameters.Clear();

                sql.Append(" DELETE FROM TBUSUARIO");
                sql.Append(" WHERE(tbUsuario.idUsuario=@idUsuario)");

                comandoSql.Parameters.Add(new OleDbParameter("@idUsuario", id));

                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = conectar;
                comandoSql.ExecuteNonQuery();
            }

        }
        internal void statusUsuario(int idUsuario)
        {
            using (OleDbConnection conectar = new OleDbConnection(Conexao.stringConexao))
            {
                conectar.Open();
                comandoSql.Parameters.Clear();

                sql.Append(" UPDATE TBUSUARIO");
                sql.Append(" SET excluido=true");
                sql.Append(" WHERE(tbUsuario.idUsuario=@idUsuario)");

                comandoSql.Parameters.Add(new OleDbParameter("@idUsuario", idUsuario));
                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = conectar;
                comandoSql.ExecuteNonQuery();
            }

        }
    }
}
