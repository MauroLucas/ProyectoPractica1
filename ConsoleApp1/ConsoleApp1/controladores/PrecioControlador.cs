using ConsoleApp1.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.controladores
{
    class PrecioControlador
    {
        public double calcularPrecioInmueble(String direccion,int metros2,bool esNuevo,int precioBase,int cantVentanas,int nroPiso, String tipoInmueble)
        {
            
            double precioFinal = 0;
            switch (tipoInmueble)
            {
                case "Local":
                    Local local = new Local(direccion,metros2,esNuevo,precioBase,cantVentanas);
                    precioFinal = local.calcularPrecio();
                    break;
                case "Piso":
                    Piso piso = new Piso(direccion, metros2, esNuevo, precioBase, nroPiso);
                    precioFinal = piso.calcularPrecio();
                    break;
                default: break;
            }

            return precioFinal;
        }
    }
}
