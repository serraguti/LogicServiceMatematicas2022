using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicServiceMatematicas
{
    public class NumeroDobleClass : INumeroDobleContract
    {
        public int GetNumeroDoble(int numero)
        {
            return numero * 2;
        }

        public string GetSaludo(string nombre)
        {
            return "Bienvenido a Servicios WCF, " + nombre;
        }

        public string MetodoInvisible()
        {
            return "Ni lo vamos a ver...";
        }
    }
}
