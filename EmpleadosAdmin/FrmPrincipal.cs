using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace EmpleadosAdmin
{
    public partial class FrmPrincipal : Form
    {
        private void MostrarForma<T>()
            where T : Form, new()
        {
            try
            {
                foreach (Form FormaAbierta in Application.OpenForms)
                {
                    if ((FormaAbierta) is T)
                    {
                        FormaAbierta.Activate();
                        return;
                    }
                }
                var forma = new T { MdiParent = this };
                forma.Show();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                MostrarForma<FrmEmpleados>();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Error al Cargar el Formulario: " + ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tipoDeIdentificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                MostrarForma<FrmTipoIdentificacion>();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Error al Cargar el Formulario: " + ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
