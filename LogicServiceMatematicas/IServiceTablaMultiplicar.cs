using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace LogicServiceMatematicas
{
    [ServiceContract]
    public interface IServiceTablaMultiplicar
    {
        [OperationContract]
        List<TablaMultiplicar> GetTablaMultiplicar(int numero);
    }
}
