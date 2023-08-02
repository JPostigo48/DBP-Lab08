using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDB8.Conexion
{
    class ConexionSQL
    {
        private SqlConnection sqlConn;
        private String _sConexion;

        public ConexionSQL()
        {
            _sConexion = @"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=DBWeb1; integrated security=True";
        }

        public Boolean conectar()
        {
            try
            {
                sqlConn = new SqlConnection(_sConexion);
                sqlConn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }
        public void desconectar()
        {
            sqlConn.Close();
        }

        public SqlDataReader executeQuery(string Q)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(Q, sqlConn);
                SqlDataReader reader = cmd.ExecuteReader();

                return reader;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

        }
        public SqlDataReader executeProcedureRead(String Q, List<SqlParameter> parameterOut)
        {
            return null;
        }

    }
}
