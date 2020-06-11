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

        public FrmCliente(FrmBuscar buscar)
        {
            frmBuscar = buscar;
            InitializeComponent();
            frmMediosPago = new FrmMediosPago(this);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtDocumento_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            frmMediosPago.Show();
            this.Hide();

        }

        private void btnVolverCliente_Click(object sender, EventArgs e)
        {
            frmBuscar.Show();
            this.Hide();
        }
    }
}
