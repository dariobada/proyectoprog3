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

        public void eliminarAutoConsecionaria( int idEliminar)
        {
            List<Auto> listAux = new List<Auto>();
            int contador = 0;
            foreach (Auto autoaux in autos)
            {
                listAux.Add(autoaux);

            }

            autos.Clear();

            foreach (Auto autoaux in listAux)
            {
                if (idEliminar != autoaux.devolverId())
                {
                    autos.Add(autoaux);
           
                }
                contador++;
            }


        }

        public Auto devolverAutoPorId(int id)
        {
            foreach (Auto autoaux in autos)
            {
               if (autoaux.devolverId()== id)
                {
                    return autoaux;
                }

            }
            return null;

        }

        public int obtenerIdAuto() 
        {
            int idaux = 0;

            foreach(Auto auto_aux in autos)
            {
                if (auto_aux.devolverId() > idaux)
                {
                    idaux = auto_aux.devolverId();
                }
            }
            idaux++;
            return idaux;

        }
    }
}
