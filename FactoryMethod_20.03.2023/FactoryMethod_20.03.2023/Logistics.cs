using FactoryMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_
{
    static class Logistics
    {
        static List<Transport> transports = new List<Transport>();

        public static void AddTransport(params Transport[] t)
        {
            foreach (var transport in t)
            {
                transports.Add(transport);
            }
        }

        public static void RemoveTransportByIndex(int index) 
        {
            transports.RemoveAt(index);
        }

        public static int GetLength()
        {
            return transports.Count;
        }

        public static Transport GetTransport(int index)
        {
            return transports[index];
        }
    } 
}
