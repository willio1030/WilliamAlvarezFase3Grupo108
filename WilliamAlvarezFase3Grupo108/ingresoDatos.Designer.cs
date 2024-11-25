namespace WilliamAlvarezFase3Grupo108
{
    partial class frmIngresodatos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbTipoestructura = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.dtskAcceso = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.txtedad = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtITipoidentificacion = new System.Windows.Forms.TextBox();
            this.grpbtipoAtencion = new System.Windows.Forms.GroupBox();
            this.rtbnExameneslaboratorio = new System.Windows.Forms.RadioButton();
            this.rtbnmedicinaGeneral = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.txtReportedatos = new System.Windows.Forms.TextBox();
            this.txtValorpago = new System.Windows.Forms.TextBox();
            this.cmbEstrato = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cmbIdentificacion = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpbtipoAtencion.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.cmbTipoestructura);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.btnRegistrar);
            this.groupBox1.Controls.Add(this.dtskAcceso);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtedad);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtITipoidentificacion);
            this.groupBox1.Controls.Add(this.grpbtipoAtencion);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtReportedatos);
            this.groupBox1.Controls.Add(this.txtValorpago);
            this.groupBox1.Controls.Add(this.cmbEstrato);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.cmbIdentificacion);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(54, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(885, 571);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Usuario";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 458);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(830, 106);
            this.dataGridView1.TabIndex = 25;
            // 
            // cmbTipoestructura
            // 
            this.cmbTipoestructura.FormattingEnabled = true;
            this.cmbTipoestructura.Location = new System.Drawing.Point(186, 328);
            this.cmbTipoestructura.Name = "cmbTipoestructura";
            this.cmbTipoestructura.Size = new System.Drawing.Size(224, 24);
            this.cmbTipoestructura.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(487, 392);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(290, 16);
            this.label12.TabIndex = 23;
            this.label12.Text = "los campos marcados con (*) son obligatorios";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalir.Location = new System.Drawing.Point(775, 346);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 22;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiar.Location = new System.Drawing.Point(650, 346);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 21;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegistrar.Location = new System.Drawing.Point(490, 346);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 20;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // dtskAcceso
            // 
            this.dtskAcceso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtskAcceso.Location = new System.Drawing.Point(650, 264);
            this.dtskAcceso.Name = "dtskAcceso";
            this.dtskAcceso.Size = new System.Drawing.Size(200, 24);
            this.dtskAcceso.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(478, 264);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 16);
            this.label11.TabIndex = 18;
            this.label11.Text = "Fecha de Acceso";
            // 
            // txtedad
            // 
            this.txtedad.Location = new System.Drawing.Point(650, 98);
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(224, 24);
            this.txtedad.TabIndex = 17;
            this.txtedad.TextChanged += new System.EventHandler(this.txtedad_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(478, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "* Edad:";
            // 
            // txtITipoidentificacion
            // 
            this.txtITipoidentificacion.Location = new System.Drawing.Point(650, 32);
            this.txtITipoidentificacion.Name = "txtITipoidentificacion";
            this.txtITipoidentificacion.Size = new System.Drawing.Size(224, 24);
            this.txtITipoidentificacion.TabIndex = 15;
            this.txtITipoidentificacion.TextChanged += new System.EventHandler(this.txtITipoidentificacion_TextChanged);
            // 
            // grpbtipoAtencion
            // 
            this.grpbtipoAtencion.Controls.Add(this.rtbnExameneslaboratorio);
            this.grpbtipoAtencion.Controls.Add(this.rtbnmedicinaGeneral);
            this.grpbtipoAtencion.Location = new System.Drawing.Point(461, 163);
            this.grpbtipoAtencion.Name = "grpbtipoAtencion";
            this.grpbtipoAtencion.Size = new System.Drawing.Size(413, 61);
            this.grpbtipoAtencion.TabIndex = 14;
            this.grpbtipoAtencion.TabStop = false;
            this.grpbtipoAtencion.Text = "Tipo de Atencion";
            // 
            // rtbnExameneslaboratorio
            // 
            this.rtbnExameneslaboratorio.AutoSize = true;
            this.rtbnExameneslaboratorio.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbnExameneslaboratorio.Location = new System.Drawing.Point(224, 26);
            this.rtbnExameneslaboratorio.Name = "rtbnExameneslaboratorio";
            this.rtbnExameneslaboratorio.Size = new System.Drawing.Size(172, 20);
            this.rtbnExameneslaboratorio.TabIndex = 1;
            this.rtbnExameneslaboratorio.TabStop = true;
            this.rtbnExameneslaboratorio.Text = "Examanes de laboratorio";
            this.rtbnExameneslaboratorio.UseVisualStyleBackColor = true;
            // 
            // rtbnmedicinaGeneral
            // 
            this.rtbnmedicinaGeneral.AutoSize = true;
            this.rtbnmedicinaGeneral.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbnmedicinaGeneral.Location = new System.Drawing.Point(45, 26);
            this.rtbnmedicinaGeneral.Name = "rtbnmedicinaGeneral";
            this.rtbnmedicinaGeneral.Size = new System.Drawing.Size(126, 20);
            this.rtbnmedicinaGeneral.TabIndex = 0;
            this.rtbnmedicinaGeneral.TabStop = true;
            this.rtbnmedicinaGeneral.Text = "Medicina general";
            this.rtbnmedicinaGeneral.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(478, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = " * N de Identificacion:";
            // 
            // txtReportedatos
            // 
            this.txtReportedatos.Location = new System.Drawing.Point(186, 384);
            this.txtReportedatos.Name = "txtReportedatos";
            this.txtReportedatos.Size = new System.Drawing.Size(224, 24);
            this.txtReportedatos.TabIndex = 12;
            // 
            // txtValorpago
            // 
            this.txtValorpago.Location = new System.Drawing.Point(186, 256);
            this.txtValorpago.Name = "txtValorpago";
            this.txtValorpago.Size = new System.Drawing.Size(224, 24);
            this.txtValorpago.TabIndex = 10;
            // 
            // cmbEstrato
            // 
            this.cmbEstrato.FormattingEnabled = true;
            this.cmbEstrato.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cmbEstrato.Location = new System.Drawing.Point(186, 179);
            this.cmbEstrato.Name = "cmbEstrato";
            this.cmbEstrato.Size = new System.Drawing.Size(224, 24);
            this.cmbEstrato.TabIndex = 9;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(186, 98);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(224, 24);
            this.txtNombre.TabIndex = 8;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // cmbIdentificacion
            // 
            this.cmbIdentificacion.FormattingEnabled = true;
            this.cmbIdentificacion.Items.AddRange(new object[] {
            "CC",
            "CE",
            "NUIP",
            "PAS"});
            this.cmbIdentificacion.Location = new System.Drawing.Point(186, 34);
            this.cmbIdentificacion.Name = "cmbIdentificacion";
            this.cmbIdentificacion.Size = new System.Drawing.Size(224, 24);
            this.cmbIdentificacion.TabIndex = 7;
            this.cmbIdentificacion.SelectedIndexChanged += new System.EventHandler(this.cmbIdentificacion_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 392);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 16);
            this.label9.TabIndex = 6;
            this.label9.Text = "Reporte de Datos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Tipo de Estructura: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Valor de Copago";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "* Estrato SocioEconomico:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "* Nombre Completo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "* Tipo de Identificacion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(345, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(315, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "SISTEMA DE REGISTRO DE USUARIOS EN CENTRO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(448, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "EPS Salvando Vidas";
            // 
            // frmIngresodatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 679);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmIngresodatos";
            this.Text = "ingresoDatos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpbtipoAtencion.ResumeLayout(false);
            this.grpbtipoAtencion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValorpago;
        private System.Windows.Forms.ComboBox cmbEstrato;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cmbIdentificacion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtITipoidentificacion;
        private System.Windows.Forms.GroupBox grpbtipoAtencion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtReportedatos;
        private System.Windows.Forms.TextBox txtedad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DateTimePicker dtskAcceso;
        private System.Windows.Forms.RadioButton rtbnExameneslaboratorio;
        private System.Windows.Forms.RadioButton rtbnmedicinaGeneral;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbTipoestructura;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}