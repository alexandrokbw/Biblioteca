//using System;
//using System.Collections.Generic;
using System.Data;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Data.OleDb;
using System;
using System.Windows.Forms;
//using System.Data;

namespace biblioteca01
{
    class Emprestimo
    {
        OleDbCommand comandoSql = new OleDbCommand();
        StringBuilder sql = new StringBuilder();
        DataTable dadostabela = new DataTable();
        

        internal DataTable listarEmprestimo()
        {
            using (OleDbConnection conectar = new OleDbConnection(Conexao.stringConexao)) 
            {
                conectar.Open();


                sql.Append(" SELECT tbEmprestimo.idEmprestimo,dataSaida, tbLivro.genero, tbUsuario.idUsuario,nomeUsuario,endereco,telefone,");
                sql.Append(" tbLivro.idLivro,nomeLivro,nomeAutor, tbLocal.idLocal,nomeLocal");
                sql.Append(" FROM(((tbEmprestimo INNER JOIN");
                sql.Append(" tbUsuario ON tbEmprestimo.idUsuario = tbUsuario.idUsuario) INNER JOIN");
                sql.Append(" tbLivro ON tbEmprestimo.idLivro = tbLivro.idLivro) INNER JOIN");
                sql.Append(" tbLocal ON tbEmprestimo.idLocal = tbLocal.idLocal)");
                sql.Append(" WHERE(tbEmprestimo.status = TRUE)");
                sql.Append(" ORDER BY tbEmprestimo.dataSaida");

                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = conectar;
                dadostabela.Load(comandoSql.ExecuteReader());
                return dadostabela;
            }
        }
        internal DataTable listarDevolucao()
        {
            using (OleDbConnection conectar = new OleDbConnection(Conexao.stringConexao))
            {
                conectar.Open();

                sql.Append(" SELECT tbEmprestimo.idEmprestimo,dataSaida,dataEntrada, tbLivro.genero, tbUsuario.idUsuario,nomeUsuario,endereco,telefone,");
                sql.Append(" tbLivro.idLivro,nomeLivro,nomeAutor, tbLocal.idLocal,nomeLocal");
                sql.Append(" FROM(((tbEmprestimo INNER JOIN");
                sql.Append(" tbUsuario ON tbEmprestimo.idUsuario = tbUsuario.idUsuario) INNER JOIN");
                sql.Append(" tbLivro ON tbEmprestimo.idLivro = tbLivro.idLivro) INNER JOIN");
                sql.Append(" tbLocal ON tbEmprestimo.idLocal = tbLocal.idLocal)");
                sql.Append(" WHERE(tbEmprestimo.status = FALSE)");
                sql.Append(" ORDER BY tbEmprestimo.dataSaida");


                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = conectar;
                dadostabela.Load(comandoSql.ExecuteReader());
                return dadostabela;
            }
        }

        internal void atualizaEmprestimo(int idEmprestimo, DateTime dataSaida, int idUsuario, int idLivro, int idLocal)
        {
            using (OleDbConnection conectar = new OleDbConnection(Conexao.stringConexao))
            {
                conectar.Open();
                comandoSql.Parameters.Clear();

                sql.Append(" UPDATE TBEMPRESTIMO");
                sql.Append(" SET dataSaida=@dataSaida,idUsuario=@idUsuario,idLivro=@idLivro,idLocal=@idLocal");
                sql.Append(" WHERE(IDEMPRESTIMO=@idEmprestimo)");

                comandoSql.Parameters.Add(new OleDbParameter("@dataSaida", dataSaida));
                comandoSql.Parameters.Add(new OleDbParameter("@idUsuario", idUsuario));
                comandoSql.Parameters.Add(new OleDbParameter("@idLivro", idLivro));
                comandoSql.Parameters.Add(new OleDbParameter("@idLocal", idLocal));


                comandoSql.Parameters.Add(new OleDbParameter("@idEmprestimo", idEmprestimo));

                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = conectar;
                comandoSql.ExecuteNonQuery();
                conectar.Close();
            }
        }

