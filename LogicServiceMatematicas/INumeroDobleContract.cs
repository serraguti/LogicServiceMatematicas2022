using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace LogicServiceMatematicas
{
    [ServiceContract]
    public interface INumeroDobleContract
    {
        //SOLAMENTE DECLARAMOS METODOS
        int GetNumeroDoble(int numero);
        string GetSaludo(string nombre);
        string MetodoInvisible();
    }
}
