using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Euser
    {
        private int Iduser;
        private string nombre;
        private string apellido;
private DateTime fecha_nacimiento;
private String usuario;
        private string contrasena;
        private string tipo;

        public int iduser { get => Iduser; set => Iduser = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime Fecha_nacimiento { get => fecha_nacimiento; set => fecha_nacimiento = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }
        public string Tipo { get => tipo; set => tipo = value; }
    }
}
