using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using CapaEntidad;


namespace Capa_Acceso_Datos
{
    public class D_cat
    {
        SqlConnection conexion = new SqlConnection("server=LAPTOP-6R0HNJDA ; database=FinalProject ; integrated security = true");

public List<E_cat> ListarVisita(string Buscar)
        {
            SqlDataReader leerfilas;
            SqlCommand cmd = new SqlCommand("SP_BuscarVisita", conexion);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@Buscar", Buscar);
            leerfilas = cmd.ExecuteReader();

            List<E_cat> Listar = new List<E_cat>();
            while (leerfilas.Read())
            {
                Listar.Add(new E_cat
                {
                    idvisitas = leerfilas.GetInt32(0),
                    Nombre = leerfilas.GetString(1),
                    Apellido = leerfilas.GetString(2),
                    Carrera = leerfilas.GetString(3),
                    Correo = leerfilas.GetString(4),
                    Edificio = leerfilas.GetString(5),
                    HoraEntrada1 = leerfilas.GetDateTime(6),
                    HoraSalida1 = leerfilas.GetDateTime(7),
                    MotivoSalida1 = leerfilas.GetString(8),
                    Lugar1 = leerfilas.GetString(9)

                   

            });
            }
            conexion.Close();
            leerfilas.Close();
            return Listar;

        }

        public void InsertarVisita(E_cat visita)
        {
            SqlCommand cmd = new SqlCommand("SP_InsertarVisita", conexion);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@Nombre", visita.Nombre);
            cmd.Parameters.AddWithValue("@Apellido", visita.Apellido);
            cmd.Parameters.AddWithValue("@Carrera", visita.Carrera);
            cmd.Parameters.AddWithValue("@Correo", visita.Correo);
            cmd.Parameters.AddWithValue("@Edificio", visita.Edificio);
            cmd.Parameters.AddWithValue("@HoraEntrada", visita.HoraEntrada1);
            cmd.Parameters.AddWithValue("@HoraSalida", visita.HoraSalida1);
            cmd.Parameters.AddWithValue("@MotivoSalida", visita.MotivoSalida1);
            cmd.Parameters.AddWithValue("@Lugar", visita.Lugar1);

            cmd.ExecuteNonQuery();
            conexion.Close();

        }

        public void EditarCont(E_cat visita)
        {
            SqlCommand cmd = new SqlCommand("SP_editarVisita", conexion);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@Nombre", visita.Nombre);
            cmd.Parameters.AddWithValue("@Apellido", visita.Apellido);
            cmd.Parameters.AddWithValue("@Carrera", visita.Carrera);
            cmd.Parameters.AddWithValue("@Correo", visita.Correo);
            cmd.Parameters.AddWithValue("@Edificio", visita.Edificio);
            cmd.Parameters.AddWithValue("@HoraEntrada", visita.HoraEntrada1);
            cmd.Parameters.AddWithValue("@HoraSalida", visita.HoraSalida1);
            cmd.Parameters.AddWithValue("@MotivoSalida", visita.MotivoSalida1);
            cmd.Parameters.AddWithValue("@Lugar", visita.Lugar1);

            cmd.ExecuteNonQuery();
            conexion.Close();

        }

        public void EliminarCont(E_cat visita)
        {
            SqlCommand cmd = new SqlCommand("SP_eliminarVisita", conexion);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IDvisitas", visita.idvisitas);

            cmd.ExecuteNonQuery();
            conexion.Close();

        }

    }
}
