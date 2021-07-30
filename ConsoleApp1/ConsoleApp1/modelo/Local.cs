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

        public Local() { }

        public Local(String direccion, int metros2, bool esNuevo, int precioBase, int cantVentanas) : base(direccion, metros2, esNuevo, precioBase)
        {
            this.cantVentanas = cantVentanas;
        }

        public int CantVentanas { get => cantVentanas; set => cantVentanas = value; }
        

        public override double calcularPrecio()
        {
            double antiguedad = 0;
            double metros = 0;
            double ventanas = 0;
            if (this.EsNuevo)
            {
                antiguedad =  -(this.PrecioBase * 1/100);
            }
            else
            {
                antiguedad = -(this.PrecioBase * 2 / 100);
            }

            if(this.Metros2 > 50)
            {
                metros = PrecioBase * 1 / 100;
            }

            if(cantVentanas == 1 || cantVentanas == 0)
            {
                ventanas = -(this.PrecioBase * 2 / 100);
            }
            else if(cantVentanas > 4)
            {
                ventanas = (this.PrecioBase * 2 / 100);
            }

            return this.PrecioBase + antiguedad + ventanas + metros;
        }
    }
}
