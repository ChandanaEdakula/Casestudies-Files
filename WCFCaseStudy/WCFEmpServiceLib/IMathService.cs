using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCFEmpServiceLib
{
    [ServiceContract]
    public interface IMathService
    {
        [OperationContract]
        [FaultContract(typeof(WCFEmpServiceLib.MyException))]
        void DivideNumber();
    }
}
