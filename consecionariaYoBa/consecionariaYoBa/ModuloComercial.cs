using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consecionariaYoBa
{
    [Serializable]

    class ModuloComercial
    {
        List<Venta> ventas = new List<Venta>();

        public ModuloComercial()
        {
            ventas = Administracion.obtenerVentasArchivo();
        }

        public void agregarVentaModuloComercial(Venta venta)
        {
            ventas.Add(venta);
        }

        public List<Venta> devolverVentasModuloComercial()
        {
            return ventas;
        }

        public int obtenerIdVenta()
        {
            int idaux = 1;

            foreach (Venta venta_aux in ventas)
            {
                idaux++;
            }

            return idaux;

        }

    }
}
