namespace consecionariaYoBa
{
    partial class FrmBuscar
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
            this.BtnVolverBuscar = new System.Windows.Forms.Button();
            this.DgvAutos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtIdModificar = new System.Windows.Forms.TextBox();
            this.lblIdModificar = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblIdEliminar = new System.Windows.Forms.Label();
            this.txtIdEliminar = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnVender = new System.Windows.Forms.Button();
            this.lblIdVender = new System.Windows.Forms.Label();
            this.txtIdVender = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCondicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEquipamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPuertas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAutos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnVolverBuscar
            // 
            this.BtnVolverBuscar.Location = new System.Drawing.Point(36, 413);
            this.BtnVolverBuscar.Name = "BtnVolverBuscar";
            this.BtnVolverBuscar.Size = new System.Drawing.Size(95, 46);
            this.BtnVolverBuscar.TabIndex = 0;
            this.BtnVolverBuscar.Text = "Volver";
            this.BtnVolverBuscar.UseVisualStyleBackColor = true;
            this.BtnVolverBuscar.Click += new System.EventHandler(this.BtnVolverBuscar_Click);
            // 
            // DgvAutos
            // 
            this.DgvAutos.AllowUserToAddRows = false;
            this.DgvAutos.AllowUserToDeleteRows = false;
            this.DgvAutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colMarca,
            this.colModelo,
            this.colColor,
            this.colCondicion,
            this.colKm,
            this.colEquipamiento,
            this.colPuertas,
            this.colDescripcion});
            this.DgvAutos.Location = new System.Drawing.Point(36, 164);
            this.DgvAutos.Name = "DgvAutos";
            this.DgvAutos.ReadOnly = true;
            this.DgvAutos.Size = new System.Drawing.Size(967, 220);
            this.DgvAutos.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.txtIdModificar);
            this.groupBox1.Controls.Add(this.lblIdModificar);
            this.groupBox1.Location = new System.Drawing.Point(36, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(167, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modificar";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(11, 57);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtIdModificar
            // 
            this.txtIdModificar.Location = new System.Drawing.Point(47, 19);
            this.txtIdModificar.Name = "txtIdModificar";
            this.txtIdModificar.Size = new System.Drawing.Size(100, 20);
            this.txtIdModificar.TabIndex = 1;
            this.txtIdModificar.TextChanged += new System.EventHandler(this.txtIdModificar_TextChanged);
            // 
            // lblIdModificar
            // 
            this.lblIdModificar.AutoSize = true;
            this.lblIdModificar.Location = new System.Drawing.Point(6, 25);
            this.lblIdModificar.Name = "lblIdModificar";
            this.lblIdModificar.Size = new System.Drawing.Size(16, 13);
            this.lblIdModificar.TabIndex = 0;
            this.lblIdModificar.Text = "Id";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.lblIdEliminar);
            this.groupBox2.Controls.Add(this.txtIdEliminar);
            this.groupBox2.Location = new System.Drawing.Point(230, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Eliminar";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(9, 57);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // lblIdEliminar
            // 
            this.lblIdEliminar.AutoSize = true;
            this.lblIdEliminar.Location = new System.Drawing.Point(6, 26);
            this.lblIdEliminar.Name = "lblIdEliminar";
            this.lblIdEliminar.Size = new System.Drawing.Size(16, 13);
            this.lblIdEliminar.TabIndex = 3;
            this.lblIdEliminar.Text = "Id";
            // 
            // txtIdEliminar
            // 
            this.txtIdEliminar.Location = new System.Drawing.Point(28, 18);
            this.txtIdEliminar.Name = "txtIdEliminar";
            this.txtIdEliminar.Size = new System.Drawing.Size(100, 20);
            this.txtIdEliminar.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnVender);
            this.groupBox3.Controls.Add(this.lblIdVender);
            this.groupBox3.Controls.Add(this.txtIdVender);
            this.groupBox3.Location = new System.Drawing.Point(460, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Vender";
            // 
            // btnVender
            // 
            this.btnVender.Location = new System.Drawing.Point(9, 57);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(75, 23);
            this.btnVender.TabIndex = 5;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // lblIdVender
            // 
            this.lblIdVender.AutoSize = true;
            this.lblIdVender.Location = new System.Drawing.Point(6, 26);
            this.lblIdVender.Name = "lblIdVender";
            this.lblIdVender.Size = new System.Drawing.Size(16, 13);
            this.lblIdVender.TabIndex = 3;
            this.lblIdVender.Text = "Id";
            // 
            // txtIdVender
            // 
            this.txtIdVender.Location = new System.Drawing.Point(28, 18);
            this.txtIdVender.Name = "txtIdVender";
            this.txtIdVender.Size = new System.Drawing.Size(100, 20);
            this.txtIdVender.TabIndex = 4;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(157, 413);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(95, 46);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // colId
            // 
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // colMarca
            // 
            this.colMarca.HeaderText = "Marca";
            this.colMarca.Name = "colMarca";
            this.colMarca.ReadOnly = true;
            // 
            // colModelo
            // 
            this.colModelo.HeaderText = "Modelo";
            this.colModelo.Name = "colModelo";
            this.colModelo.ReadOnly = true;
            // 
            // colColor
            // 
            this.colColor.HeaderText = "Color";
            this.colColor.Name = "colColor";
            this.colColor.ReadOnly = true;
            // 
            // colCondicion
            // 
            this.colCondicion.HeaderText = "Condición";
            this.colCondicion.Name = "colCondicion";
            this.colCondicion.ReadOnly = true;
            // 
            // colKm
            // 
            this.colKm.HeaderText = "Km";
            this.colKm.Name = "colKm";
            this.colKm.ReadOnly = true;
            // 
            // colEquipamiento
            // 
            this.colEquipamiento.HeaderText = "Equipamiento";
            this.colEquipamiento.Name = "colEquipamiento";
            this.colEquipamiento.ReadOnly = true;
            // 
            // colPuertas
            // 
            this.colPuertas.HeaderText = "Puertas";
            this.colPuertas.Name = "colPuertas";
            this.colPuertas.ReadOnly = true;
            // 
            // colDescripcion
            // 
            this.colDescripcion.HeaderText = "Descripción";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.ReadOnly = true;
            // 
            // FrmBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 481);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DgvAutos);
            this.Controls.Add(this.BtnVolverBuscar);
            this.Name = "FrmBuscar";
            this.Text = "Buscar";
            ((System.ComponentModel.ISupportInitialize)(this.DgvAutos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnVolverBuscar;
        private System.Windows.Forms.DataGridView DgvAutos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtIdModificar;
        private System.Windows.Forms.Label lblIdModificar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblIdEliminar;
        private System.Windows.Forms.TextBox txtIdEliminar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Label lblIdVender;
        private System.Windows.Forms.TextBox txtIdVender;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCondicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKm;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEquipamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPuertas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
    }
}