using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using WcfException.Common;

namespace WcfException.Client
{
    class CalcProxy : ICalcService
    {
        public int Add(int a, int b)
        {
            using (ChannelFactory<ICalcService> factory = new ChannelFactory<ICalcService>("ep001"))
            {
                try
                {
                    ICalcService client = factory.CreateChannel();

                    return client.Add(a, b);
                }
                catch (FaultException<FaultData> fault)
                {
                    throw new Exception(fault.Message);
                }
            }
        }
    }
}
