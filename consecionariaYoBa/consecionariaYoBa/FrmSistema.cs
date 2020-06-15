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
    public partial class FrmSistema : Form
    {
        private FrmBuscar frmBuscar;
        private FrmVentas frmVentas;
        private FrmLogin frmLogin;

        public FrmSistema()
        {
            InitializeComponent();
            frmBuscar = new FrmBuscar(this);          
        }

        public FrmSistema(FrmLogin login)
        {
            InitializeComponent();
           
            frmLogin = login;
            
            frmBuscar = new FrmBuscar(this);
            frmVentas = new FrmVentas(this);
           
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscar.Show();
            this.Hide();
            frmBuscar.CargaGrillaAutos();
        }

        private void FrmSistema_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = "Bienvenido " + frmLogin.devolverUsuario();        
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            frmVentas.Show();
            frmVentas.CargaGrillaVentas();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();         
        }
    }
}
