using System.Data;
using System.Data.SqlClient;

namespace analizador.Clases
{
    internal class cConexion
    {
        private string cadenaconexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DANIEL\Documents\proyecto.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True;Encrypt=False;";
        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaconexion);

        }
    }
}

      