        internal DataTable verificaUsuario(int id)
        {
            using (OleDbConnection conectar = new OleDbConnection(Conexao.stringConexao))
            {
                conectar.Open();

                sql.Append(" SELECT tbEmprestimo.idUsuario");
                sql.Append(" FROM (tbEmprestimo)");
                sql.Append(" WHERE(tbEmprestimo.idUsuario = @idUsuario)");

                comandoSql.Parameters.Add(new OleDbParameter("@idUsuario", id));

                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = conectar;
                dadostabela.Load(comandoSql.ExecuteReader());
                return dadostabela;
            }

        }

        internal void devolucaoEmprestimo(int idEmprestimo, DateTime dataEntrada, int idUsuario, int idLivro, int idLocal,bool status)
        {
            using (OleDbConnection conectar = new OleDbConnection(Conexao.stringConexao))
            {
                conectar.Open();
                comandoSql.Parameters.Clear();

                sql.Append(" UPDATE TBEMPRESTIMO");
                sql.Append(" SET dataEntrada=@dataEntrada,idUsuario=@idUsuario,idLivro=@idLivro,idLocal=@idLocal,status=@status");
                sql.Append(" WHERE(IDEMPRESTIMO=@idEmprestimo)");

                comandoSql.Parameters.Add(new OleDbParameter("@dataEntrada", dataEntrada));
                comandoSql.Parameters.Add(new OleDbParameter("@idUsuario", idUsuario));
                comandoSql.Parameters.Add(new OleDbParameter("@idLivro", idLivro));
                comandoSql.Parameters.Add(new OleDbParameter("@idLocal", idLocal));
                comandoSql.Parameters.Add(new OleDbParameter("@status", status));


                comandoSql.Parameters.Add(new OleDbParameter("@idEmprestimo", idEmprestimo));

                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = conectar;
                comandoSql.ExecuteNonQuery();
                conectar.Close();
            }
        }

