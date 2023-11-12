namespace EmpleadosAdmin
{
    partial class FrmEmpleados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmpleados));
            this.grdEmpleados = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdTipoIdentificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoIdentificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValorIdentificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSegundoNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSalarioBase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVacaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnRefrescar = new System.Windows.Forms.ToolStripButton();
            this.btnAgregar = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnDarBaja = new System.Windows.Forms.ToolStripButton();
            this.btnCalcularVacaciones = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmpleados)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdEmpleados
            // 
            this.grdEmpleados.AllowUserToAddRows = false;
            this.grdEmpleados.AllowUserToDeleteRows = false;
            this.grdEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colIdTipoIdentificacion,
            this.colTipoIdentificacion,
            this.colValorIdentificacion,
            this.colSegundoNombre,
            this.colSalarioBase,
            this.colFechaIngreso,
            this.colVacaciones,
            this.colEstado});
            this.grdEmpleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdEmpleados.Location = new System.Drawing.Point(0, 25);
            this.grdEmpleados.MultiSelect = false;
            this.grdEmpleados.Name = "grdEmpleados";
            this.grdEmpleados.ReadOnly = true;
            this.grdEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdEmpleados.Size = new System.Drawing.Size(1052, 492);
            this.grdEmpleados.TabIndex = 0;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            // 
            // colIdTipoIdentificacion
            // 
            this.colIdTipoIdentificacion.DataPropertyName = "IdTipoIdentificacion";
            this.colIdTipoIdentificacion.HeaderText = "IdTipoIdentificacion";
            this.colIdTipoIdentificacion.Name = "colIdTipoIdentificacion";
            this.colIdTipoIdentificacion.ReadOnly = true;
            this.colIdTipoIdentificacion.Visible = false;
            // 
            // colTipoIdentificacion
            // 
            this.colTipoIdentificacion.DataPropertyName = "TipoIdentificacion";
            this.colTipoIdentificacion.HeaderText = "Tipo de Identificación";
            this.colTipoIdentificacion.Name = "colTipoIdentificacion";
            this.colTipoIdentificacion.ReadOnly = true;
            // 
            // colValorIdentificacion
            // 
            this.colValorIdentificacion.DataPropertyName = "ValorIdentificacion";
            this.colValorIdentificacion.HeaderText = "Identificación";
            this.colValorIdentificacion.Name = "colValorIdentificacion";
            this.colValorIdentificacion.ReadOnly = true;
            // 
            // colSegundoNombre
            // 
            this.colSegundoNombre.DataPropertyName = "NombreEmpleado";
            this.colSegundoNombre.HeaderText = "Nombre";
            this.colSegundoNombre.Name = "colSegundoNombre";
            this.colSegundoNombre.ReadOnly = true;
            // 
            // colSalarioBase
            // 
            this.colSalarioBase.DataPropertyName = "SalarioBase";
            this.colSalarioBase.HeaderText = "Salario Base";
            this.colSalarioBase.Name = "colSalarioBase";
            this.colSalarioBase.ReadOnly = true;
            // 
            // colFechaIngreso
            // 
            this.colFechaIngreso.DataPropertyName = "FechaIngreso";
            this.colFechaIngreso.HeaderText = "Fecha Ingreso";
            this.colFechaIngreso.Name = "colFechaIngreso";
            this.colFechaIngreso.ReadOnly = true;
            // 
            // colVacaciones
            // 
            this.colVacaciones.DataPropertyName = "VacacionesAcumuladas";
            this.colVacaciones.HeaderText = "Vacaciones";
            this.colVacaciones.Name = "colVacaciones";
            this.colVacaciones.ReadOnly = true;
            // 
            // colEstado
            // 
            this.colEstado.DataPropertyName = "Activo";
            this.colEstado.HeaderText = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRefrescar,
            this.btnAgregar,
            this.btnSalir,
            this.btnEditar,
            this.btnCalcularVacaciones,
            this.btnDarBaja});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1052, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRefrescar.Image = ((System.Drawing.Image)(resources.GetObject("btnRefrescar.Image")));
            this.btnRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(23, 22);
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(23, 22);
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSalir.Size = new System.Drawing.Size(23, 22);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(23, 22);
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnDarBaja
            // 
            this.btnDarBaja.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDarBaja.Image = ((System.Drawing.Image)(resources.GetObject("btnDarBaja.Image")));
            this.btnDarBaja.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDarBaja.Name = "btnDarBaja";
            this.btnDarBaja.Size = new System.Drawing.Size(23, 22);
            this.btnDarBaja.Text = "Inactivar";
            this.btnDarBaja.ToolTipText = "Activar/Inactivar";
            this.btnDarBaja.Click += new System.EventHandler(this.btnDarBaja_Click);
            // 
            // btnCalcularVacaciones
            // 
            this.btnCalcularVacaciones.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCalcularVacaciones.Image = ((System.Drawing.Image)(resources.GetObject("btnCalcularVacaciones.Image")));
            this.btnCalcularVacaciones.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCalcularVacaciones.Name = "btnCalcularVacaciones";
            this.btnCalcularVacaciones.Size = new System.Drawing.Size(23, 22);
            this.btnCalcularVacaciones.Text = "Vacaciones";
            this.btnCalcularVacaciones.Click += new System.EventHandler(this.btnCalcularVacaciones_Click);
            // 
            // FrmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 517);
            this.Controls.Add(this.grdEmpleados);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administración de Empleados";
            this.Load += new System.EventHandler(this.FrmEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdEmpleados)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdEmpleados;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnRefrescar;
        private System.Windows.Forms.ToolStripButton btnAgregar;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnDarBaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdTipoIdentificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoIdentificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValorIdentificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSegundoNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSalarioBase;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVacaciones;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colEstado;
        private System.Windows.Forms.ToolStripButton btnCalcularVacaciones;
    }
}