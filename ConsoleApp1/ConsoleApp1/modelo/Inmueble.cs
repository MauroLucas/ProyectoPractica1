using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.modelo
{
    abstract class Inmueble
    {
        
        protected String direccion;
        protected int metros2;
        protected bool esNuevo;
        protected int precioBase;
        
        
        public Inmueble()
        {

        }


        public abstract double calcularPrecio();
        

    }
}
