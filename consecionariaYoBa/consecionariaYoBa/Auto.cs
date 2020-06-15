using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consecionariaYoBa
{
    [Serializable]

    class Auto
    {  
        private int id;
        private string marca;
        private string modelo;
        private string color;
        private int puertas;
        private string condicion;
        private int km;
        private string descripcion;
        private string equipamiento;
        private int precio;
  
        public Auto(int i, string ma, string mo, string co, int pu, string con, int k, string desc, string equi, int p)
        {
            id = i;
            marca = ma;
            modelo = mo;
            color = co;
            puertas = pu;
            condicion = con;
            km = k;
            descripcion = desc;
            equipamiento = equi;
            precio = p;

        }
       
        public int devolverId()
        {
            return id;
        }

        public string devolverMarca()
        {
            return marca;
        }

        public string devolverModelo()
        {
            return modelo;
        }

        public string devolverColor()
        {
            return color;
        }

        public int devolverPuertas()
        {
            return puertas;
        }

        public string devolverCondicion()
        {
            return condicion;
        }

        public int devolverKm()
        {
            return km;
        }

        public string devolverDescripcion()
        {
            return descripcion;
        }

        public string devolverEquipamiento()
        {
            return equipamiento;
        }

        public int devolverPrecio()
        {
            return precio;
        }


    }
}