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
            cboCuotas.Enabled = rbtTarjeta.Checked;

            btnCalcular.Enabled = false;

            txtNombre.Focus();

        }

        private void frmInscripcion_Load(object sender, EventArgs e)
        {
            EstadoInicial();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // So rbtTarjeta esta marcado, cboCuotas queda habilitado, sino queda deshabilitado
            cboCuotas.Enabled = rbtTarjeta.Checked;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            // DECLARACION DE VARIABLES
            string nombre;
            int edad;
            int meses;
            decimal precioMensual;
            decimal subtotal;
            decimal porcentajeDescuento;
            decimal porcentajeAjuste;
            decimal total;
            decimal valorCuota;


            nombre = txtNombre.Text;
            edad = int.Parse(txtEdad.Text);
            meses = int.Parse(txtMeses.Text);


            if (edad < EDAD_MINIMA)
            {
                MessageBox.Show("La edad minima para inscribirse es de 14 años, intentelo de nuevo");
                return;
            }

            if (meses < 1 || meses > 12)
            {
                MessageBox.Show("La cantidad de meses debe estar entre 1 y 12, intentelo de nuevo");
                return;

                // BARRAS || = UTILIZADAS P DETECTAR SI ESTA POR DEBAJO DE 1 O POR ENCIMA DE 12

            }


            // GUARDA EN UNA VARIABLE LLAMADA "PLAN" EL TEXTO SELECCIONADO EN EL COMBOBOX
            string plan = cboPlan.Text;


            // SWITCH (PLAN) = PARA VER QUE PLAN SELECCIONO EL USUARIO Y ASIGNAR EL PRECIO MENSUAL
            // EJ: PLAN = "FUNCIONAL" -> precioMensual = PRECIO_FUNCIONAL ($18000)

            switch (plan)
            {
                case "Musculación":
                    precioMensual = PRECIO_MUSCULACION;
                    break;

                case "Funcional":
                    precioMensual = PRECIO_FUNCIONAL;
                    break;

                case "Natacion":
                    precioMensual = PRECIO_NATACION;
                    break;

                // SI NINGUNA DE LAS OPCIONES COINCIDE:

                default:
                    MessageBox.Show("El plan seleccionado no es valido, intentelo de nuevo");
                    return;
            }

            //+= -> sumarle algo a lo que ya tiene
            if (chkCasillero.Checked) precioMensual += PRECIO_CASILLERO;

            // SUBTOTAL: variable que guarda el precio antes de aplicar descuentos/recargos
            subtotal = precioMensual * meses;

            // PORCENTAJE DE DESCUENTO: variable que guarda el porcentaje de descuento a aplicar
            porcentajeDescuento = 0;

            // PORCENTAJE DE AJUSTE: variable que guarda el recargo a aplicar
            porcentajeAjuste = 0;


            // APLICAR DESCUENTOS SEGUN EDAD
            if (edad < 18)
            {
                porcentajeDescuento += DESCUENTO_MENOR;
            }
            else if (edad > 65)
            {
                porcentajeDescuento += DESCUENTO_MAYOR_65;
            }

            // // APLICAR DESCUENTOS SEGUN ESTUDIANTE

            if (chkEstudiante.Checked)
            {
                porcentajeDescuento += DESCUENTO_ESTUDIANTE;
            }

            //  // APLICAR DESCUENTOS SEGUN FORMA DE PAGO (EFECTIVO O TARJETA) Y CANTIDAD DE CUOTAS
            if (rbtEfectivo.Checked)
            {
                porcentajeDescuento += DESCUENTO_EFECTIVO;
            }

            if (rbtTarjeta.Checked)
            {
                if (cboCuotas.Text == "3")
                    porcentajeAjuste += RECARGO_3_CUOTAS;
                else if (cboCuotas.Text == "6")
                    porcentajeAjuste += RECARGO_6_CUOTAS;
            }    

        }

        private void cboCuotas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            EstadoInicial();
        }

        // falta calcular el total y mostrarlo en un mensaje :)
    }

}
