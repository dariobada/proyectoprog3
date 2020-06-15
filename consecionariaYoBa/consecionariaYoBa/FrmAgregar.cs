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
        private FrmBuscar frmBuscar;

        public FrmAgregar()
        {
            InitializeComponent();
        }

        public FrmAgregar(FrmBuscar buscar)
        {
            frmBuscar = buscar;          
            InitializeComponent();
            comboColor.Items.Add("Rojo");
            comboColor.Items.Add("Azul");
            comboColor.Items.Add("Verde");
            comboColor.Items.Add("Amarillo");

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmBuscar.Show();
            this.Hide();
            frmBuscar.CargaGrillaAutos();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Consecionaria cons = new Consecionaria();
            Auto auto;

            string aux_cond;
            string aux_equi = "";
            int aux_km;            
            int aux_puertas;
            int idaux;
            int precioaux = 0;
            
            //Validaciones del formulario

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

            if (!Int32.TryParse(txtPrecio.Text, out precioaux))
            {
                Console.WriteLine($@"No se pudo convertir'{txtPrecio.Text}'");
            }

            //Vamos a obtener el ID para generar el auto

            idaux = cons.obtenerIdAuto();

            auto = new Auto(idaux, txtMarca.Text, txtModelo.Text, comboColor.Text, aux_puertas, aux_cond, aux_km, txtDescripcion.Text, aux_equi, precioaux);

            //IMPORTANTE: agregar try catch a la siguiente llamada a método

            //Agregamos el auto generado a la lista de autos de la consecionaria

            cons.agregarAutoConsecionaria(auto);
            
            //Grabamos la lista de autos de consecionaria en el archivo "autos"
            Administracion.actualizarAutosArchivo(cons);

            MessageBox.Show("Auto agregado Correctamente");

            //Inicializamos las variables del formulario

            inicializarFormulario();

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

        public void inicializarFormulario()
        {
            txtMarca.Text = "";
            txtModelo.Text = "";
            comboColor.Text = null;
            txtPuertas.Text = "";
            radioNuevo.Checked = false;
            radioUsado.Checked = false;
            txtKm.Text = "";
            txtDescripcion.Text = "";
            checkABS.Checked = false;
            checkAir.Checked = false;
            txtPrecio.Text = "";
        }
    }
}
