using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using analizador.Clases;

namespace analizador
{
    public class Persona
    {
        public string nombre { get; set; }
        public int edad { get; set; }
        public string cedula { get; set; }
        public string correo { get; set; }
        public DateTime fechanacimiento { get; set; }
        public Persona(string nombre, int edad, string cedula, string correo, DateTime fechanacimiento)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.cedula = cedula;
            this.correo = correo;
            this.fechanacimiento = fechanacimiento;
        }
        cConexion conexion = new cConexion();
        public int edadcalcular()
        {
            DateTime fechaactual = DateTime.Now;
            int edadcalculada = DateTime.Now.Year - fechanacimiento.Year;
            if (fechanacimiento.Date > DateTime.Now.AddYears(-edadcalculada))
            {
                edadcalculada--;
            }
            return edadcalculada;
        }






    }
}
