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
    public partial class FrmModificar : Form
    {
        int idModificar = 0;
        private FrmBuscar frmBuscar;

        public FrmModificar(FrmBuscar buscar)
        {
            frmBuscar = buscar;
            InitializeComponent();
        }

        private void btnVolverAgregar_Click(object sender, EventArgs e)
        {
            frmBuscar.Show();
            this.Hide();
        }

        public void precargarDatos(int auxid1, string auxmarca, string auxmodelo, string auxcolor, int precioaux, int auxpuertas,string auxcondicion,int auxkm,string auxequipamiento,string auxdescripcion)
        {
            idModificar = auxid1;
            txtMarca.Text = auxmarca;
            txtModelo.Text = auxmodelo;
            comboColor.Text = auxcolor;
            txtPrecio.Text = precioaux.ToString();

            comboColor.Items.Add("Rojo");
            comboColor.Items.Add("Azul");
            comboColor.Items.Add("Verde");
            comboColor.Items.Add("Amarillo");

            txtPuertas.Text = auxpuertas.ToString();
            txtKm.Text = auxkm.ToString();
            txtDescripcion.Text = auxdescripcion;

            if (auxcondicion == "Nuevo")
            {
                radioNuevo.Checked = true;               
            }
            else
            {
                radioUsado.Checked = true;
                lblKm.Visible = true;
                txtKm.Visible = true;
            }

            if (auxequipamiento == ";ABS")
            {
                checkABS.Checked = true;
            }
            else
            {
                if (auxequipamiento == ";Airbags;ABS")
                {
                    checkABS.Checked = true;
                    checkAir.Checked = true;
                }
                else
                {
                    if (auxequipamiento == ";Airbags")
                    {
                        checkAir.Checked = true;
                    }
                }
            }
            
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Consecionaria cons = new Consecionaria();
            Auto auto;

            string aux_equi = "";
            string aux_cond;
            int aux_km;           
            int aux_puertas;            
            int precioaux;

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

            if (!Int32.TryParse(txtPrecio.Text, out precioaux))
            {
                Console.WriteLine($@"No se pudo convertir'{txtPrecio.Text}'");
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

            auto = new Auto(idModificar, txtMarca.Text, txtModelo.Text, comboColor.Text, aux_puertas, aux_cond, aux_km, txtDescripcion.Text, aux_equi, precioaux);

            //IMPORTANTE: agregar try catch a la siguiente llamada a método
            //Se actualiza los datos de auto seleccionado en la lista de autos de consecionaria
            cons.modificarAutoConsecionaria(auto, idModificar);
            //Se graba el archivo de autos con la lista de autos de consecionaria
            Administracion.actualizarAutosArchivo(cons);

            MessageBox.Show("Auto modificado Correctamente");

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
            txtPrecio.Text = "";

            frmBuscar.CargaGrillaAutos();
            frmBuscar.Show();
            this.Hide();
        }
    }
}
