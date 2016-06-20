using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace WcfException.Common
{
    [DataContract]
    public class FaultData
    {
        public int ErrorCode { get; set; }

        public string Message { get; set; }
    }
}
