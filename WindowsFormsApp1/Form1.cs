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
    public partial class Form1 : Form
    {
        private string idvisitas;
        private bool editarse = false;

        E_cat objEntidad = new E_cat();
        N_cat objNegocio = new N_cat();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mostrarBuscarTabla("");
            accionTabla();
        }
        public void accionTabla()
        {
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Width = 60;
            dataGridView1.Columns[2].Width = 170;

            dataGridView1.ClearSelection();

        }

        public void mostrarBuscarTabla(string Buscar)
        {
            N_cat objNegocio = new N_cat();

            dataGridView1.DataSource = objNegocio.ListarVisita(Buscar);

        }

        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {
            mostrarBuscarTabla(buscartxt.text);
        }
        public void Limpiar()
        {
            txtnombre.Text = "";
            txtapellido.Text = "";
            txtcarrera.Text = "";
            txtnombre.Focus();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                editarse = true;
                idvisitas = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtnombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtapellido.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtcarrera.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtcorreo.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txtedificio.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                bdtp.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                bdtp1.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                txtmotivo.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                txtlugar.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();


            }
            else { MessageBox.Show("Seleccione una fila para continuar"); }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (editarse == false)
            {
                try
                {

                    objEntidad.Nombre = txtnombre.Text.ToUpper();
                    objEntidad.Apellido = txtapellido.Text.ToUpper();
                    objEntidad.Carrera = txtcarrera.Text.ToUpper();
                    objEntidad.Correo = txtcorreo.Text.ToUpper();
                    objEntidad.Edificio = txtedificio.Text.ToUpper();
                    objEntidad.HoraEntrada1 = Convert.ToDateTime(bdtp.Text);
                    objEntidad.HoraSalida1 = Convert.ToDateTime(bdtp1.Text);
                    objEntidad.MotivoSalida1 = txtmotivo.Text.ToUpper();
                    objEntidad.Lugar1 = txtlugar.Text.ToUpper();


                    objNegocio.InsertarVisita(objEntidad);
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
                    objEntidad.idvisitas = Convert.ToInt32(idvisitas);
                    objEntidad.Nombre = txtnombre.Text.ToUpper();
                    objEntidad.Apellido = txtapellido.Text.ToUpper();
                    objEntidad.Carrera = txtcarrera.Text.ToUpper();
                    objEntidad.Correo = txtcorreo.Text.ToUpper();
                    objEntidad.Edificio = txtedificio.Text.ToUpper();
                    objEntidad.HoraEntrada1 = Convert.ToDateTime(bdtp.Text);
                    objEntidad.HoraSalida1 = Convert.ToDateTime(bdtp1.Text);
                    objEntidad.MotivoSalida1 = txtmotivo.Text.ToUpper();
                    objEntidad.Lugar1 = txtlugar.Text.ToUpper();
                    
                    objNegocio.EditandoCategoria(objEntidad);
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                objEntidad.idvisitas = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                objNegocio.EliminandoCategoria(objEntidad);

                MessageBox.Show("Se elimino correctamente");
                mostrarBuscarTabla("");


            }
            else { MessageBox.Show("Seleccione la fila que desea eliminar"); }

        }

        private void bdtp_onValueChanged(object sender, EventArgs e)
        {
          
        }

        private void bdtp_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
