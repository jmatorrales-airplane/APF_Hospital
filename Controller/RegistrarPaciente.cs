using System.Data;
using System.Data.SqlClient;


namespace APF_Hospital.Controller
{
    internal class RegistrarPaciente
    {
        private Connection connection = new Connection();
        private static SqlConnection conn;

        public void registroPaciente(string nombre, string direccion, string dni, int dIngreso, char pronostico, bool esPaciente, bool estaMuerto)
        {
            try
            {
                conn = connection.conexionSQL();

                if (conn != null)
                {
                    conn.Open();
                    string query = $"INSERT INTO Paciente VALUES({"@idPaciente"},{"@nombre"},{"@direccion"}," +
                        $"{"@dni"},{"@dIngreso"},{"@pronostrico".ToUpper()},{"@esPaciente"},{"@estaMuerto"})";

                    using (SqlCommand cmd = new(query, conn))
                    {
                        // idPaciente
                        cmd.Parameters.Add("@idPaciente", SqlDbType.UniqueIdentifier).Value = Guid.NewGuid();
                        // nombre
                        cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 25).Value = nombre;
                        // direccion
                        cmd.Parameters.Add("@direccion", SqlDbType.VarChar, 100).Value = direccion;
                        // dni
                        cmd.Parameters.Add("@dni", SqlDbType.VarChar, 9).Value = dni;
                        // dias ingreso
                        cmd.Parameters.Add("@dIngreso", SqlDbType.Int).Value = dIngreso;
                        // Pronostico
                        cmd.Parameters.Add("@pronostrico", SqlDbType.Char).Value = pronostico;
                        // esPaciente
                        cmd.Parameters.Add("@esPaciente", SqlDbType.Bit).Value = Convert.ToInt32(esPaciente);
                        // estaMuerto
                        cmd.Parameters.Add("@estaMuerto", SqlDbType.Bit).Value = Convert.ToInt32(estaMuerto);

                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Añadido correctamente");
                    conn.Close();
                }
            }
            catch (ArgumentException ae) { MessageBox.Show(ae.Message); }
            catch (SqlException sqle) { MessageBox.Show(sqle.Message); }
            catch (IOException ioe) { MessageBox.Show(ioe.Message); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally
            {
                conn.Close();
            }
        }
    }
}