        internal DataTable listarEmprestimo(int idLivro)
        {
            using (OleDbConnection conectar = new OleDbConnection(Conexao.stringConexao))
            {
                conectar.Open();

                sql.Append(" SELECT tbEmprestimo.idLivro");
                sql.Append(" FROM (tbEmprestimo)");
                sql.Append(" WHERE(tbEmprestimo.idLivro = @idLivro)");

                comandoSql.Parameters.Add(new OleDbParameter("@idLivro", idLivro));

                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = conectar;
                dadostabela.Load(comandoSql.ExecuteReader());
                return dadostabela;
            }
        }
        internal void salvarEmprestimo(DateTime dataSaida, DateTime dataEntrada,int idUsuario,int idLivro,int idLocal)
        {
            using (OleDbConnection conectar = new OleDbConnection(Conexao.stringConexao))
            {
                conectar.Open();
                comandoSql.Parameters.Clear();
                sql.Append(" INSERT INTO TBEMPRESTIMO(DATASAIDA,DATAENTRADA,IDUSUARIO,IDLIVRO,IDLOCAL,STATUS)");
                sql.Append(" VALUES(@dataSaida,@dataEntrada,@idUsuario,@idLivro,@idLocal,TRUE)");

                comandoSql.Parameters.Add(new OleDbParameter("@dataSaida", dataSaida));
                comandoSql.Parameters.Add(new OleDbParameter("@dataEntrada", dataEntrada));
                comandoSql.Parameters.Add(new OleDbParameter("@idUsuario", idUsuario));
                comandoSql.Parameters.Add(new OleDbParameter("@idLivro", idLivro));
                comandoSql.Parameters.Add(new OleDbParameter("@idLocal", idLocal));

                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = conectar;
                comandoSql.ExecuteNonQuery();
                
            }
           
        }
        internal DataTable listardevolucao(string text, string v)
        {
            using (OleDbConnection conectar = new OleDbConnection(Conexao.stringConexao))
            {
                conectar.Open();
                sql.Append(" SELECT tbEmprestimo.idEmprestimo,dataSaida,dataEntrada,tbLivro.genero, tbUsuario.idUsuario,nomeUsuario,endereco,telefone,");
                sql.Append(" tbLivro.idLivro,nomeLivro,nomeAutor, tbLocal.idLocal,nomeLocal");
                sql.Append(" FROM(((tbEmprestimo INNER JOIN");
                sql.Append(" tbUsuario ON tbEmprestimo.idUsuario = tbUsuario.idUsuario) INNER JOIN");
                sql.Append(" tbLivro ON tbEmprestimo.idLivro = tbLivro.idLivro) INNER JOIN");
                sql.Append(" tbLocal ON tbEmprestimo.idLocal = tbLocal.idLocal)");
                if (v == "Livro")
                {
                    sql.Append(" WHERE(tbEmprestimo.status = FALSE and nomeLivro LIKE '%'+@nomeLivro+'%')");
                    sql.Append(" ORDER BY tbEmprestimo.dataSaida");
                    comandoSql.Parameters.Add(new OleDbParameter("@nomeLivro", text));
                }
                else if (v == "Genero")
                {
                    sql.Append(" WHERE(tbEmprestimo.status = FALSE and genero LIKE '%'+@genero+'%')");
                    sql.Append(" ORDER BY tbEmprestimo.dataSaida");
                    comandoSql.Parameters.Add(new OleDbParameter("@genero", text));
                }
                else if (v == "Saida")
                {
                    sql.Append(" WHERE(tbEmprestimo.status = FALSE and dataSaida LIKE '%'+@dataSaida+'%')");
                    sql.Append(" ORDER BY tbEmprestimo.dataSaida");
                    comandoSql.Parameters.Add(new OleDbParameter("@dataSaida", text));
                }
                else if (v == "Autor")
                {
                    sql.Append(" WHERE(tbEmprestimo.status = FALSE and nomeAutor LIKE '%'+@nomeAutor+'%')");
                    sql.Append(" ORDER BY tbEmprestimo.dataSaida");
                    comandoSql.Parameters.Add(new OleDbParameter("@autor", text));
                }
                else if (v == "Aluno")
                {
                    sql.Append(" WHERE(tbEmprestimo.status = FALSE and nomeUsuario LIKE '%'+@nomeUsuario+'%')");
                    sql.Append(" ORDER BY tbEmprestimo.dataSaida");
                    comandoSql.Parameters.Add(new OleDbParameter("@nomeUsuario", text));
                }



                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = conectar;
                dadostabela.Load(comandoSql.ExecuteReader());
                return dadostabela;
            }

        }

        internal DataTable listardevolucao(DateTime today)
        {
            using (OleDbConnection conectar = new OleDbConnection(Conexao.stringConexao))
            {
                conectar.Open();
                sql.Append(" SELECT tbEmprestimo.idEmprestimo,dataSaida,dataEntrada, tbLivro.genero, tbUsuario.idUsuario,nomeUsuario,endereco,telefone,");
                sql.Append(" tbLivro.idLivro,nomeLivro,nomeAutor, tbLocal.idLocal,nomeLocal");
                sql.Append(" FROM(((tbEmprestimo INNER JOIN");
                sql.Append(" tbUsuario ON tbEmprestimo.idUsuario = tbUsuario.idUsuario) INNER JOIN");
                sql.Append(" tbLivro ON tbEmprestimo.idLivro = tbLivro.idLivro) INNER JOIN");
                sql.Append(" tbLocal ON tbEmprestimo.idLocal = tbLocal.idLocal)");

                sql.Append(" WHERE(tbEmprestimo.status = true and dataEntrada < @today)");
                sql.Append(" ORDER BY tbEmprestimo.dataEntrada");
                comandoSql.Parameters.Add(new OleDbParameter("@today", today.ToShortDateString()));

                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = conectar;
                dadostabela.Load(comandoSql.ExecuteReader());
                return dadostabela;
            }
        }

