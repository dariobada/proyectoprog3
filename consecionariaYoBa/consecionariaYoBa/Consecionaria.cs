using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consecionariaYoBa
{
    [Serializable]

    class Consecionaria
    {
        List<Auto> autos = new List<Auto>();

        public Consecionaria()
        {
            autos = Administracion.obtenerAutosArchivo();
        } 
        
        public void agregarAutoConsecionaria(Auto auto)
        {          
            autos.Add(auto);           
        }
        public List<Auto> devolverAutosConsecionaria()
        {
            return autos;
        }
        public void modificarAutoConsecionaria(Auto auto, int idModificar)
        {
            List<Auto> listAux = new List<Auto>();
            int contador = 0;
            foreach (Auto autoaux in autos)
            {
                listAux.Add(autoaux);

            }
           
            foreach (Auto autoaux in listAux)
            {
                if (idModificar == autoaux.devolverId())
                {
                    autos.Remove(autoaux);
                    autos.Insert(contador, auto);
                }
                contador++;
            }
            

        }

        public int obtenerIdAuto()
        {
            int idaux = 1;

            foreach(Auto auto_aux in autos)
            {
                idaux++;
            }

            return idaux;

        }
    }
}
