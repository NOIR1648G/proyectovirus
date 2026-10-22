using System.Data;
using System.Data.SqlClient;

namespace analizador.Clases
{
    internal class cConexion
    {
        private string cadenaconexion = @"VData Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DANIEL\analizador\proyecto.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True";
        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaconexion);

        }
    }
}

      