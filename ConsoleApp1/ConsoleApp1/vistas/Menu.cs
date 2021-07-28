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
                
            } while (opcion != 2);
            
        }

        private void SeleccionarAccion(int opcion)
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
                    break;

            }
        }

        private void MostrarMenuCalcularInmubele()
        {
            string direccion;
            int metros2;
            bool esNuevo;
            int precioBase;
            int cantVentanas;
            int nroPiso;
            int opcion;
            
            Console.WriteLine("Ingrese la direccion del inmuble");
            direccion = Console.ReadLine();
            Console.WriteLine("Ingrese los metros cuadrados");
            metros2 = int.Parse(Console.ReadLine());
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
            Console.WriteLine("¿Qué tipo de inmubele desea calcular?");
            Console.WriteLine("1- Piso");
            Console.WriteLine("2- Local");
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Ingrese el numero de piso");
                    nroPiso = int.Parse(Console.ReadLine());
                    break;
                case 2:
                    Console.WriteLine("Ingrese el número de ventanas");
                    cantVentanas = int.Parse(Console.ReadLine());
                    break;
                default:
                    Console.WriteLine("La opción ingresada es invalida");
                    break;
            }
            PrecioControlador precioControlador = new PrecioControlador();

        }
    }
}
