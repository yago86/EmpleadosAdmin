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
    public partial class FrmTipoIdentificacion : Form
    {
        public FrmTipoIdentificacion()
        {
            InitializeComponent();
        }

        private void CargarTipoIdentificaciones()
        {
            try
            {
                var tipoIdentificaciones = TipoIdentificacionNegocio.Obtener();
                var bindingList = new BindingList<TipoIdentificacion>(tipoIdentificaciones);
                var source = new BindingSource(bindingList, null);
                grdTiposIdentificaion.AutoGenerateColumns = false;
                grdTiposIdentificaion.DataSource = source;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void FrmTipoIdentificacion_Load(object sender, EventArgs e)
        {
            try
            {
                CargarTipoIdentificaciones();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al intentar cargar la lista de tipo de identificaciones: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            try
            {
                CargarTipoIdentificaciones();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al intentar cargar la lista de tipo de identificaciones: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new FrmAdminTipoIdentificacion();
                frm.ShowDialog();
                CargarTipoIdentificaciones();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al ejecutar esta operación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
