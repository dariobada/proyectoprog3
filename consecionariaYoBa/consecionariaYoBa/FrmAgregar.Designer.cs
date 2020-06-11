namespace consecionariaYoBa
{
    partial class FrmAgregar
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPuertas = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboColor = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblKm = new System.Windows.Forms.Label();
            this.txtKm = new System.Windows.Forms.TextBox();
            this.radioUsado = new System.Windows.Forms.RadioButton();
            this.radioNuevo = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.checkABS = new System.Windows.Forms.CheckBox();
            this.checkAir = new System.Windows.Forms.CheckBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnVolverAgregar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar un Auto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marca";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(127, 74);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(149, 20);
            this.txtMarca.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Modelo";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(127, 100);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(149, 20);
            this.txtModelo.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Puertas";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtPuertas
            // 
            this.txtPuertas.Location = new System.Drawing.Point(127, 126);
            this.txtPuertas.Name = "txtPuertas";
            this.txtPuertas.Size = new System.Drawing.Size(149, 20);
            this.txtPuertas.TabIndex = 2;
            this.txtPuertas.TextChanged += new System.EventHandler(this.txtPuertas_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(63, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Color";
            this.label5.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboColor
            // 
            this.comboColor.FormattingEnabled = true;
            this.comboColor.Location = new System.Drawing.Point(127, 152);
            this.comboColor.Name = "comboColor";
            this.comboColor.Size = new System.Drawing.Size(149, 21);
            this.comboColor.TabIndex = 3;
            this.comboColor.SelectedIndexChanged += new System.EventHandler(this.comboColor_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblKm);
            this.groupBox1.Controls.Add(this.txtKm);
            this.groupBox1.Controls.Add(this.radioUsado);
            this.groupBox1.Controls.Add(this.radioNuevo);
            this.groupBox1.Location = new System.Drawing.Point(58, 237);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 149);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Condición";
            // 
            // lblKm
            // 
            this.lblKm.AutoSize = true;
            this.lblKm.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKm.Location = new System.Drawing.Point(122, 75);
            this.lblKm.Name = "lblKm";
            this.lblKm.Size = new System.Drawing.Size(28, 18);
            this.lblKm.TabIndex = 3;
            this.lblKm.Text = "Km";
            this.lblKm.Visible = false;
            // 
            // txtKm
            // 
            this.txtKm.Location = new System.Drawing.Point(156, 76);
            this.txtKm.Multiline = true;
            this.txtKm.Name = "txtKm";
            this.txtKm.Size = new System.Drawing.Size(131, 17);
            this.txtKm.TabIndex = 2;
            this.txtKm.Visible = false;
            // 
            // radioUsado
            // 
            this.radioUsado.AutoSize = true;
            this.radioUsado.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioUsado.Location = new System.Drawing.Point(24, 70);
            this.radioUsado.Name = "radioUsado";
            this.radioUsado.Size = new System.Drawing.Size(64, 22);
            this.radioUsado.TabIndex = 1;
            this.radioUsado.TabStop = true;
            this.radioUsado.Text = "Usado";
            this.radioUsado.UseVisualStyleBackColor = true;
            this.radioUsado.CheckedChanged += new System.EventHandler(this.radioUsado_CheckedChanged);
            // 
            // radioNuevo
            // 
            this.radioNuevo.AutoSize = true;
            this.radioNuevo.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioNuevo.Location = new System.Drawing.Point(23, 38);
            this.radioNuevo.Name = "radioNuevo";
            this.radioNuevo.Size = new System.Drawing.Size(67, 22);
            this.radioNuevo.TabIndex = 0;
            this.radioNuevo.TabStop = true;
            this.radioNuevo.Text = "Nuevo";
            this.radioNuevo.UseVisualStyleBackColor = true;
            this.radioNuevo.CheckedChanged += new System.EventHandler(this.radioNuevo_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(63, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 19);
            this.label6.TabIndex = 1;
            this.label6.Click += new System.EventHandler(this.label2_Click);
            // 
            // checkABS
            // 
            this.checkABS.AutoSize = true;
            this.checkABS.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkABS.Location = new System.Drawing.Point(15, 48);
            this.checkABS.Name = "checkABS";
            this.checkABS.Size = new System.Drawing.Size(53, 23);
            this.checkABS.TabIndex = 5;
            this.checkABS.Text = "ABS";
            this.checkABS.UseVisualStyleBackColor = true;
            this.checkABS.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkAir
            // 
            this.checkAir.AutoSize = true;
            this.checkAir.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkAir.Location = new System.Drawing.Point(15, 19);
            this.checkAir.Name = "checkAir";
            this.checkAir.Size = new System.Drawing.Size(77, 23);
            this.checkAir.TabIndex = 5;
            this.checkAir.Text = "Airbags";
            this.checkAir.UseVisualStyleBackColor = true;
            this.checkAir.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAceptar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(530, 407);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(135, 48);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnVolverAgregar
            // 
            this.btnVolverAgregar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnVolverAgregar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverAgregar.Location = new System.Drawing.Point(351, 407);
            this.btnVolverAgregar.Name = "btnVolverAgregar";
            this.btnVolverAgregar.Size = new System.Drawing.Size(135, 48);
            this.btnVolverAgregar.TabIndex = 7;
            this.btnVolverAgregar.Text = "Volver";
            this.btnVolverAgregar.UseVisualStyleBackColor = true;
            this.btnVolverAgregar.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkAir);
            this.groupBox2.Controls.Add(this.checkABS);
            this.groupBox2.Location = new System.Drawing.Point(406, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 102);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Equipamiento";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(406, 247);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(215, 139);
            this.txtDescripcion.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(403, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Descripción";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // FrmAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 469);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnVolverAgregar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboColor);
            this.Controls.Add(this.txtPuertas);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmAgregar";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPuertas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboColor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtKm;
        private System.Windows.Forms.RadioButton radioUsado;
        private System.Windows.Forms.RadioButton radioNuevo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkABS;
        private System.Windows.Forms.CheckBox checkAir;
        private System.Windows.Forms.Label lblKm;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnVolverAgregar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label8;
    }
}

