using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using WcfException.Common;

namespace WcfException.Server
{
    class CalcService : ICalcService
    {
        public int Add(int a, int b)
        {
            FaultData faultData = new FaultData
            {
                ErrorCode = -1,
                Message = string.Format("{0} + {1} = {2}", a, b, a + b)
            };
            throw new FaultException<FaultData>(faultData, faultData.Message);
        }
    }
}
