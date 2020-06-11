using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace consecionariaYoBa
{

    public partial class FrmAgregar : Form
    {
       // private Form frmSistema;
        private FrmBuscar frmBuscar;

        public FrmAgregar()
        {
            InitializeComponent();
        }
        public FrmAgregar(FrmBuscar buscar)
        {
            frmBuscar = buscar;
            //frmSistema = sistema;
            InitializeComponent();
            comboColor.Items.Add("Rojo");
            comboColor.Items.Add("Azul");
            comboColor.Items.Add("Verde");
            comboColor.Items.Add("Amarillo");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboColor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmBuscar.Show();
            this.Hide();
            frmBuscar.CargaGrillaAutos();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Consecionaria cons = new Consecionaria();
            Auto auto;

            string aux_cond;
            int aux_km;
            string aux_equi = "";
            int aux_puertas;
            int idaux;

            if (radioNuevo.Checked == true)
            {
                aux_cond = "Nuevo";
                aux_km = 0;
            }
            else
            {
                if (!Int32.TryParse(txtKm.Text, out aux_km))
                {
                    Console.WriteLine($@"No se pudo convertir'{txtKm.Text}'");
                }
                aux_cond = "Usado";

            }

            if (checkAir.Checked == true)
            {
                aux_equi = ";" + "Airbags";

            }

            if (checkABS.Checked == true)
            {
                aux_equi = aux_equi + ";" + "ABS";
            }

            if (!Int32.TryParse(txtPuertas.Text, out aux_puertas))
            {
                Console.WriteLine($@"No se pudo convertir'{txtKm.Text}'");
            }

            idaux = cons.obtenerIdAuto();

            auto = new Auto(idaux, txtMarca.Text, txtModelo.Text, comboColor.Text, aux_puertas, aux_cond, aux_km, txtDescripcion.Text, aux_equi);
                               
            //IMPORTANTE: agregar try catch a la siguiente llamada a método
            cons.agregarAutoConsecionaria(auto);
            Administracion.actualizarAutosArchivo(cons);

            MessageBox.Show("Auto agregado Correctamente");
            
            txtMarca.Text = "";
            txtModelo.Text = "";
            comboColor.Text = "";
            txtPuertas.Text = "";
            radioNuevo.Checked = false;
            radioUsado.Checked = false;
            txtKm.Text = "";
            txtDescripcion.Text = "";
            checkABS.Checked = false;
            checkAir.Checked = false;

        } 
    

        private void txtPuertas_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioUsado_CheckedChanged(object sender, EventArgs e)
        {
            lblKm.Visible = true;
            txtKm.Visible = true;
        }

        private void radioNuevo_CheckedChanged(object sender, EventArgs e)
        {
            lblKm.Visible = false;
            txtKm.Visible = false;
        }
    }
}
