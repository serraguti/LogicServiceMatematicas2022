using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicServiceMatematicas
{
    public class ServiceTablaMultiplicarClass : IServiceTablaMultiplicar
    {
        public List<TablaMultiplicar> GetTablaMultiplicar(int numero)
        {
            List<TablaMultiplicar> lista = new List<TablaMultiplicar>();
            for (int i = 1; i <= 10; i++)
            {
                int resultado = numero * i;
                string operacion = numero + " * " + i;
                TablaMultiplicar tabla = new TablaMultiplicar();
                tabla.Operacion = operacion;
                tabla.Resultado = resultado;
                lista.Add(tabla);
            }
            return lista;
        }
    }
}
