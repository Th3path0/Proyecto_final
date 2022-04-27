using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class E_cat
    {
        private int Idvisitas;
        private string nombre;
        private string apellido;
        private string carrera;
private string correo;
private string edificio;
private DateTime horaentrada;
private DateTime horasalida;
private string MotivoSalida;
private String Lugar;

        public int idvisitas { get => Idvisitas; set => Idvisitas = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Carrera { get => carrera; set => carrera = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Edificio { get => edificio; set => edificio = value; }
        public DateTime HoraEntrada1 { get => horaentrada; set => horaentrada = value; }
        public DateTime HoraSalida1 { get => horasalida; set => horasalida = value; }
        public string MotivoSalida1 { get => MotivoSalida; set => MotivoSalida = value; }
        public string Lugar1 { get => Lugar; set => Lugar = value; }
    }
}
