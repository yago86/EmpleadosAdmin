using Modelado;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpleadosAdmin
{
    public partial class FrmEmpleados : Form
    {
        public FrmEmpleados()
        {
            InitializeComponent();
        }

        private void CargarEmpleados()
        {
            try
            {
                var empleados = EmpleadoNegocio.Obtener();
                var bindingList = new BindingList<Empleado>(empleados);
                var source = new BindingSource(bindingList, null);
                grdEmpleados.AutoGenerateColumns = false;
                grdEmpleados.DataSource = source;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            try
            {
                CargarEmpleados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al intentar cargar la lista de empleados: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            try
            {
                CargarEmpleados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al intentar cargar la lista de empleados: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new FrmAdminEmpleado();
                frm.ShowDialog();
                CargarEmpleados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al ejecutar esta operación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                var empleado = grdEmpleados.SelectedRows[0].DataBoundItem as Empleado;
                var frm = new FrmAdminEmpleado(empleado);
                frm.ShowDialog();
                CargarEmpleados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al ejecutar esta operación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDarBaja_Click(object sender, EventArgs e)
        {
            try
            {
                var empleado = grdEmpleados.SelectedRows[0].DataBoundItem as Empleado;
                if (EmpleadoNegocio.ActualizarEstado(empleado.Id))
                {
                    MessageBox.Show("Se actualizo el estado del empleado correctamente.", "Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarEmpleados();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al ejecutar esta operación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCalcularVacaciones_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    var empleado = grdEmpleados.SelectedRows[0].DataBoundItem as Empleado;
                    var frm = new FrmSolicitudVacaciones(empleado);
                    frm.ShowDialog();
                    CargarEmpleados();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrio un error al ejecutar esta operación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al ejecutar esta operación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
