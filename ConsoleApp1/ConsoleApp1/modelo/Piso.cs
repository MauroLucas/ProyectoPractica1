using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.modelo
{
    class Piso : Inmueble
    {
        //atributos
        private int numeroPiso;

        //constructores
        public Piso(String direccion, int metros2, bool esNuevo, int precioBase, int numeroPiso) : base(direccion,  metros2,  esNuevo,  precioBase)
        {
            this.NumeroPiso = numeroPiso;
        }

        public int NumeroPiso { get => numeroPiso; set => numeroPiso = value; }

        //metodos
        public override double calcularPrecio()
        {
            double antiguedad = 0;            
            double pisos = 0;
            
            if (this.EsNuevo)
            {
                antiguedad = -(this.PrecioBase * 1 / 100);
            }
            else
            {
                antiguedad = -(this.PrecioBase * 2 / 100);
            }

            if(NumeroPiso >=3)
            {
                pisos = this.PrecioBase * 3 / 100;
            }

               

            return this.PrecioBase + antiguedad +   pisos;
        }

      
    }
}
