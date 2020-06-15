using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace consecionariaYoBa
{
    public partial class FrmMediosPago : Form
    {
        private FrmBuscar frmBuscar;
        private FrmCliente frmCliente;
        private int idVenta;
       
        public FrmMediosPago(FrmCliente cliente, FrmBuscar buscar)
        {          
            InitializeComponent();
            frmCliente = cliente;
            frmBuscar = buscar;         
        }

        public void cargarIdVenta(int id)
        {
            idVenta = id;
        }

        private void btnVolverVender_Click(object sender, EventArgs e)
        {
            frmCliente.Show();
            this.Hide();
        }

        private void radioTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            lblTarjeta.Visible = true;
            txtTarjeta.Visible = true;
            lblCuotas.Visible = true;
            comboCuotas.Visible = true;
        }

        private void radioEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            lblTarjeta.Visible = false;
            txtTarjeta.Visible = false;
            lblCuotas.Visible = false;
            comboCuotas.Visible = false;
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            Consecionaria cons = new Consecionaria();
            ModuloComercial modulo = new ModuloComercial();
            Venta venta;
            Auto autoaux;

            string nomAp_aux = "";
            string tipoDoc_aux = "";          
            string direc_aux = "";
            string medioPago_aux = "";
            double numTarjeta_aux = 0;
            int numCuotas_aux = 0;
            int numDoc_aux = 0;
            //Llamamos al formulario anterior para obtener los datos cargados en el paso 1
            frmCliente.obtenerDatosCliente(ref nomAp_aux, ref tipoDoc_aux, ref numDoc_aux, ref direc_aux);

            if (radioEfectivo.Checked == true)
            {
                medioPago_aux = "Efectivo";
            }
            else
            {
                medioPago_aux = "Tarjeta";

                if (!Double.TryParse(txtTarjeta.Text, out numTarjeta_aux))
                {
                    Console.WriteLine($@"No se pudo convertir'{txtTarjeta.Text}'");
                }
                if (!Int32.TryParse(comboCuotas.Text, out numCuotas_aux))
                {
                    Console.WriteLine($@"No se pudo convertir'{comboCuotas.Text}'");
                }
            }
            //Vamos a buscar un auto a partir de su ID a la lista de Autos de consecionaria
            autoaux = cons.devolverAutoPorId(idVenta);

            venta = new Venta(idVenta, nomAp_aux, tipoDoc_aux, numDoc_aux, direc_aux, medioPago_aux, numTarjeta_aux, numCuotas_aux, autoaux.devolverMarca(), autoaux.devolverModelo(), autoaux.devolverPrecio());
            //Agregamos la venta a la lista de Ventas del módulo comercial
            modulo.agregarVentaModuloComercial(venta);
            //Se graba el archivo de Ventas con la lista de ventas del módulo comercial
            Administracion.actualizarVentasArchivo(modulo);
            //Se elimina el auto de la lista de auto de consecionaria
            cons.eliminarAutoConsecionaria(idVenta);
            //Se graba el archivo de autos con la lista de autos de consecionaria
            Administracion.actualizarAutosArchivo(cons);
            MessageBox.Show("Auto vendido correctamente");
            //Se inicializan los campos del formulario
            radioEfectivo.Checked = true;
            txtTarjeta.Text = "";
            comboCuotas.Text = "";
            frmCliente.InicializarFormulario();

            frmBuscar.Show();
            this.Hide();
            frmBuscar.CargaGrillaAutos();

        }
    }
}
