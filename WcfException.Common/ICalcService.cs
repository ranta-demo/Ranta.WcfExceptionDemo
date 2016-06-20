using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace WcfException.Common
{
    [ServiceContract]
    public interface ICalcService
    {
        [OperationContract]
        [FaultContract(typeof(FaultData))]
        int Add(int a, int b);
    }
}
