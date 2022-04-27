using Capa_Acceso_Datos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Nuser
    {
        public Duser objDato = new Duser();
        public List<Euser> ListarUsuario(string Buscar)
        {
            return objDato.ListarUsuario(Buscar);

        }
        public void InsertarUsuario(Euser usuario)
        {
            objDato.InsertarUsuario(usuario);
        }
        public void EditandoUsuario(Euser usuario)
        {
            objDato.EditarUsuario(usuario);
        }
        public void EliminandoUsuario(Euser usuario)
        {
            objDato.EliminarUsuario(usuario);
        }


    }
}