                internal DataTable listarEmprestimo(string text, string v)
        {
            using (OleDbConnection conectar = new OleDbConnection(Conexao.stringConexao))
            {
                conectar.Open();
                sql.Append(" SELECT tbEmprestimo.idEmprestimo,dataSaida, tbLivro.genero, tbUsuario.idUsuario,nomeUsuario,endereco,telefone,");
                sql.Append(" tbLivro.idLivro,nomeLivro,nomeAutor, tbLocal.idLocal,nomeLocal");
                sql.Append(" FROM(((tbEmprestimo INNER JOIN");
                sql.Append(" tbUsuario ON tbEmprestimo.idUsuario = tbUsuario.idUsuario) INNER JOIN");
                sql.Append(" tbLivro ON tbEmprestimo.idLivro = tbLivro.idLivro) INNER JOIN");
                sql.Append(" tbLocal ON tbEmprestimo.idLocal = tbLocal.idLocal)");
                if (v == "Livro")
                {
                    sql.Append(" WHERE(tbEmprestimo.status = TRUE and nomeLivro LIKE '%'+@nomeLivro+'%')");
                    sql.Append(" ORDER BY tbEmprestimo.dataSaida");
                    comandoSql.Parameters.Add(new OleDbParameter("@nomeLivro", text));
                }
                else if (v == "Genero")
                {
                    sql.Append(" WHERE(tbEmprestimo.status = TRUE and genero LIKE '%'+@genero+'%')");
                    sql.Append(" ORDER BY tbEmprestimo.dataSaida");
                    comandoSql.Parameters.Add(new OleDbParameter("@genero", text));
                }
                else if (v == "Saida")
                {
                    sql.Append(" WHERE(tbEmprestimo.status = TRUE and dataSaida LIKE '%'+@dataSaida+'%')");
                    sql.Append(" ORDER BY tbEmprestimo.dataSaida");
                    comandoSql.Parameters.Add(new OleDbParameter("@dataSaida", text));
                }
                else if (v == "Autor")
                {
                    sql.Append(" WHERE(tbEmprestimo.status = TRUE and nomeAutor LIKE '%'+@nomeAutor+'%')");
                    sql.Append(" ORDER BY tbEmprestimo.dataSaida");
                    comandoSql.Parameters.Add(new OleDbParameter("@autor", text));
                }
                else if (v == "Aluno")
                {
                    sql.Append(" WHERE(tbEmprestimo.status = TRUE and nomeUsuario LIKE '%'+@nomeUsuario+'%')");
                    sql.Append(" ORDER BY tbEmprestimo.dataSaida");
                    comandoSql.Parameters.Add(new OleDbParameter("@nomeUsuario", text));
                }



                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = conectar;
                dadostabela.Load(comandoSql.ExecuteReader());
                return dadostabela;

            }

        }
             
               
     
              

        //internal void atualizar(int idLivro, int idLocal, int quantidade)
        //{
        //    using (OleDbConnection conectar = new OleDbConnection(Conexao.stringConexao))
        //    {
        //        conectar.Open();

        //        comandoSql.Parameters.Clear();
        //        sql.Append(" UPDATE tbEstoque");
        //        sql.Append(" SET quantidade = @quantidade");
        //        sql.Append(" WHERE (idLocal = @idLocal AND idLivro = @idLivro)");

        //        comandoSql.Parameters.Add(new OleDbParameter("@idLivro", idLivro));
        //        comandoSql.Parameters.Add(new OleDbParameter("@idLocal", idLocal));
        //        comandoSql.Parameters.Add(new OleDbParameter("@quantidade", quantidade));

        //        comandoSql.CommandText = sql.ToString();
        //        comandoSql.Connection = conectar;
        //        comandoSql.ExecuteNonQuery();
        //    }
        //}
    }
}
