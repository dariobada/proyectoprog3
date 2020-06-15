using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace consecionariaYoBa
{
    static class Administracion
    {
        public static void actualizarAutosArchivo(Consecionaria cons)
        {
            
            if (File.Exists("Autos.txt"))
            {                
                File.Delete("Autos.txt");               
            }            
                
            Stream flujo = File.Create("Autos.txt");
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(flujo, cons);
            flujo.Close();           

        }
        public static List<Auto> obtenerAutosArchivo()
        {
            Consecionaria cons;
            List<Auto> autos = new List<Auto>();

            if (File.Exists("Autos.txt"))
            {
                Stream flujo = File.OpenRead("Autos.txt");
                BinaryFormatter deserializer = new BinaryFormatter();
                cons = (Consecionaria)deserializer.Deserialize(flujo);
                flujo.Close();
                
                foreach(Auto aux in cons.devolverAutosConsecionaria())
                {
                    autos.Add(aux);
                }
            }
            
            return autos;
        }

        public static List<Venta> obtenerVentasArchivo()
        {
            ModuloComercial modulo;
            List<Venta> ventas = new List<Venta>();

            if (File.Exists("Ventas.txt"))
            {
                Stream flujo = File.OpenRead("Ventas.txt");
                BinaryFormatter deserializer = new BinaryFormatter();
                modulo = (ModuloComercial)deserializer.Deserialize(flujo);
                flujo.Close();

                foreach (Venta aux in modulo.devolverVentasModuloComercial())
                {
                    ventas.Add(aux);
                }
            }

            return ventas;
        }

        public static void actualizarVentasArchivo(ModuloComercial modulo)
        {

            if (File.Exists("Ventas.txt"))
            {
                File.Delete("Ventas.txt");
            }

            Stream flujo = File.Create("Ventas.txt");
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(flujo, modulo);
            flujo.Close();

        }


    }
}
