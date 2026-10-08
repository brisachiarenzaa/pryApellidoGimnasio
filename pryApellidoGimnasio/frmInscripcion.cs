using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        const decimal PRECIO_NATACION = 22000m;

        const decimal PRECIO_CASILLERO = 3000m;

        // explicar
        const int EDAD_MINIMA = 14;


        // La m indica que es un numero decimal.
        const decimal DESCUENTO_MENOR = 0.25m;
        const decimal DESCUENTO_MAYOR_65 = 0.30m;
        const decimal DESCUENTO_ESTUDIANTE = 0.15m;

        const decimal DESCUENTO_EFECTIVO = 0.10m;
        const decimal RECARGO_3_CUOTAS = 0.10m;
        const decimal RECARGO_6_CUOTAS = 0.20m;

        struct SOCIO
        {
            public string nombre;
            public int edad;
            public string categoria;
            public string plan;
            public string horario;
            public int meses;
            public string formaPago;
            public decimal total;
            public decimal valorCuota;
        }

        string[] vecSocio = new string[3]; //declara un array de 1 dimension
        //inicializado en 3 elementos (del 0 al 2)
       

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

            rbtEfectivo.Checked = true;
            rbtTarjeta.Checked = false;

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
            // So rbtTarjeta esta marcado, cboCuotas queda habilitado, sino queda deshabilitado
            if (rbtTarjeta.Checked)
            {
                cboCuotas.Enabled = true;
                cboCuotas.SelectedIndex = 0;
            }
            else
            {
                cboCuotas.Enabled = true;
                cboCuotas.SelectedIndex = -1;
            }
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
            decimal valorCuota = 0; 

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

            string horario;

            switch (cboTurno.SelectedIndex)
            {
                case 0:
                    horario = "7 a 12 h";
                    break;

                case 1:
                    horario = "14 a 18 h";
                    break;

                case 2:
                    horario = "18 a 23 h";
                    break;

                default:
                    MessageBox.Show("El turno seleccionado no es valido");
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
                porcentajeDescuento = DESCUENTO_MENOR;
            }
            else
            {
                if (edad >= 65)
                {
                    porcentajeDescuento = DESCUENTO_MAYOR_65;
                }
                else
                {
                    porcentajeDescuento = 0;
                }
            }
            
            // APLICAR DESCUENTOS SEGUN ESTUDIANTE

            if (chkEstudiante.Checked)
                {
                    porcentajeDescuento += DESCUENTO_ESTUDIANTE;
                }

                //  // APLICAR DESCUENTOS SEGUN FORMA DE PAGO (EFECTIVO O TARJETA) Y CANTIDAD DE CUOTAS
                if (rbtEfectivo.Checked)
                {
                    porcentajeAjuste = -DESCUENTO_EFECTIVO;
                    // al ser un *descuento* del 10%, es tratado como negativo
                }

                else
                {
                    int cuotas = int.Parse(cboCuotas.Text);

                    if (cuotas == 1)
                    {
                        porcentajeAjuste = 0;
                    }
                    else if (cuotas == 3)
                    {
                        porcentajeAjuste = RECARGO_3_CUOTAS;
                    }
                    else if (cuotas == 6)
                    {
                        porcentajeAjuste = RECARGO_6_CUOTAS;
                    }
                }

                // Aplicar descuento
                decimal montoDescuento = subtotal * porcentajeDescuento;
                decimal subtotalConDescuento = subtotal - montoDescuento;

                // Aplicar recargo
                decimal montoAjuste = subtotalConDescuento * porcentajeAjuste;
                total = subtotalConDescuento + montoAjuste;

                // OPERADOR TERNARIO:
                string categoria = edad < 18 ? "Menor" : "Mayor";

                string formaPago = rbtEfectivo.Checked
                    ? "Efectivo"
                    : "Tarjeta en " + cboCuotas.Text + " cuotas";

                // Calculo de la cuota
                int cantidadCuotas = rbtEfectivo.Checked ? 1 : int.Parse(cboCuotas.Text);
                valorCuota = total / cantidadCuotas;

                // SOCIO - tipo de dato creado

                SOCIO socio;

                socio.nombre = nombre;
                socio.edad = edad;
                socio.categoria = categoria;
                socio.plan = plan;
                socio.horario = horario;
                socio.meses = meses;
                socio.formaPago = formaPago;
                socio.total = total;
                socio.valorCuota = valorCuota;


            //grabar en un array
            vecSocio[0] = socio.nombre; //concatenar lo que tengo en el struct
            //recuerden que el indice tiene que incrementarse con cada clic
            //y que tiene un tope, 3 elementos (no permitir grabar màs)

            //grabar en un txt
            StreamWriter swDatosGimnasio = new StreamWriter("BaseDatos.txt", true);

            swDatosGimnasio.WriteLine(socio.nombre);
            swDatosGimnasio.WriteLine(socio.plan);
            swDatosGimnasio.WriteLine(socio.valorCuota);
            swDatosGimnasio.WriteLine(socio.total);

            swDatosGimnasio.Close();

            // Mostrar total en un mensaje

            MessageBox.Show("Cliente: " + socio.nombre +
                    "\nEdad: " + socio.edad +
                    "\nCategoria: " + socio.categoria +
                    "\nPlan: " + socio.plan +
                    "\nHorario: " + socio.horario +
                    "\nMeses: " + socio.meses +
                    "\nForma de pago: " + socio.formaPago +
                    "\nSubtotal: $" + subtotal +
                    "\nDescuento: $" + montoDescuento +
                    "\nAjuste: $" + montoAjuste +
                    "\nTotal: $" + socio.total +
                    "\nValor de la cuota: $" + socio.valorCuota,
                    "Resumen de Inscripción"
                );
            }

        private void cboCuotas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            EstadoInicial();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            btnCalcular.Enabled = txtNombre.Text != ""&&
                                  txtEdad.Text != "" &&
                                  txtMeses.Text != "";

        }
    }

}
