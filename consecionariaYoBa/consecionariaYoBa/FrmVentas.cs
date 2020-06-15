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
    public partial class FrmVentas : Form
    {
        private FrmSistema frmSistema;

        public FrmVentas(FrmSistema sistema)
        {
            InitializeComponent();
            frmSistema = sistema;
        }

        public void CargaGrillaVentas()
        {
            ModuloComercial modulo = new ModuloComercial();
            List<Venta> ventas = new List<Venta>();
            dgvVentas.Rows.Clear();
            //Se obtiene la lista de ventas del módulo comercial y se carga la grilla
            ventas = modulo.devolverVentasModuloComercial();

            foreach (Venta ventanueva in ventas)
            {
                dgvVentas.Rows.Add(ventanueva.devolverNombreApellido(), ventanueva.devolverTipoDoc(), ventanueva.devolverNumDoc(), ventanueva.devolverDireccion(), ventanueva.devolverPago(), ventanueva.devolverNumTarjeta(), ventanueva.devolverNumCuotas(), ventanueva.devolverMarca(), ventanueva.devolverModelo(), ventanueva.devolverPrecio());
            }
        }

        private void btnVolverVentas_Click(object sender, EventArgs e)
        {
            frmSistema.Show();
            this.Hide();
        }
    }
}
