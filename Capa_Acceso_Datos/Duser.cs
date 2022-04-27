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
    public class Duser
    {
        SqlConnection conexion = new SqlConnection("server=LAPTOP-6R0HNJDA ; database=FinalProject ; integrated security = true");

public List<Euser> ListarUsuario(string Buscar)
        {
            SqlDataReader leerfilas;
            SqlCommand cmd = new SqlCommand("SP_BuscarVisita", conexion);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@Buscar", Buscar);
            leerfilas = cmd.ExecuteReader();

            List<Euser> ListarU = new List<Euser>();
            while (leerfilas.Read())
            {
                ListarU.Add(new Euser
                {
                    iduser = leerfilas.GetInt32(0),
                    Nombre = leerfilas.GetString(1),
                    Apellido = leerfilas.GetString(2),
                    Fecha_nacimiento = leerfilas.GetDateTime(3),
                    Usuario = leerfilas.GetString(4),
                    Contrasena = leerfilas.GetString(5),
                    Tipo = leerfilas.GetString(6)

                   

            });
            }
            conexion.Close();
            leerfilas.Close();
            return ListarU;

        }

        public void InsertarUsuario(Euser usuario)
        {
            SqlCommand cmd = new SqlCommand("SP_InsertarUsuario", conexion);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre);
            cmd.Parameters.AddWithValue("@Apellido", usuario.Apellido);
            cmd.Parameters.AddWithValue("@FechaNacimiento", usuario.Fecha_nacimiento);
            cmd.Parameters.AddWithValue("@usuario", usuario.Usuario);
            cmd.Parameters.AddWithValue("@contra", usuario.Contrasena);


            cmd.ExecuteNonQuery();
            conexion.Close();

        }

        public void EditarUsuario(Euser usuario)
        {
            SqlCommand cmd = new SqlCommand("SP_editarUsuario", conexion);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            conexion.Open();


            cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre);
            cmd.Parameters.AddWithValue("@Apellido", usuario.Apellido);
            cmd.Parameters.AddWithValue("@FechaNacimiento", usuario.Fecha_nacimiento);
            cmd.Parameters.AddWithValue("@usuario", usuario.Usuario);
            cmd.Parameters.AddWithValue("@contra", usuario.Contrasena);

            cmd.ExecuteNonQuery();
            conexion.Close();

        }

        public void EliminarUsuario(Euser usuario)
        {
            SqlCommand cmd = new SqlCommand("SP_eliminarUsuario", conexion);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IDvisitas", usuario.iduser);

            cmd.ExecuteNonQuery();
            conexion.Close();

        }

    }
}
