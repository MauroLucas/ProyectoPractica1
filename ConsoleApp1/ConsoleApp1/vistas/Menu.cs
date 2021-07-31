using ConsoleApp1.controladores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.vistas
{
    class Menu
    {
        public Menu()
        {
            MostrarMenuPrincipal();
        }

        private void MostrarMenuPrincipal()
        {
            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("¿Qué desea hacer?");
                Console.WriteLine("1-Calcular valor del inmueble");
                Console.WriteLine("2-Salir");
                opcion = int.Parse(Console.ReadLine());
                SeleccionarAccion(ref opcion);
                
            } while (opcion != 2);
            
        }

        private void SeleccionarAccion(ref int opcion)
        {
            switch (opcion)
            {
                case 1:
                    MostrarMenuCalcularInmubele();
                    break;
                case 2: 
                    break;
                default: 
                    Console.WriteLine("La opción ingresada es inválida");
                    Console.ReadKey();
                    break;

            }
        }

        private void MostrarMenuCalcularInmubele()
        {
            string direccion = "";
            int metros2 = 0;
            bool esNuevo = false;
            String tipoInmueble = "";
            int precioBase = 0;
            int cantVentanas = 0;
            int nroPiso = 0;
            
            
            IngresarDireccion(ref direccion);
            IngresarMetrosCuadrados(ref metros2);
            IngresarEstadoInmueble(ref esNuevo);
            IngresarTipoInmueble(ref cantVentanas, ref nroPiso, ref tipoInmueble);
            IngresarPrecioBase(ref precioBase);
            
            PrecioControlador precioControlador = new PrecioControlador();          
            
            double resultado = precioControlador.calcularPrecioInmueble(direccion, metros2, esNuevo, precioBase, cantVentanas, nroPiso, tipoInmueble);
            Console.WriteLine("El precio del inmueble es de " + resultado);
            Console.ReadKey();

        }

        private void IngresarDireccion(ref String direccion)
        {
            Console.WriteLine("Ingrese la direccion del inmuble");
            direccion = Console.ReadLine();
        }

        private void IngresarMetrosCuadrados(ref int metros2)
        {
            bool continua;
            do
            {
                try
                {
                    continua = false;
                    Console.WriteLine("Ingrese los metros cuadrados");
                    metros2 = int.Parse(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Debe ingresar un numero entero");
                    continua = true;
                }

            } while (continua);
            
            
        }

        private void IngresarEstadoInmueble(ref bool esNuevo)
        {
            Console.WriteLine("Ingrese el estado del inmueble");
            Console.WriteLine("1- Nuevo (Menos de 15 años)");
            Console.WriteLine("2- Usado");
            switch (Console.ReadLine())
            {
                case "1":
                    esNuevo = true;
                    break;
                case "2":
                    esNuevo = false;
                    break;

            }

        }

        private void IngresarTipoInmueble(ref int cantVentanas, ref int nroPiso, ref String tipoInmueble)
        {
            int opcion;
            Console.WriteLine("¿Qué tipo de inmubele desea calcular?");
            Console.WriteLine("1- Piso");
            Console.WriteLine("2- Local");
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    tipoInmueble = "Piso";
                    Console.WriteLine("Ingrese el numero de piso");
                    nroPiso = int.Parse(Console.ReadLine());
                    break;
                case 2:
                    tipoInmueble = "Local";
                    Console.WriteLine("Ingrese el número de ventanas");
                    cantVentanas = int.Parse(Console.ReadLine());
                    break;
                default:
                    Console.WriteLine("La opción ingresada es invalida");
                    break;
            }

        }
        private void IngresarPrecioBase(ref int precioBase)
        {
            Console.WriteLine("Ingrese el precio base del inmueble");
            precioBase = int.Parse(Console.ReadLine());
        }
    }
}
