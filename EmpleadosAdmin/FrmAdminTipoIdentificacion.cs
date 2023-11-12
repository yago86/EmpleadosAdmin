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
    public partial class FrmAdminTipoIdentificacion : Form
    {
        private bool IsEdit {  get; set; }
        private TipoIdentificacion TipoIdentificacion { get; set; }

        public FrmAdminTipoIdentificacion()
        {
            InitializeComponent();
            IsEdit = false;
        }

        public FrmAdminTipoIdentificacion(TipoIdentificacion tipoIdentificacion)
        {
            InitializeComponent();
            TipoIdentificacion = tipoIdentificacion;
            IsEdit = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text == string.Empty || txtNombre.Text == "")
                {
                    MessageBox.Show("El campo nombre es requerido", "Adevertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!IsEdit)
                {
                    TipoIdentificacion = new TipoIdentificacion();
                    TipoIdentificacion.Activo = chkActivo.Checked;
                    TipoIdentificacion.Nombre = txtNombre.Text;

                    var isSave = TipoIdentificacionNegocio.Agregar(TipoIdentificacion);

                    if (isSave)
                    {
                        MessageBox.Show("Se guardo correctamente la información del nuevo tipo de identificación.", "Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al intentar guardar este registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
