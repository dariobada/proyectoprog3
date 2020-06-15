namespace consecionariaYoBa
{
    partial class FrmMediosPago
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
            System.Windows.Forms.Label label1;
            this.radioEfectivo = new System.Windows.Forms.RadioButton();
            this.radioTarjeta = new System.Windows.Forms.RadioButton();
            this.txtTarjeta = new System.Windows.Forms.TextBox();
            this.lblTarjeta = new System.Windows.Forms.Label();
            this.lblCuotas = new System.Windows.Forms.Label();
            this.comboCuotas = new System.Windows.Forms.ComboBox();
            this.btnVender = new System.Windows.Forms.Button();
            this.btnVolverVender = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radioEfectivo
            // 
            this.radioEfectivo.AutoSize = true;
            this.radioEfectivo.Location = new System.Drawing.Point(213, 83);
            this.radioEfectivo.Name = "radioEfectivo";
            this.radioEfectivo.Size = new System.Drawing.Size(64, 17);
            this.radioEfectivo.TabIndex = 2;
            this.radioEfectivo.TabStop = true;
            this.radioEfectivo.Text = "Efectivo";
            this.radioEfectivo.UseVisualStyleBackColor = true;
            this.radioEfectivo.CheckedChanged += new System.EventHandler(this.radioEfectivo_CheckedChanged);
            // 
            // radioTarjeta
            // 
            this.radioTarjeta.AutoSize = true;
            this.radioTarjeta.Location = new System.Drawing.Point(16, 83);
            this.radioTarjeta.Name = "radioTarjeta";
            this.radioTarjeta.Size = new System.Drawing.Size(108, 17);
            this.radioTarjeta.TabIndex = 3;
            this.radioTarjeta.TabStop = true;
            this.radioTarjeta.Text = "Tarjeta de crédito";
            this.radioTarjeta.UseVisualStyleBackColor = true;
            this.radioTarjeta.CheckedChanged += new System.EventHandler(this.radioTarjeta_CheckedChanged);
            // 
            // txtTarjeta
            // 
            this.txtTarjeta.Location = new System.Drawing.Point(36, 137);
            this.txtTarjeta.Name = "txtTarjeta";
            this.txtTarjeta.Size = new System.Drawing.Size(142, 20);
            this.txtTarjeta.TabIndex = 4;
            this.txtTarjeta.Visible = false;

            // 
            // lblTarjeta
            // 
            this.lblTarjeta.AutoSize = true;
            this.lblTarjeta.Location = new System.Drawing.Point(33, 121);
            this.lblTarjeta.Name = "lblTarjeta";
            this.lblTarjeta.Size = new System.Drawing.Size(91, 13);
            this.lblTarjeta.TabIndex = 5;
            this.lblTarjeta.Text = "Número de tarjeta";
            this.lblTarjeta.Visible = false;
     
            // 
            // lblCuotas
            // 
            this.lblCuotas.AutoSize = true;
            this.lblCuotas.Location = new System.Drawing.Point(33, 171);
            this.lblCuotas.Name = "lblCuotas";
            this.lblCuotas.Size = new System.Drawing.Size(99, 13);
            this.lblCuotas.TabIndex = 6;
            this.lblCuotas.Text = "Cantidad de cuotas";
            this.lblCuotas.Visible = false;
            // 
            // comboCuotas
            // 
            this.comboCuotas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCuotas.FormattingEnabled = true;
            this.comboCuotas.Items.AddRange(new object[] {
            "3",
            "6",
            "12"});
            this.comboCuotas.Location = new System.Drawing.Point(36, 187);
            this.comboCuotas.Name = "comboCuotas";
            this.comboCuotas.Size = new System.Drawing.Size(34, 21);
            this.comboCuotas.TabIndex = 7;
            this.comboCuotas.Visible = false;
            // 
            // btnVender
            // 
            this.btnVender.Location = new System.Drawing.Point(299, 247);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(93, 39);
            this.btnVender.TabIndex = 8;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // btnVolverVender
            // 
            this.btnVolverVender.Location = new System.Drawing.Point(183, 247);
            this.btnVolverVender.Name = "btnVolverVender";
            this.btnVolverVender.Size = new System.Drawing.Size(93, 39);
            this.btnVolverVender.TabIndex = 9;
            this.btnVolverVender.Text = "Volver";
            this.btnVolverVender.UseVisualStyleBackColor = true;
            this.btnVolverVender.Click += new System.EventHandler(this.btnVolverVender_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(303, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Paso 2 / 2";
   
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Calibri Light", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(12, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(256, 29);
            label1.TabIndex = 11;
            label1.Text = "Ingrese un medio de pago";
            // 
            // FrmMediosPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 298);
            this.Controls.Add(label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnVolverVender);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.comboCuotas);
            this.Controls.Add(this.lblCuotas);
            this.Controls.Add(this.lblTarjeta);
            this.Controls.Add(this.txtTarjeta);
            this.Controls.Add(this.radioTarjeta);
            this.Controls.Add(this.radioEfectivo);
            this.Name = "FrmMediosPago";
            this.Text = "Medio de pago";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton radioEfectivo;
        private System.Windows.Forms.RadioButton radioTarjeta;
        private System.Windows.Forms.TextBox txtTarjeta;
        private System.Windows.Forms.Label lblTarjeta;
        private System.Windows.Forms.Label lblCuotas;
        private System.Windows.Forms.ComboBox comboCuotas;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Button btnVolverVender;
        private System.Windows.Forms.Label label2;
    }
}