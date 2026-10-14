using analizador.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace analizador
{
    public partial class loggin_adm : Form
    {
        private readonly cConexion conexion = new cConexion();
        public loggin_adm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loggin_Click(object sender, EventArgs e)
        {
            
            if (String.IsNullOrWhiteSpace(nombre.Text) || String.IsNullOrWhiteSpace(contraseña.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string query = "SELECT COUNT(*) FROM administrador WHERE nombre  = @nombre AND contraseña = @contraseña ";
            try
            {

                using (SqlConnection con = conexion.ObtenerConexion())

                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@nombre", nombre.Text.Trim());
                        cmd.Parameters.AddWithValue("@contraseña", contraseña.Text.Trim());
                        int resultado = Convert.ToInt32(cmd.ExecuteScalar());
                        if (resultado == 1)
                        {
                            MessageBox.Show("Bienvenido, administrador.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            principal_adm principal = new principal_adm();
                            principal.Show();
                        }
                        else
                        {
                            MessageBox.Show("Nombre de usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }


                    }
                }
            }
            
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar sesión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loggin_adm_Load(object sender, EventArgs e)
{

}
    }
}
