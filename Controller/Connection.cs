using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APF_Hospital.Controller
{
    internal class Connection
    {
        private readonly static string conString = "data source=AIRPLANE_JORDI; database=Hospital; integrated security=SSPI";
        private static SqlConnection connection;
        private static bool testConn()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (SqlException)
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public SqlConnection conexionSQL()
        {
            connection = new SqlConnection(conString);
            bool test = testConn();
            if (test) return connection;
            else return null;
        }

    }
}
