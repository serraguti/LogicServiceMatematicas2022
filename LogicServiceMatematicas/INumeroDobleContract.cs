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
        //LOS METODOS DEL SERVICIO QUE DESEEMOS MOSTRAR
        //AL CLIENTE FINAL, DEBEN IR CON LA DECORACION
        //OperationContract
        [OperationContract]
        int GetNumeroDoble(int numero);
        [OperationContract]
        string GetSaludo(string nombre);
        string MetodoInvisible();
    }
}
