namespace pryApellidoGimnasio
{
    partial class frmInscripcion
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
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblEstudiante = new System.Windows.Forms.Label();
            this.chkEstudiante = new System.Windows.Forms.CheckBox();
            this.cboPlan = new System.Windows.Forms.ComboBox();
            this.lblPlan = new System.Windows.Forms.Label();
            this.lblTurno = new System.Windows.Forms.Label();
            this.cboTurno = new System.Windows.Forms.ComboBox();
            this.lblMeses = new System.Windows.Forms.Label();
            this.txtMeses = new System.Windows.Forms.TextBox();
            this.chkCasillero = new System.Windows.Forms.CheckBox();
            this.lblCasillero = new System.Windows.Forms.Label();
            this.lblPago = new System.Windows.Forms.Label();
            this.rbtEfectivo = new System.Windows.Forms.RadioButton();
            this.rbtTarjeta = new System.Windows.Forms.RadioButton();
            this.gpbPago = new System.Windows.Forms.GroupBox();
            this.cboCuotas = new System.Windows.Forms.ComboBox();
            this.lblCuotas = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.gpbPago.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(79, 83);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(55, 20);
            this.txtEdad.TabIndex = 0;
            this.txtEdad.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(79, 57);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(110, 20);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(26, 64);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(26, 89);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(35, 13);
            this.lblEdad.TabIndex = 3;
            this.lblEdad.Text = "Edad:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(26, 30);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(89, 13);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Datos personales";
            // 
            // lblEstudiante
            // 
            this.lblEstudiante.AutoSize = true;
            this.lblEstudiante.Location = new System.Drawing.Point(26, 112);
            this.lblEstudiante.Name = "lblEstudiante";
            this.lblEstudiante.Size = new System.Drawing.Size(63, 13);
            this.lblEstudiante.TabIndex = 5;
            this.lblEstudiante.Text = "Estudiante?";
            // 
            // chkEstudiante
            // 
            this.chkEstudiante.AutoSize = true;
            this.chkEstudiante.Location = new System.Drawing.Point(100, 111);
            this.chkEstudiante.Name = "chkEstudiante";
            this.chkEstudiante.Size = new System.Drawing.Size(15, 14);
            this.chkEstudiante.TabIndex = 6;
            this.chkEstudiante.UseVisualStyleBackColor = true;
            // 
            // cboPlan
            // 
            this.cboPlan.FormattingEnabled = true;
            this.cboPlan.Items.AddRange(new object[] {
            "Musculacion",
            "Funcional",
            "Natacion"});
            this.cboPlan.Location = new System.Drawing.Point(79, 147);
            this.cboPlan.Name = "cboPlan";
            this.cboPlan.Size = new System.Drawing.Size(107, 21);
            this.cboPlan.TabIndex = 7;
            // 
            // lblPlan
            // 
            this.lblPlan.AutoSize = true;
            this.lblPlan.Location = new System.Drawing.Point(26, 155);
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Size = new System.Drawing.Size(31, 13);
            this.lblPlan.TabIndex = 8;
            this.lblPlan.Text = "Plan:";
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(26, 181);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(38, 13);
            this.lblTurno.TabIndex = 9;
            this.lblTurno.Text = "Turno:";
            // 
            // cboTurno
            // 
            this.cboTurno.FormattingEnabled = true;
            this.cboTurno.Items.AddRange(new object[] {
            "Mañana",
            "Tarde",
            "Noche"});
            this.cboTurno.Location = new System.Drawing.Point(94, 174);
            this.cboTurno.Name = "cboTurno";
            this.cboTurno.Size = new System.Drawing.Size(107, 21);
            this.cboTurno.TabIndex = 10;
            // 
            // lblMeses
            // 
            this.lblMeses.AutoSize = true;
            this.lblMeses.Location = new System.Drawing.Point(26, 212);
            this.lblMeses.Name = "lblMeses";
            this.lblMeses.Size = new System.Drawing.Size(100, 13);
            this.lblMeses.TabIndex = 11;
            this.lblMeses.Text = "Cantidad de meses:";
            // 
            // txtMeses
            // 
            this.txtMeses.Location = new System.Drawing.Point(132, 205);
            this.txtMeses.Name = "txtMeses";
            this.txtMeses.Size = new System.Drawing.Size(71, 20);
            this.txtMeses.TabIndex = 12;
            this.txtMeses.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // chkCasillero
            // 
            this.chkCasillero.AutoSize = true;
            this.chkCasillero.Location = new System.Drawing.Point(140, 243);
            this.chkCasillero.Name = "chkCasillero";
            this.chkCasillero.Size = new System.Drawing.Size(15, 14);
            this.chkCasillero.TabIndex = 13;
            this.chkCasillero.UseVisualStyleBackColor = true;
            // 
            // lblCasillero
            // 
            this.lblCasillero.AutoSize = true;
            this.lblCasillero.Location = new System.Drawing.Point(25, 243);
            this.lblCasillero.Name = "lblCasillero";
            this.lblCasillero.Size = new System.Drawing.Size(109, 13);
            this.lblCasillero.TabIndex = 14;
            this.lblCasillero.Text = "Casillero ($3000/mes)";
            // 
            // lblPago
            // 
            this.lblPago.AutoSize = true;
            this.lblPago.Location = new System.Drawing.Point(26, 277);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(81, 13);
            this.lblPago.TabIndex = 15;
            this.lblPago.Text = "Forma de pago:";
            // 
            // rbtEfectivo
            // 
            this.rbtEfectivo.AutoSize = true;
            this.rbtEfectivo.Location = new System.Drawing.Point(14, 10);
            this.rbtEfectivo.Name = "rbtEfectivo";
            this.rbtEfectivo.Size = new System.Drawing.Size(64, 17);
            this.rbtEfectivo.TabIndex = 16;
            this.rbtEfectivo.TabStop = true;
            this.rbtEfectivo.Text = "Efectivo";
            this.rbtEfectivo.UseVisualStyleBackColor = true;
            this.rbtEfectivo.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbtTarjeta
            // 
            this.rbtTarjeta.AutoSize = true;
            this.rbtTarjeta.Location = new System.Drawing.Point(94, 10);
            this.rbtTarjeta.Name = "rbtTarjeta";
            this.rbtTarjeta.Size = new System.Drawing.Size(58, 17);
            this.rbtTarjeta.TabIndex = 17;
            this.rbtTarjeta.TabStop = true;
            this.rbtTarjeta.Text = "Tarjeta";
            this.rbtTarjeta.UseVisualStyleBackColor = true;
            // 
            // gpbPago
            // 
            this.gpbPago.Controls.Add(this.rbtTarjeta);
            this.gpbPago.Controls.Add(this.rbtEfectivo);
            this.gpbPago.Location = new System.Drawing.Point(29, 302);
            this.gpbPago.Name = "gpbPago";
            this.gpbPago.Size = new System.Drawing.Size(161, 35);
            this.gpbPago.TabIndex = 18;
            this.gpbPago.TabStop = false;
            // 
            // cboCuotas
            // 
            this.cboCuotas.FormattingEnabled = true;
            this.cboCuotas.Items.AddRange(new object[] {
            "1",
            "3",
            "6"});
            this.cboCuotas.Location = new System.Drawing.Point(76, 354);
            this.cboCuotas.Name = "cboCuotas";
            this.cboCuotas.Size = new System.Drawing.Size(39, 21);
            this.cboCuotas.TabIndex = 19;
            this.cboCuotas.SelectedIndexChanged += new System.EventHandler(this.cboCuotas_SelectedIndexChanged);
            // 
            // lblCuotas
            // 
            this.lblCuotas.AutoSize = true;
            this.lblCuotas.Location = new System.Drawing.Point(26, 357);
            this.lblCuotas.Name = "lblCuotas";
            this.lblCuotas.Size = new System.Drawing.Size(43, 13);
            this.lblCuotas.TabIndex = 20;
            this.lblCuotas.Text = "Cuotas:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(128, 394);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 21;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(51, 394);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 22;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // frmInscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 452);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblCuotas);
            this.Controls.Add(this.cboCuotas);
            this.Controls.Add(this.gpbPago);
            this.Controls.Add(this.lblCasillero);
            this.Controls.Add(this.lblPago);
            this.Controls.Add(this.chkCasillero);
            this.Controls.Add(this.txtMeses);
            this.Controls.Add(this.lblMeses);
            this.Controls.Add(this.cboTurno);
            this.Controls.Add(this.lblTurno);
            this.Controls.Add(this.lblPlan);
            this.Controls.Add(this.cboPlan);
            this.Controls.Add(this.chkEstudiante);
            this.Controls.Add(this.lblEstudiante);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtEdad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmInscripcion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gimnasio Siglo - Inscripcion";
            this.Load += new System.EventHandler(this.frmInscripcion_Load);
            this.gpbPago.ResumeLayout(false);
            this.gpbPago.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblEstudiante;
        private System.Windows.Forms.CheckBox chkEstudiante;
        private System.Windows.Forms.ComboBox cboPlan;
        private System.Windows.Forms.Label lblPlan;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.ComboBox cboTurno;
        private System.Windows.Forms.Label lblMeses;
        private System.Windows.Forms.TextBox txtMeses;
        private System.Windows.Forms.CheckBox chkCasillero;
        private System.Windows.Forms.Label lblCasillero;
        private System.Windows.Forms.Label lblPago;
        private System.Windows.Forms.RadioButton rbtEfectivo;
        private System.Windows.Forms.RadioButton rbtTarjeta;
        private System.Windows.Forms.GroupBox gpbPago;
        private System.Windows.Forms.ComboBox cboCuotas;
        private System.Windows.Forms.Label lblCuotas;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

