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
        
        public FrmBuscar(Form sistema)
        {
            frmSistema = sistema;
            InitializeComponent();          
            frmAgregar = new FrmAgregar(this);
            frmModificar = new FrmModificar(this);
            frmCliente = new FrmCliente(this);
        }

        

        private void BtnVolverBuscar_Click(object sender, EventArgs e)
        {
            frmSistema.Show();
            this.Hide();

        }

        public void CargaGrillaAutos()
        {
            
            Consecionaria cons = new Consecionaria();
            List<Auto> autos = new List<Auto>();

            DgvAutos.Rows.Clear();
            //Obtenemos los autos de la consecionaria y los cargamos en la grilla
            autos = cons.devolverAutosConsecionaria();
            
            foreach(Auto autonuevo in autos)
            {
                DgvAutos.Rows.Add(autonuevo.devolverId(), autonuevo.devolverMarca(), autonuevo.devolverModelo(), autonuevo.devolverColor(), autonuevo.devolverPrecio(), autonuevo.devolverCondicion(), autonuevo.devolverKm(), autonuevo.devolverEquipamiento(), autonuevo.devolverPuertas(), autonuevo.devolverDescripcion());
            } 
                      
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregar.Show();
            this.Hide();
            frmAgregar.inicializarFormulario();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int auxid1 = 0;
            int auxpuertas = 0;
            int auxkm = 0;
            int precioaux = 0;
            string auxmarca = "";
            string auxmodelo = "";
            string auxcolor = "";            
            string auxcondicion = "";           
            string auxequipamiento = "";
            string auxdescripcion = "";
                               
            if (!Int32.TryParse(txtIdModificar.Text, out auxid1))
            {
                Console.WriteLine($@"No se pudo convertir'{txtIdModificar.Text}'");
            }

            //Buscamos en la grilla si existe el ID ingresado

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
                    precioaux = (int)fila.Cells["colPrecio"].Value;
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
                //Invocamos al siguiente método para precargar los datos del formulario "Modificar"
                frmModificar.precargarDatos(auxid1, auxmarca, auxmodelo, auxcolor, precioaux, auxpuertas, auxcondicion, auxkm, auxequipamiento, auxdescripcion );
            }
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            int idaux = 0;
            bool flag = false;

            if (!Int32.TryParse(txtIdVender.Text, out idaux))
            {
                Console.WriteLine($@"No se pudo convertir'{txtIdVender.Text}'");
            }

            //Recorremos la grilla para verificar si existe el ID ingresado

            foreach (DataGridViewRow fila in DgvAutos.Rows)
            {
                if (idaux == (int)fila.Cells["colId"].Value)
                {
                    flag = true;
                }
            }

            if (flag == false)
            {
                MessageBox.Show("Debe ingresar un ID existente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                frmCliente.Show();
                //Invocamos al siguiente método para enviar al formulario "cliente" el ID de la venta
                frmCliente.cargarIdVenta(idaux); 
                this.Hide();               
            }
        
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Consecionaria cons;
            int idaux = 0;
            bool flag = false;
            
            if (!Int32.TryParse(txtIdEliminar.Text, out idaux))
            {
                Console.WriteLine($@"No se pudo convertir'{txtIdEliminar.Text}'");
            }
            //Recorremos la grilla para verificar si existe el ID ingresado
            foreach (DataGridViewRow fila in DgvAutos.Rows)
            {
                if (idaux == (int)fila.Cells["colId"].Value)
                {
                    flag = true;
                }
            }

            if (flag == false)
            {
                MessageBox.Show("Debe ingresar un ID existente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("¿Está seguro que desea eliminar el auto con Id: " + idaux + "?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cons = new Consecionaria();
                    //Se elimina el auto de la lista de "Autos" de consecionaria
                    cons.eliminarAutoConsecionaria(idaux);
                    //Se graba el archivo con la lista de auto de consecionaria
                    Administracion.actualizarAutosArchivo(cons);
                    MessageBox.Show("Auto eliminado correctamente");
                    CargaGrillaAutos();
                }

            }
                      
        }
    }
}
