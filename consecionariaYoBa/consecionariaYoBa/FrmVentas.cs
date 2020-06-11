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

        private void btnVolverVentas_Click(object sender, EventArgs e)
        {
            frmSistema.Show();
            this.Hide();
        }
    }
}
