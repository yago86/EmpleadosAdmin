namespace EmpleadosAdmin
{
    partial class FrmSolicitudVacaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSolicitudVacaciones));
            this.label2 = new System.Windows.Forms.Label();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.lblIdentificacion = new System.Windows.Forms.Label();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.lblVacaciones = new System.Windows.Forms.Label();
            this.txtVacaciones = new System.Windows.Forms.TextBox();
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.dtDesde = new System.Windows.Forms.DateTimePicker();
            this.dtHasta = new System.Windows.Forms.DateTimePicker();
            this.txtDiasSolicitados = new System.Windows.Forms.TextBox();
            this.lblDiasSolicitados = new System.Windows.Forms.Label();
            this.grdHistorial = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblHistorial = new System.Windows.Forms.Label();
            this.btnActualizarVacaciones = new System.Windows.Forms.Button();
            this.colSegundoNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(143, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(390, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Información Solicitud Vacaciones del Empleado";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.Location = new System.Drawing.Point(64, 71);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(66, 13);
            this.lblEmpleado.TabIndex = 2;
            this.lblEmpleado.Text = "Empleado:";
            // 
            // lblIdentificacion
            // 
            this.lblIdentificacion.AutoSize = true;
            this.lblIdentificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentificacion.Location = new System.Drawing.Point(41, 47);
            this.lblIdentificacion.Name = "lblIdentificacion";
            this.lblIdentificacion.Size = new System.Drawing.Size(88, 13);
            this.lblIdentificacion.TabIndex = 3;
            this.lblIdentificacion.Text = "Identificación:";
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtIdentificacion.Location = new System.Drawing.Point(136, 47);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.ReadOnly = true;
            this.txtIdentificacion.Size = new System.Drawing.Size(227, 20);
            this.txtIdentificacion.TabIndex = 4;
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtEmpleado.Location = new System.Drawing.Point(136, 68);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.ReadOnly = true;
            this.txtEmpleado.Size = new System.Drawing.Size(500, 20);
            this.txtEmpleado.TabIndex = 5;
            // 
            // lblVacaciones
            // 
            this.lblVacaciones.AutoSize = true;
            this.lblVacaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVacaciones.Location = new System.Drawing.Point(53, 92);
            this.lblVacaciones.Name = "lblVacaciones";
            this.lblVacaciones.Size = new System.Drawing.Size(77, 13);
            this.lblVacaciones.TabIndex = 6;
            this.lblVacaciones.Text = "Vacaciones:";
            // 
            // txtVacaciones
            // 
            this.txtVacaciones.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtVacaciones.Location = new System.Drawing.Point(136, 89);
            this.txtVacaciones.Name = "txtVacaciones";
            this.txtVacaciones.ReadOnly = true;
            this.txtVacaciones.Size = new System.Drawing.Size(109, 20);
            this.txtVacaciones.TabIndex = 7;
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesde.Location = new System.Drawing.Point(83, 145);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(47, 13);
            this.lblDesde.TabIndex = 8;
            this.lblDesde.Text = "Desde:";
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasta.Location = new System.Drawing.Point(417, 145);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(44, 13);
            this.lblHasta.TabIndex = 9;
            this.lblHasta.Text = "Hasta:";
            // 
            // dtDesde
            // 
            this.dtDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDesde.Location = new System.Drawing.Point(136, 142);
            this.dtDesde.Name = "dtDesde";
            this.dtDesde.Size = new System.Drawing.Size(169, 20);
            this.dtDesde.TabIndex = 15;
            // 
            // dtHasta
            // 
            this.dtHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtHasta.Location = new System.Drawing.Point(467, 142);
            this.dtHasta.Name = "dtHasta";
            this.dtHasta.Size = new System.Drawing.Size(169, 20);
            this.dtHasta.TabIndex = 16;
            // 
            // txtDiasSolicitados
            // 
            this.txtDiasSolicitados.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtDiasSolicitados.Location = new System.Drawing.Point(136, 163);
            this.txtDiasSolicitados.Name = "txtDiasSolicitados";
            this.txtDiasSolicitados.Size = new System.Drawing.Size(109, 20);
            this.txtDiasSolicitados.TabIndex = 18;
            // 
            // lblDiasSolicitados
            // 
            this.lblDiasSolicitados.AutoSize = true;
            this.lblDiasSolicitados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiasSolicitados.Location = new System.Drawing.Point(28, 166);
            this.lblDiasSolicitados.Name = "lblDiasSolicitados";
            this.lblDiasSolicitados.Size = new System.Drawing.Size(102, 13);
            this.lblDiasSolicitados.TabIndex = 17;
            this.lblDiasSolicitados.Text = "Dias Solicitados:";
            // 
            // grdHistorial
            // 
            this.grdHistorial.AllowUserToAddRows = false;
            this.grdHistorial.AllowUserToDeleteRows = false;
            this.grdHistorial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdHistorial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdHistorial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSegundoNombre,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.colEstado});
            this.grdHistorial.Location = new System.Drawing.Point(31, 232);
            this.grdHistorial.MultiSelect = false;
            this.grdHistorial.Name = "grdHistorial";
            this.grdHistorial.ReadOnly = true;
            this.grdHistorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdHistorial.Size = new System.Drawing.Size(605, 272);
            this.grdHistorial.TabIndex = 19;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(559, 168);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(77, 27);
            this.btnGuardar.TabIndex = 20;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Image = ((System.Drawing.Image)(resources.GetObject("btnCalcular.Image")));
            this.btnCalcular.Location = new System.Drawing.Point(482, 168);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(77, 27);
            this.btnCalcular.TabIndex = 21;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblHistorial
            // 
            this.lblHistorial.AutoSize = true;
            this.lblHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistorial.Location = new System.Drawing.Point(312, 211);
            this.lblHistorial.Name = "lblHistorial";
            this.lblHistorial.Size = new System.Drawing.Size(65, 16);
            this.lblHistorial.TabIndex = 22;
            this.lblHistorial.Text = "Historial";
            // 
            // btnActualizarVacaciones
            // 
            this.btnActualizarVacaciones.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizarVacaciones.Image")));
            this.btnActualizarVacaciones.Location = new System.Drawing.Point(251, 92);
            this.btnActualizarVacaciones.Name = "btnActualizarVacaciones";
            this.btnActualizarVacaciones.Size = new System.Drawing.Size(77, 27);
            this.btnActualizarVacaciones.TabIndex = 23;
            this.btnActualizarVacaciones.Text = "Actualizar";
            this.btnActualizarVacaciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActualizarVacaciones.UseVisualStyleBackColor = true;
            this.btnActualizarVacaciones.Click += new System.EventHandler(this.btnActualizarVacaciones_Click);
            // 
            // colSegundoNombre
            // 
            this.colSegundoNombre.DataPropertyName = "FechaRegistro";
            this.colSegundoNombre.HeaderText = "Fecha Solicitud";
            this.colSegundoNombre.Name = "colSegundoNombre";
            this.colSegundoNombre.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Solicitud";
            this.Column1.HeaderText = "Días Solicitados";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "VacacionesFecha";
            this.Column2.HeaderText = "Dias A Fecha";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "FechaIni";
            this.Column3.HeaderText = "Desde";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "FechaFin";
            this.Column4.HeaderText = "Hasta";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // colEstado
            // 
            this.colEstado.DataPropertyName = "Vigente";
            this.colEstado.HeaderText = "Vigente";
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;
            // 
            // FrmSolicitudVacaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 516);
            this.Controls.Add(this.btnActualizarVacaciones);
            this.Controls.Add(this.lblHistorial);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.grdHistorial);
            this.Controls.Add(this.txtDiasSolicitados);
            this.Controls.Add(this.lblDiasSolicitados);
            this.Controls.Add(this.dtHasta);
            this.Controls.Add(this.dtDesde);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.lblDesde);
            this.Controls.Add(this.txtVacaciones);
            this.Controls.Add(this.lblVacaciones);
            this.Controls.Add(this.txtEmpleado);
            this.Controls.Add(this.txtIdentificacion);
            this.Controls.Add(this.lblIdentificacion);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmSolicitudVacaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solicitud de Vacaciones";
            ((System.ComponentModel.ISupportInitialize)(this.grdHistorial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.Label lblIdentificacion;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.Label lblVacaciones;
        private System.Windows.Forms.TextBox txtVacaciones;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.DateTimePicker dtDesde;
        private System.Windows.Forms.DateTimePicker dtHasta;
        private System.Windows.Forms.TextBox txtDiasSolicitados;
        private System.Windows.Forms.Label lblDiasSolicitados;
        private System.Windows.Forms.DataGridView grdHistorial;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblHistorial;
        private System.Windows.Forms.Button btnActualizarVacaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSegundoNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colEstado;
    }
}