using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consecionariaYoBa
{
    [Serializable]

    class Venta
    {
        private int id;
        private string nombreApellido;
        private string tipoDoc;
        private int numDoc;
        private string direccion;
        private string pago;
        private double numTarjeta;
        private int numCuotas;
        private string marca;
        private string modelo;
        private int precio;

        public Venta(int i, string na, string td, int nd, string di, string p, double nt, int nc, string ma, string mo, int pre)
        {
            id = i;
            nombreApellido = na;
            tipoDoc = td;
            numDoc = nd;
            direccion = di;
            pago = p;
            numTarjeta = nt;
            numCuotas = nc;
            marca = ma;
            modelo = mo;
            precio = pre;

        }

        public int devolverId()
        {
            return id;
        }
            
        public string devolverNombreApellido()
        {
            return nombreApellido;
        }

        public string devolverTipoDoc()
        {
            return tipoDoc;
        }

        public int devolverNumDoc()
        {
            return numDoc;
        }

        public string devolverDireccion()
        {
            return direccion;
        }

        public string devolverPago()
        {
            return pago;
        }

        public double devolverNumTarjeta()
        {
            return numTarjeta;
        }

        public int devolverNumCuotas()
        {
            return numCuotas;
        }

        public string devolverMarca()
        {
            return marca;
        }

        public string devolverModelo()
        {
            return modelo;
        }
        
        public int devolverPrecio()
        {
            return precio;
        }
    }
}
