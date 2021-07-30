using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.modelo
{
    abstract class Inmueble
    {

        private String direccion;
        private int metros2;
        private bool esNuevo;
        private int precioBase;

        protected string Direccion { get => direccion; set => direccion = value; }
        protected int Metros2 { get => metros2; set => metros2 = value; }
        protected bool EsNuevo { get => esNuevo; set => esNuevo = value; }
        protected int PrecioBase { get => precioBase; set => precioBase = value; }

        public Inmueble() { }
        
        public Inmueble(String direccion, int metros2, bool esNuevo, int precioBase)
        {
            this.direccion = direccion;
            this.metros2 = metros2;
            this.esNuevo = esNuevo;
            this.precioBase = precioBase;
        }

        public abstract double calcularPrecio();
        

    }
}
