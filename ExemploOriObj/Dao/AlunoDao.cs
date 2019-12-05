using ExemploOriObj.Model;
using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace ExemploOriObj.Dao
{
    class AlunoDao
    {
        private string con = "server=localhost;port=3306;User Id=root;database=biblioteca;password=12345";
        MySqlConnection connection = null;
        MySqlCommand cmd;

        public DataTable Listar()
        {
            connection = new MySqlConnection(con);

            try
            {
                connection = new MySqlConnection(con);
                cmd = new MySqlCommand("select RM, Nome, Email, NEmprestimo as 'Empréstimo ativo' from aluno order by Nome;", connection);
                MySqlDataAdapter da = new MySqlDataAdapter();
                DataTable dt = new DataTable();

                da.SelectCommand = cmd;

                da.Fill(dt);
                return dt;
            }
            catch (global::System.Exception)
            {
                throw;
            }
        }
        public DataTable BuscarNome(AlunoModel aluno)
        {
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter();
                DataTable dt = new DataTable();
                connection = new MySqlConnection(con);
                cmd = new MySqlCommand("SELECT RM, Nome, Email, NEmprestimo as 'Empréstimo ativo' from aluno where Nome LIKE '%' @Nome '%' ORDER BY Nome;", connection);
                cmd.Parameters.AddWithValue("@Nome", aluno.Nome);

                da.SelectCommand = cmd;
                da.Fill(dt);

                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
