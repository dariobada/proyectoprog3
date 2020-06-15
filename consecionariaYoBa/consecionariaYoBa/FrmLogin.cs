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
    public partial class FrmLogin : Form
    {
        private FrmSistema frmSistema;
        private string nombre;

        public FrmLogin()
        {
            InitializeComponent();
            frmSistema = new FrmSistema(this);
        }

        private void btnAceptarLogin_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                MessageBox.Show("Debe ingresar un Nombre de Usuario", "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                nombre = txtUsuario.Text;
                frmSistema.Show();
                this.Hide();
            }
        }
        public string devolverUsuario()
        {
            return nombre;
        }
        
    }
}
