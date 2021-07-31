using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.funciones
{
    class Funciones
    {
        public static bool validarCampo(String dato,String tipo)
        {
            switch (tipo)
            {
                case "int":
                    try
                    {
                        Convert.ToInt32(dato);
                        return true;
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                    
                default: return false;
            }
        }
    }
}
