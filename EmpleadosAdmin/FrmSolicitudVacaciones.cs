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
    public partial class FrmSolicitudVacaciones : Form
    {
        private Empleado Empleado {  get; set; }

        private void EstablecerInformacionEmpleado()
        {
            try
            {
                txtIdentificacion.Text = Empleado.ValorIdentificacion;
                txtEmpleado.Text = Empleado.NombreEmpleado;
                txtVacaciones.Text = Empleado.VacacionesAcumuladas.ToString("##.0000");

                var historial = EmpleadoNegocio.ObtenerHistorialVacaciones(Empleado.Id);
                var bindingList = new BindingList<HistorialVacaciones>(historial);
                var source = new BindingSource(bindingList, null);
                grdHistorial.AutoGenerateColumns = false;
                grdHistorial.DataSource = source;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public FrmSolicitudVacaciones(Empleado empleado)
        {
            InitializeComponent();
            Empleado = empleado;
            EstablecerInformacionEmpleado();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                txtDiasSolicitados.Text = EmpleadoNegocio.ObtenerDiasVacacionesProyeccion(dtDesde.Value, dtHasta.Value).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al ejecutar esta operación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizarVacaciones_Click(object sender, EventArgs e)
        {
            try
            {
                txtVacaciones.Text = EmpleadoNegocio.ActualizarVacaciones(Empleado.Id).ToString("##.0000");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al ejecutar esta operación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var desde = Convert.ToDateTime(dtDesde.Value.ToShortDateString());
                var hasta = Convert.ToDateTime(dtHasta.Value.ToShortDateString());
                var isSave = EmpleadoNegocio.GuardarSolicitudVacaciones(Empleado.Id, desde, hasta, Convert.ToDecimal(txtDiasSolicitados.Text));

                if (isSave)
                {
                    MessageBox.Show("Se actualizo correctamente la información del empleado.", "Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
