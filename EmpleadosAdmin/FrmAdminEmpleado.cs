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
    public partial class FrmAdminEmpleado : Form
    {
        private bool IsEdit { get; set; }
        private Empleado Empleado { get; set; }

        private void EstablecerDatosEmpleado()
        {
            try
            {
                cboTipoIdentificacion.SelectedValue = Empleado.IdTipoIDentificacion;
                txtIdentificacion.Text = Empleado.ValorIdentificacion;
                txtDireccion.Text = Empleado.Direccion;
                txtPrimerApellido.Text = Empleado.PrimerApellido;
                txtPrimerNombre.Text = Empleado.PrimerNombre;
                txtSegundoApellido.Text = Empleado.SegundoApellido;
                txtSegundoNombre.Text = Empleado.SegundoNombre;
                dtFechaIngreso.Value = Empleado.FechaIngreso;
                dtFechaIngreso.Enabled = false;
                txtSalarioBase.Text = Empleado.SalarioBase.ToString("##.0000");
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void CargarTiposDeIdentificacion()
        {
            try
            {
                var tiposIdentificacion = TipoIdentificacionNegocio.Catalogo();
                cboTipoIdentificacion.DataSource = tiposIdentificacion;
                cboTipoIdentificacion.DisplayMember = "Nombre";
                cboTipoIdentificacion.ValueMember = "Id";
            }
            catch (Exception)
            {

                throw;
            }
        }

        public FrmAdminEmpleado()
        {
            InitializeComponent();
            CargarTiposDeIdentificacion();
            IsEdit = false;
            dtFechaIngreso.Value = DateTime.Now;
        }

        public FrmAdminEmpleado(Empleado empleado)
        {
            InitializeComponent();
            CargarTiposDeIdentificacion();
            Empleado = empleado;
            IsEdit = true;
            EstablecerDatosEmpleado();
        }

        private void txtSalarioBase_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Validación para aceptar unicamente un solo punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdentificacion.Text == string.Empty || txtIdentificacion.Text == "")
                {
                    MessageBox.Show("La identificación del empleado es requerido", "Adevertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (txtPrimerNombre.Text == string.Empty || txtPrimerNombre.Text == "")
                {
                    MessageBox.Show("El primer nombre del empleado es requerido", "Adevertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (txtPrimerApellido.Text == string.Empty || txtPrimerApellido.Text == "")
                {
                    MessageBox.Show("El primer apellido del empleado es requerido", "Adevertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (txtSalarioBase.Text == string.Empty || txtSalarioBase.Text == "")
                {
                    MessageBox.Show("El salario base del empleado es requerido", "Adevertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!IsEdit) 
                {
                    Empleado = new Empleado();
                    Empleado.IdTipoIDentificacion = Convert.ToInt32(cboTipoIdentificacion.SelectedValue);
                    Empleado.ValorIdentificacion = txtIdentificacion.Text;
                    Empleado.SalarioBase = Convert.ToDecimal(txtSalarioBase.Text);
                    Empleado.PrimerApellido = txtPrimerApellido.Text;
                    Empleado.SegundoApellido = txtSegundoApellido.Text;
                    Empleado.PrimerNombre = txtPrimerNombre.Text;
                    Empleado.SegundoNombre = txtSegundoNombre.Text;
                    Empleado.FechaIngreso = Convert.ToDateTime(dtFechaIngreso.Value.ToShortDateString());
                    Empleado.Direccion = txtDireccion.Text;

                    var isSave = EmpleadoNegocio.Agregar(Empleado);

                    if(isSave)
                    {
                        MessageBox.Show("Se guardo correctamente la información del nuevo empleado.", "Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                } 
                else
                {
                    Empleado.IdTipoIDentificacion = Convert.ToInt32(cboTipoIdentificacion.SelectedValue);
                    Empleado.ValorIdentificacion = txtIdentificacion.Text;
                    Empleado.SalarioBase = Convert.ToDecimal(txtSalarioBase.Text);
                    Empleado.PrimerApellido = txtPrimerApellido.Text;
                    Empleado.SegundoApellido = txtSegundoApellido.Text;
                    Empleado.PrimerNombre = txtPrimerNombre.Text;
                    Empleado.SegundoNombre = txtSegundoNombre.Text;
                    Empleado.Direccion = txtDireccion.Text;

                    var isSave = EmpleadoNegocio.Actualizar(Empleado);

                    if (isSave)
                    {
                        MessageBox.Show("Se actualizo correctamente la información del empleado.", "Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
