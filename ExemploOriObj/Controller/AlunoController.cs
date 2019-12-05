using ExemploOriObj.Dao;
using ExemploOriObj.Model;
using System;
using System.Data;

namespace ExemploOriObj.Controller
{
    class AlunoController
    {
        public DataTable Listar()
        {
            try
            {
                AlunoDao alunoDao = new AlunoDao();
                DataTable dt = new DataTable();

                dt = alunoDao.Listar();
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable PesquisarNome(AlunoModel aluno)
        {
            try
            {
                AlunoDao alunoDao = new AlunoDao();
                DataTable dt = new DataTable();
                dt = alunoDao.BuscarNome(aluno);

                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
