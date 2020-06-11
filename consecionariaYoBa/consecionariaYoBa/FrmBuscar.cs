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
    public partial class FrmBuscar : Form
    {
        private FrmAgregar frmAgregar;
        private Form frmSistema;
        private FrmModificar frmModificar;
        private FrmCliente frmCliente;
        public FrmBuscar()
        {
            InitializeComponent();
        }
        
        public FrmBuscar(Form sistema)
        {
            frmSistema = sistema;
            InitializeComponent();
            //CargaGrillaAutos();
            frmAgregar = new FrmAgregar(this);
            frmModificar = new FrmModificar(this);
            frmCliente = new FrmCliente(this);
        }

        

        private void BtnVolverBuscar_Click(object sender, EventArgs e)
        {
            frmSistema.Show();
            this.Hide();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void CargaGrillaAutos()
        {
            DgvAutos.Rows.Clear();
            Consecionaria cons = new Consecionaria();
            List<Auto> autos = new List<Auto>();

            //if (File.Exists("consecionaria.txt"))
            //{
            //    Stream flujo2 = File.OpenRead("consecionaria.txt");
            //    BinaryFormatter deserializer = new BinaryFormatter();
            //    cons = (Consecionaria)deserializer.Deserialize(flujo2);
            //    flujo2.Close();

            //}
            
            autos = cons.devolverAutosConsecionaria();
            
            foreach(Auto autonuevo in autos)
            {
                DgvAutos.Rows.Add(autonuevo.devolverId(), autonuevo.devolverMarca(), autonuevo.devolverModelo(), autonuevo.devolverColor(), autonuevo.devolverCondicion(), autonuevo.devolverKm(), autonuevo.devolverEquipamiento(), autonuevo.devolverPuertas(), autonuevo.devolverDescripcion());
            } 
            
            
                /* Auto auto = new Auto(5555, "Peugeot", "207", "Rosa");
                DgvAutos.Rows.Add(1111, "Toyota", "Hilux", "Blanco", "Nuevo", 0, "ABS;Airbags", 3, "");
                DgvAutos.Rows.Add(2222, "Peugeot", "307", "Azul", "Usado", 12000, "", 5, "Casi nuevo");
                DgvAutos.Rows.Add(3333, "Toyota", "Hilux", "Verde", "Usado", 100000, "", 3, "");
                DgvAutos.Rows.Add(4444, "Ford", "Fiest", "Blanco", "Nuevo", 0, "ABS", 3, "");
                */
            }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregar.Show();
            this.Hide();
           
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int auxid1 = 0;
            string auxmarca = "";
            string auxmodelo = "";
            string auxcolor = "";
            int auxpuertas = 0;
            string auxcondicion = "";
            int auxkm = 0;
            string auxequipamiento = "";
            string auxdescripcion = "";
            
          
            if (!Int32.TryParse(txtIdModificar.Text, out auxid1))
            {
                Console.WriteLine($@"No se pudo convertir'{txtIdModificar.Text}'");
            }
            foreach (DataGridViewRow fila in DgvAutos.Rows)
            {
                if (auxid1 == (int)fila.Cells["colId"].Value)
                {
                    auxmarca = (string)fila.Cells["colMarca"].Value;
                    auxmodelo = (string)fila.Cells["colModelo"].Value;
                    auxcolor = (string)fila.Cells["colColor"].Value;
                    auxpuertas = (int)fila.Cells["colPuertas"].Value;
                    auxcondicion = (string)fila.Cells["colCondicion"].Value;
                    auxkm = (int)fila.Cells["colKm"].Value;
                    auxequipamiento = (string)fila.Cells["colEquipamiento"].Value;
                    auxdescripcion = (string)fila.Cells["colDescripcion"].Value;

                }          
            }
            if(auxmarca == "")
            {
                MessageBox.Show("Debe ingresar un ID existente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                frmModificar.Show();
                this.Hide();
                frmModificar.precargarDatos(auxid1, auxmarca, auxmodelo, auxcolor, auxpuertas, auxcondicion, auxkm, auxequipamiento, auxdescripcion );
            }
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            frmCliente.Show();
            this.Hide();
        }

        private void txtIdModificar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
