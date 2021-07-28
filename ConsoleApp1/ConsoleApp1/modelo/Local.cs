using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.modelo
{
    class Local : Inmueble
    {
        private int cantVentanas;
        public override double calcularPrecio()
        {
            double antiguedad;
            double metros;
            double ventanas;
            if (this.esNuevo)
            {
                antiguedad =  (this.precioBase * 1/100);
            }
            else
            {
                antiguedad = (this.precioBase * 2 / 100);
            }

            if(this.metros2 > 50)
            {
                metros = this.precioBase * 1 / 100;
            }

            if(cantVentanas == 1 || cantVentanas == 0)
            {
                ventanas = this.precioBase * 2 / 100;
            }
            else if(cantVentanas > 4)
            {
                ventanas = this.precioBase * 2 / 100;
            }

            return this.precioBase + antiguedad + ventanas + metros;
        }
    }
}
