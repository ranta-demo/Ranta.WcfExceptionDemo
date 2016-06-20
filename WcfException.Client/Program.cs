using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WcfException.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcProxy proxy = new CalcProxy();

            try
            {
                Console.WriteLine(proxy.Add(2, 3));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.Read();
        }
    }
}
