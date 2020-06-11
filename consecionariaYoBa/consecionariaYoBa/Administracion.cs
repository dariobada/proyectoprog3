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
            
            if (File.Exists("consecionaria.txt"))
            {                
                File.Delete("consecionaria.txt");               
            }            
                
            Stream flujo = File.Create("consecionaria.txt");
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(flujo, cons);
            flujo.Close();           

        }
        public static List<Auto> obtenerAutosArchivo()
        {
            Consecionaria cons;
            List<Auto> autos = new List<Auto>();

            if (File.Exists("consecionaria.txt"))
            {
                Stream flujo = File.OpenRead("consecionaria.txt");
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

        
    }
}
