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
    public partial class FrmCliente : Form
    {
        private FrmMediosPago frmMediosPago;
        private FrmBuscar frmBuscar;
        private int idVender;
        private int numDoc;
        private string nombreApellido;
        private string tipoDoc;      
        private string direccion;

        public FrmCliente(FrmBuscar buscar)
        {
            frmBuscar = buscar;
            InitializeComponent();
            frmMediosPago = new FrmMediosPago(this, frmBuscar);          
        }

        public void cargarIdVenta(int id)
        {      
            idVender = id;
        }

        public void InicializarFormulario()
        {
            txtNombreApellido.Text = "";
            txtDocumento.Text = "";
            comboTipoDoc.Text = "";
            txtDirec.Text = "";
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            nombreApellido = txtNombreApellido.Text;
            tipoDoc = comboTipoDoc.Text;

            if (!Int32.TryParse(txtDocumento.Text, out numDoc))
            {
                Console.WriteLine($@"No se pudo convertir'{txtDocumento.Text}'");
            }

            direccion = txtDirec.Text;
            //Se invoca al siguiente método para enviarle al formulario MediosPago el ID de la venta
            frmMediosPago.cargarIdVenta(idVender);
            frmMediosPago.Show();
            this.Hide();

        }

        public void obtenerDatosCliente(ref string na, ref string td, ref int nd, ref string d)
        {
            na = nombreApellido;
            td = tipoDoc;
            nd = numDoc;
            d = direccion;
        }

        private void btnVolverCliente_Click(object sender, EventArgs e)
        {
            frmBuscar.Show();
            this.Hide();
        }
    }
}
