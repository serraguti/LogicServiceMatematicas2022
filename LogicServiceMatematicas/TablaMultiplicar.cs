using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LogicServiceMatematicas
{
    [DataContract]
    public class TablaMultiplicar
    {
        [DataMember]
        public String Operacion { get; set; }
        [DataMember]
        public int Resultado { get; set; }
    }
}
