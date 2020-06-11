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
        private FrmCliente frmCliente;
        
        public FrmMediosPago(FrmCliente cliente)
        {
            InitializeComponent();
            frmCliente = cliente;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnVolverVender_Click(object sender, EventArgs e)
        {
            frmCliente.Show();
            this.Hide();
        }
    }
}
