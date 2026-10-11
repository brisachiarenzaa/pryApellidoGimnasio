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
            this.txtEdad.Location = new System.Drawing.Point(105, 102);
            this.txtEdad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(72, 22);
            this.txtEdad.TabIndex = 0;
            this.txtEdad.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(105, 70);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(145, 22);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(35, 79);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 16);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(35, 110);
            this.lblEdad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(43, 16);
            this.lblEdad.TabIndex = 3;
            this.lblEdad.Text = "Edad:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(35, 37);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(114, 16);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Datos personales";
            // 
            // lblEstudiante
            // 
            this.lblEstudiante.AutoSize = true;
            this.lblEstudiante.Location = new System.Drawing.Point(35, 138);
            this.lblEstudiante.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstudiante.Name = "lblEstudiante";
            this.lblEstudiante.Size = new System.Drawing.Size(77, 16);
            this.lblEstudiante.TabIndex = 5;
            this.lblEstudiante.Text = "Estudiante?";
            // 
            // chkEstudiante
            // 
            this.chkEstudiante.AutoSize = true;
            this.chkEstudiante.Location = new System.Drawing.Point(133, 137);
            this.chkEstudiante.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkEstudiante.Name = "chkEstudiante";
            this.chkEstudiante.Size = new System.Drawing.Size(18, 17);
            this.chkEstudiante.TabIndex = 6;
            this.chkEstudiante.UseVisualStyleBackColor = true;
            // 
            // cboPlan
            // 
            this.cboPlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPlan.FormattingEnabled = true;
            this.cboPlan.Items.AddRange(new object[] {
            "Musculacion",
            "Funcional",
            "Natacion"});
            this.cboPlan.Location = new System.Drawing.Point(88, 183);
            this.cboPlan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboPlan.Name = "cboPlan";
            this.cboPlan.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboPlan.Size = new System.Drawing.Size(141, 24);
            this.cboPlan.TabIndex = 7;
            this.cboPlan.SelectedIndexChanged += new System.EventHandler(this.cboPlan_SelectedIndexChanged);
            // 
            // lblPlan
            // 
            this.lblPlan.AutoSize = true;
            this.lblPlan.Location = new System.Drawing.Point(35, 191);
            this.lblPlan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Size = new System.Drawing.Size(37, 16);
            this.lblPlan.TabIndex = 8;
            this.lblPlan.Text = "Plan:";
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(35, 223);
            this.lblTurno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(45, 16);
            this.lblTurno.TabIndex = 9;
            this.lblTurno.Text = "Turno:";
            // 
            // cboTurno
            // 
            this.cboTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTurno.FormattingEnabled = true;
            this.cboTurno.Items.AddRange(new object[] {
            "Mañana",
            "Tarde",
            "Noche"});
            this.cboTurno.Location = new System.Drawing.Point(88, 215);
            this.cboTurno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboTurno.Name = "cboTurno";
            this.cboTurno.Size = new System.Drawing.Size(141, 24);
            this.cboTurno.TabIndex = 10;
            // 
            // lblMeses
            // 
            this.lblMeses.AutoSize = true;
            this.lblMeses.Location = new System.Drawing.Point(35, 261);
            this.lblMeses.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMeses.Name = "lblMeses";
            this.lblMeses.Size = new System.Drawing.Size(127, 16);
            this.lblMeses.TabIndex = 11;
            this.lblMeses.Text = "Cantidad de meses:";
            // 
            // txtMeses
            // 
            this.txtMeses.Location = new System.Drawing.Point(176, 252);
            this.txtMeses.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMeses.Name = "txtMeses";
            this.txtMeses.Size = new System.Drawing.Size(93, 22);
            this.txtMeses.TabIndex = 12;
            this.txtMeses.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // chkCasillero
            // 
            this.chkCasillero.AutoSize = true;
            this.chkCasillero.Location = new System.Drawing.Point(187, 299);
            this.chkCasillero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkCasillero.Name = "chkCasillero";
            this.chkCasillero.Size = new System.Drawing.Size(18, 17);
            this.chkCasillero.TabIndex = 13;
            this.chkCasillero.UseVisualStyleBackColor = true;
            // 
            // lblCasillero
            // 
            this.lblCasillero.AutoSize = true;
            this.lblCasillero.Location = new System.Drawing.Point(33, 299);
            this.lblCasillero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCasillero.Name = "lblCasillero";
            this.lblCasillero.Size = new System.Drawing.Size(136, 16);
            this.lblCasillero.TabIndex = 14;
            this.lblCasillero.Text = "Casillero ($3000/mes)";
            // 
            // lblPago
            // 
            this.lblPago.AutoSize = true;
            this.lblPago.Location = new System.Drawing.Point(35, 341);
            this.lblPago.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(103, 16);
            this.lblPago.TabIndex = 15;
            this.lblPago.Text = "Forma de pago:";
            // 
            // rbtEfectivo
            // 
            this.rbtEfectivo.AutoSize = true;
            this.rbtEfectivo.Location = new System.Drawing.Point(19, 12);
            this.rbtEfectivo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtEfectivo.Name = "rbtEfectivo";
            this.rbtEfectivo.Size = new System.Drawing.Size(76, 20);
            this.rbtEfectivo.TabIndex = 16;
            this.rbtEfectivo.TabStop = true;
            this.rbtEfectivo.Text = "Efectivo";
            this.rbtEfectivo.UseVisualStyleBackColor = true;
            this.rbtEfectivo.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbtTarjeta
            // 
            this.rbtTarjeta.AutoSize = true;
            this.rbtTarjeta.Location = new System.Drawing.Point(125, 12);
            this.rbtTarjeta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtTarjeta.Name = "rbtTarjeta";
            this.rbtTarjeta.Size = new System.Drawing.Size(71, 20);
            this.rbtTarjeta.TabIndex = 17;
            this.rbtTarjeta.TabStop = true;
            this.rbtTarjeta.Text = "Tarjeta";
            this.rbtTarjeta.UseVisualStyleBackColor = true;
            // 
            // gpbPago
            // 
            this.gpbPago.Controls.Add(this.rbtTarjeta);
            this.gpbPago.Controls.Add(this.rbtEfectivo);
            this.gpbPago.Location = new System.Drawing.Point(39, 372);
            this.gpbPago.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbPago.Name = "gpbPago";
            this.gpbPago.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbPago.Size = new System.Drawing.Size(215, 43);
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
            this.cboCuotas.Location = new System.Drawing.Point(101, 436);
            this.cboCuotas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboCuotas.Name = "cboCuotas";
            this.cboCuotas.Size = new System.Drawing.Size(51, 24);
            this.cboCuotas.TabIndex = 19;
            this.cboCuotas.SelectedIndexChanged += new System.EventHandler(this.cboCuotas_SelectedIndexChanged);
            // 
            // lblCuotas
            // 
            this.lblCuotas.AutoSize = true;
            this.lblCuotas.Location = new System.Drawing.Point(35, 439);
            this.lblCuotas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCuotas.Name = "lblCuotas";
            this.lblCuotas.Size = new System.Drawing.Size(52, 16);
            this.lblCuotas.TabIndex = 20;
            this.lblCuotas.Text = "Cuotas:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(171, 485);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 28);
            this.btnCalcular.TabIndex = 21;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(68, 485);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 28);
            this.btnLimpiar.TabIndex = 22;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // frmInscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 556);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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

