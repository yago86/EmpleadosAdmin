namespace EmpleadosAdmin
{
    partial class FrmTipoIdentificacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTipoIdentificacion));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnRefrescar = new System.Windows.Forms.ToolStripButton();
            this.btnAgregar = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grdTiposIdentificaion = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSegundoNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTiposIdentificaion)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRefrescar,
            this.btnAgregar,
            this.btnSalir,
            this.btnEditar});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 2;
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
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grdTiposIdentificaion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 425);
            this.panel1.TabIndex = 3;
            // 
            // grdTiposIdentificaion
            // 
            this.grdTiposIdentificaion.AllowUserToAddRows = false;
            this.grdTiposIdentificaion.AllowUserToDeleteRows = false;
            this.grdTiposIdentificaion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdTiposIdentificaion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTiposIdentificaion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colSegundoNombre,
            this.colEstado});
            this.grdTiposIdentificaion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdTiposIdentificaion.Location = new System.Drawing.Point(0, 0);
            this.grdTiposIdentificaion.MultiSelect = false;
            this.grdTiposIdentificaion.Name = "grdTiposIdentificaion";
            this.grdTiposIdentificaion.ReadOnly = true;
            this.grdTiposIdentificaion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdTiposIdentificaion.Size = new System.Drawing.Size(800, 425);
            this.grdTiposIdentificaion.TabIndex = 1;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            // 
            // colSegundoNombre
            // 
            this.colSegundoNombre.DataPropertyName = "Nombre";
            this.colSegundoNombre.HeaderText = "Nombre";
            this.colSegundoNombre.Name = "colSegundoNombre";
            this.colSegundoNombre.ReadOnly = true;
            // 
            // colEstado
            // 
            this.colEstado.DataPropertyName = "Activo";
            this.colEstado.HeaderText = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;
            // 
            // FrmTipoIdentificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmTipoIdentificacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipos de Identificación";
            this.Load += new System.EventHandler(this.FrmTipoIdentificacion_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdTiposIdentificaion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnRefrescar;
        private System.Windows.Forms.ToolStripButton btnAgregar;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView grdTiposIdentificaion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSegundoNombre;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colEstado;
    }
}