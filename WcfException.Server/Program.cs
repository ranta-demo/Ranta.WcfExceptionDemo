using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace WcfException.Server
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(CalcService)))
            {
                host.Open();

                Console.WriteLine("...");

                Console.Read();
            }
        }
    }
}
