using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    
    public partial class Registrar : Form
    {
        Euser objEntidad = new Euser();
        Nuser objNegocio = new Nuser();
        
        public Registrar()
        {
            InitializeComponent();
        }
        private string idusuarios;
        private bool editarse = false;
        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void accionTabla()
        {
            DG1.Columns[0].Visible = false;
            DG1.Columns[1].Width = 60;
            DG1.Columns[2].Width = 170;

            DG1.ClearSelection();

        }

        public void mostrarBuscarTabla(string Buscar)
        {
           

            DG1.DataSource = objNegocio.ListarUsuario(Buscar);

        }

        public void Limpiar()
        {
            txtnombre.Text = "";
            txtapellido.Text = "";
            txtusuario.Text = "";
            txtcontra.Text = "";
            comboBox1.Text = "";
            txtnombre.Focus();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (editarse == false)
            {
                try
                {
                    
                    objEntidad.Nombre = txtnombre.Text.ToUpper();
                    objEntidad.Apellido = txtapellido.Text.ToUpper();
                    objEntidad.Fecha_nacimiento = Convert.ToDateTime(fdtp.Text);
                    objEntidad.Usuario = txtusuario.Text.ToUpper();
                    objEntidad.Contrasena = txtcontra.Text.ToUpper();
                    objEntidad.Tipo = comboBox1.Text.ToUpper();
                 


                    objNegocio.InsertarUsuario(objEntidad);
                    MessageBox.Show("Registro agregado satsfactoriamente");
                    mostrarBuscarTabla("");
                    Limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El registro no se ha agregado correctamente" + ex);
                }
            }
            if (editarse == true)
            {
                try
                {
                    objEntidad.iduser = Convert.ToInt32(idusuarios);
                    objEntidad.Nombre = txtnombre.Text.ToUpper();
                    objEntidad.Apellido = txtapellido.Text.ToUpper();
                    objEntidad.Fecha_nacimiento = Convert.ToDateTime(fdtp.Text);
                    objEntidad.Usuario = txtusuario.Text.ToUpper();
                    objEntidad.Contrasena = txtcontra.Text.ToUpper();
                    objEntidad.Tipo = comboBox1.Text.ToUpper();

                    objNegocio.EditandoUsuario(objEntidad);
                    MessageBox.Show("Registro se ha editado satsfactoriamente");
                    mostrarBuscarTabla("");
                    editarse = false;
                    Limpiar();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("El registro no se ha editado correctamente" + ex);
                }
            }
        }
    }
}
