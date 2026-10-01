using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryApellidoGimnasio
{
    public partial class frmInscripcion : Form
    {
        const decimal PRECIO_MUSCULACION = 15000m;
        const decimal PRECIO_FUNCIONAL = 18000m;
        const decimal PRECIO_NATACION = 25000m;

        const decimal PRECIO_CASILLERO = 3000m;

        const int EDAD_MINIMA = 14;

        const decimal DESCUENTO_MENOR = 0.25m;
        const decimal DESCUENTO_MAYOR_65 = 0.30m;
        const decimal DESCUENTO_ESTUDIANTE = 0.15m;

        const decimal DESCUENTO_EFECTIVO = 0.10m;
        const decimal RECARGO_3_CUOTAS = 0.10m;
        const decimal RECARGO_6_CUOTAS = 0.20m;


        public frmInscripcion()
        {
            InitializeComponent();
        }

        private void EstadoInicial()
        {
            txtNombre.Text = "";
            txtEdad.Text = "";
            chkEstudiante.Checked = false;

            cboPlan.SelectedIndex = 0;
            cboTurno.SelectedIndex = 0;

            txtMeses.Text = "1";
            chkCasillero.Checked = false;

            rbtEfectivo.Checked = false;
            rbtTarjeta.Checked = true;

            cboCuotas.SelectedIndex = -1;
            cboCuotas.Enabled = false;

            btnCalcular.Enabled = false;

            txtNombre.Focus();

        }

        private void frmInscripcion_Load(object sender, EventArgs e)
        {
            EstadoInicial();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string nombre;
            int edad;
            int meses;
            decimal precioMensual;
            decimal subtotal;
            decimal porcentajeDescuento;
            decimal porcentajeAjuste;
            decimal total;
            decimal valorCuota;



        }
    }
}
